/***********************************************************************\
 *  
 *  File:       ViewCustomer.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the ViewCustomer form. 
 *  The purpose of this form is to display to Customer information and
 *  the files and images associated with the Customer. 
 *  
 *  This form also allows the user to edit the Customer and add Files
 *  associated to the Customer. 
 *  
 \***********************************************************************/


using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using CustomerFileManager.Models.CustomerModels;
using CustomerFileManager.DataAccess;
using CustomerFileManager.Models.FileModels;
using CustomerFileManager.Reports;

using WinFormUI.Utilities;


namespace WinFormUI.CustomerForms
{
    public partial class ViewCustomer : Form
    {
        private bool editMode = false;                                          // the current display mode edit/view

        private Customer customer;                                              // customer object from overloaded constructor
        private Customer tempCustomer = new Customer();                         // temporary customer object to store edited values

        private List<CustomerFile> customerFiles = new List<CustomerFile>();    // array list for storing customer files 
        private ImageList customerImages = new ImageList();                     // create new ImageList for storing client images
        private ArrayList missingFiles = new ArrayList();                       // array list for storing missing customer files 

        /// <summary>
        /// Default constructor used to initialize the form component.
        /// Also sets the form to readonly.
        /// </summary>
        public ViewCustomer()
        {
            InitializeComponent();

            // subscribe to events
            FileDataAccess.FileSaved += RefreshListViews;       // a new file is saved
            FileDataAccess.FileUpdated += RefreshListViews;     // a file was updated
            FileDataAccess.FileDeleted += RefreshListViews;     // a file was deleted

            ToggleEditMode(); // make form readonly on initial load
        }

        /// <summary>
        /// The event handler for the FileSaved, FileUpdated, and FileDeleted Events.
        /// Reloads the Customer files ListViews to reflect any changes to the customer files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void RefreshListViews(object sender, EventArgs e)
        {
            LoadCustomerFiles();    // reload the customer files
            CalculateStatistics();  // re-calculate the statistics
        }

        /// <summary>
        /// Overloaded constructor that takes a Customer object and assigns to a private field in the ViewCustomer form. 
        /// This object is also used to populate the form fields with values.
        /// </summary>
        /// <param name="customer">The Customer object to view</param>
        public ViewCustomer(Customer customer) : this()
        {
            this.customer = customer;       // assign Customer object parameter to customer field

            PopulateCustomerFields();       // populate the text fields with the corresponding Customer values
            InitializeListViews();          // Setup the client files ListView component
            LoadCustomerFiles();            // load the client files into relative list views
            CalculateStatistics();          // calculate customer statistics
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calculates Customer statistics such as Total Files and Total Images
        /// </summary>
        private void CalculateStatistics()
        {
            // Calculate Total Files
            TotalFilesLabelValue.Text = customerFiles.Count.ToString();

            // Calculate Total Images 
            TotalImagesLabelValue.Text = customerImages.Images.Count.ToString();

        }

        /// <summary>
        /// Populates the Customer Fields with the customer object values 
        /// passed in from the overloaded contructor
        /// </summary>
        private void PopulateCustomerFields()
        {
            try // Populate the Customer Fields
            {
                tempCustomer.CopyValues(customer);                                    // copy the values from the customer object to the tempCustomer object

                // assign the field text to the corresponding customer property
                NameTextBox.Text = customer.Name;                                     // customer name
                PhoneTextBox.Text = customer.Phone;                                   // customer phone
                EmailTextBox.Text = customer.Email;                                   // customer email

                CustomerIDLabelValue.Text = customer.CustomerId.ToString();           // show the customer id
                FormLabel.Text = $"Customer #{customer.CustomerId}: {customer.Name}"; // update form label with current customer
                SendEmailLink.Visible = (customer.Email.Trim() != null);              // show/hide Send Email link if no email is provided
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Toggles the form between edit mode and readonly mode. 
        /// Edit mode enables form input and makes delete and cancel buttons visible. 
        /// Readonly mode makes form fields readonly and hides the cancel and delete buttons.
        /// </summary>
        private void ToggleEditMode()
        {
            // Adjust readonly property of textbox's depending on current mode
            NameTextBox.ReadOnly = !editMode;
            PhoneTextBox.ReadOnly = !editMode;
            EmailTextBox.ReadOnly = !editMode;

            // adjust form depending on the current mode (edit/readonly)
            CancelButton.Visible = editMode;
            DeleteCustomerButton.Visible = editMode;

            switch (editMode)
            {
                case true: // edit mode
                    EditCustomerButton.Text = "Save"; // change edit button text to 'Save'
                    break;
                case false: // readonly mode
                    EditCustomerButton.Text = "Edit Customer"; // change edit button text to 'Edit'
                    break;
            }

            editMode = !editMode; // toggle edit mode
        }

        /// <summary>
        /// Prompts the user to delete the current Customer. 
        /// If the user selects Yes, the customer will be deleted otherwise continue as normal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            // Confirm that the user actually wants to delete this record
            DialogResult deleteConfirmation = MessageBox.Show(
                $"Are you sure you want to delete {customer.Name} as a cusomter?\nThis action cannot be undone!",
                "Delete Customer?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // if user selects 'Yes' then delete the Customer object
            if (deleteConfirmation == DialogResult.Yes)
            {
                try // Delete the Customer
                {
                    CustomerDataAccess.DeleteCustomer(customer);                    // Attempt to delete the Customer
                    MessageBox.Show($"{customer.Name} successfully deleted!");      // show delete confirmation
                    this.Close();                                                   // close the form
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); // display exception message
                }
            }
        }

        /// <summary>
        /// Enables the form to be in 'edit' mode allowing fields to be edited
        /// When in 'edit' mode the button text reads 'Save' and attempts to save the customer object 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!editMode) // attempt to save record if in edit mode
                {
                    CustomerDataAccess.UpdateCustomer(tempCustomer);    // attempt to update customer 
                    customer.CopyValues(tempCustomer);                  //assign customer values with the updated values
                }
                ToggleEditMode();                                       // toggle between edit and readonly mode
                PopulateCustomerFields();                               // repopulate fields
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Adjusts the Temporary Customer object with the value stored in the Name text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            tempCustomer.Name = NameTextBox.Text;
        }

        /// <summary>
        /// Adjusts the Temporary Customer object with the value stored in the Phone text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            tempCustomer.Phone = PhoneTextBox.Text;
        }

        /// <summary>
        /// Adjusts the Temporary Customer object with the value stored in the Email text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            tempCustomer.Email = EmailTextBox.Text;
        }

        /// <summary>
        /// Cancels edit mode and reverts to readonly mode. 
        /// Repopulates the fields with original values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            ToggleEditMode();               // revert to readonly mode
            PopulateCustomerFields();       // repopulate customer fields with original value
        }

        /// <summary>
        /// Opens the users default mail client to send an email using the customers 
        /// provided email address.  If no email is provided then no action is taken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendEmailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(EmailTextBox.Text))
            {
                try
                {
                    Process.Start($"mailto:{customer.Email}"); // open email client
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Initializes and creates headings for the Files ListView component
        /// </summary>
        private void InitializeListViews()
        {
            // Setup the AllFilesListView Properties
            AllFilesListView.Items.Clear();                     // Clear the ListViewItems
            AllFilesListView.View = View.Details;               // Set view to show details
            AllFilesListView.FullRowSelect = true;              // select item and subitems when selection made
            AllFilesListView.GridLines = true;                  // display grid lines
            AllFilesListView.Sorting = SortOrder.Ascending;     // sort items in ascending order
            AllFilesListView.SmallImageList = Utilities.IconUtilities.ImageList32; // set icon list

            // Create the AllFilesView Columns (width of -2 indicates auto-size)
            AllFilesListView.Columns.Clear(); // Resets the columns
            AllFilesListView.Columns.Add("Name", 200, HorizontalAlignment.Left);
            AllFilesListView.Columns.Add("Type", 100, HorizontalAlignment.Left);
            AllFilesListView.Columns.Add("Filename", 150, HorizontalAlignment.Left);
            AllFilesListView.Columns.Add("Location", -2, HorizontalAlignment.Left);

            // Setup the ImagesListView Properties
            customerImages.ImageSize = new Size(128, 128);      // set image size 128x128
            customerImages.ColorDepth = ColorDepth.Depth32Bit;  // set 32bit color depth
            ImagesListView.LargeImageList = customerImages;     // set image list source for ImagesListView

            // Setup the MissingFilesListView Properties
            MissingFilesListView.Items.Clear();
            MissingFilesListView.View = View.Details;           // Set list view to 'details view'
            MissingFilesListView.FullRowSelect = true;          // select item and subitems when selection made
            MissingFilesListView.GridLines = true;              // display grid lines
            MissingFilesListView.Sorting = SortOrder.Ascending; // sort items in ascending order
            MissingFilesListView.SmallImageList = Utilities.IconUtilities.ImageList32; // set icon list

            // Create the MissingFilesListView Columns (width of -2 indicates auto-size)
            MissingFilesListView.Columns.Clear();
            MissingFilesListView.Columns.Add("Name", 200, HorizontalAlignment.Left);
            MissingFilesListView.Columns.Add("Type", 100, HorizontalAlignment.Left);
            MissingFilesListView.Columns.Add("Expected Location", -2, HorizontalAlignment.Left);
        }

        /// <summary>
        /// Loads the Customers files into the Files and Image ListView components. 
        /// </summary>
        private void LoadCustomerFiles()
        {
            try
            {
                // get the client files and add to the customerFiles ArrayList
                customerFiles = FileDataAccess.GetCustomerFiles(customer);

                // clear previous list items (if any)
                AllFilesListView.Items.Clear();         // Files List View
                ImagesListView.Items.Clear();           // Images List View
                MissingFilesListView.Items.Clear();     // Missing Files List View

                // Loop through the Customer files and add to the list
                foreach (CustomerFile file in customerFiles)
                {
                    // If the file does not exist, add to the missing files list
                    if (!File.Exists(file.FileLocation))
                    {
                        missingFiles.Add(file); // add file to the list

                        /* ADD FILE TO MISSING FILES LIST VIEW */
                        ListViewItem missingItem = new ListViewItem(file.Name.ToString());  // add new listview item
                        missingItem.SubItems.Add(file.FileType.ToString());                 // add file type
                        missingItem.SubItems.Add(file.FileLocation.ToString());             // add expected file location
                        missingItem.Tag = file;                                             // file data associated with list view item
                        MissingFilesListView.Items.Add(missingItem);                        // add item to listview
                        continue;                                                           // move to next loop iteration
                    }

                    FileInfo fileInfo = new FileInfo(file.FileLocation);                    // get file properties

                    /* ADD TO CLIENT FILES LIST VIEW*/
                    ListViewItem fileItem = new ListViewItem(file.Name.ToString(), IconUtilities.GetFileIconIndex(fileInfo));
                    fileItem.SubItems.Add(file.FileType.ToString());        // add file type
                    fileItem.SubItems.Add(fileInfo.Name.ToString());        // add filename 
                    fileItem.SubItems.Add(file.FileLocation.ToString());    // add file location
                    fileItem.Tag = file;                                    // file data associated with list view item
                    AllFilesListView.Items.Add(fileItem);                   // add the file item to the files list view

                    /* ADD TO IMAGE LIST VIEW (IF IMAGE) */
                    if (FileUtilities.IsImageFile(fileInfo))
                    {
                        Image image = Image.FromFile(fileInfo.FullName);            // assign file to Image type 
                        customerImages.Images.Add(file.FileId.ToString(), image);   // add image to customer images array list

                        ListViewItem imageItem = new ListViewItem(fileInfo.Name, customerImages.Images.IndexOfKey(file.FileId.ToString()));
                        imageItem.Tag = file;                   // associate file data to image item
                        ImagesListView.Items.Add(imageItem);    // add the image item to the image list view
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Opens the selected image in the ImagesListView when a user double-clicks an image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImagesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                // check if a file is selected
                if(ImagesListView.SelectedItems.Count > 0)
                {
                    ListViewItem listItem = ImagesListView.SelectedItems[0]; // get selected item

                    // check that the listItem Tag has been provided
                    if (listItem.Tag == null) throw new Exception("Program Error: No Tag provided for ListViewItem");

                    // Check the ListViewItem Tag is a CustomerFile
                    if(listItem.Tag.GetType() == typeof(CustomerFile))
                    {
                        // assign listItem Tag to CustomerFile variable
                        CustomerFile customerFile = (CustomerFile)listItem.Tag;

                        // Check that the file is valid
                        if (!File.Exists(customerFile.FileLocation)) throw new Exception("File path does not exist, it may have changed locations");

                        // Attempt to open the file in a new Process
                        using (Process openFileProcess = new Process())
                        {
                            openFileProcess.StartInfo.FileName = "explorer";                    // application to start the process
                            openFileProcess.StartInfo.Arguments = customerFile.FileLocation;    // file to open
                            openFileProcess.Start();                                            // start the process
                        }
                    }
                    else
                    {
                        throw new Exception("Program Error: Tag provided for ListViewItem is not of CustomerFile type");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Opens the selected file in the AllFilesListView when a user double-clicks an image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllFilesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                // check if a file is selected
                if (AllFilesListView.SelectedItems.Count > 0)
                {
                    ListViewItem listItem = AllFilesListView.SelectedItems[0]; // get selected item

                    // check that the listItem Tag has been provided
                    if (listItem.Tag == null) 
                        throw new Exception("Program Error: No Tag provided for ListViewItem");

                    // Check the ListViewItem Tag is a CustomerFile
                    if (listItem.Tag.GetType() == typeof(CustomerFile))
                    {
                        // assign listItem Tag to CustomerFile variable
                        CustomerFile customerFile = (CustomerFile)listItem.Tag;

                        // Check that the file is valid
                        if (!File.Exists(customerFile.FileLocation)) 
                            throw new Exception("File path does not exist, it may have changed locations");

                        // Attempt to open the file in a new Process
                        using (Process openFileProcess = new Process())
                        {
                            openFileProcess.StartInfo.FileName = "explorer";                    // application to start the process
                            openFileProcess.StartInfo.Arguments = customerFile.FileLocation;    // file to open
                            openFileProcess.Start();                                            // start the process
                        }
                    }
                    else
                    {
                        throw new Exception("Program Error: Tag provided for ListViewItem is not of CustomerFile type");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Opens the AddFile form to allow the user to add a new file to the customer account. 
        /// The customer object is passed into the overloaded constructor to initialize the 
        /// form with the customer object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFileButton_Click(object sender, EventArgs e)
        {
            FileForms.AddFile addFile = new FileForms.AddFile(customer);// create a new add file form object
            FormUtilities.OpenFormInMdiOnce(addFile, this.ParentForm);  // open the add file form in the parent MDI form
        }

        /// <summary>
        /// Opens the FindFile form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindFileButton_Click(object sender, EventArgs e)
        {
            FileForms.FindFile findFile = new FileForms.FindFile();      // create a new add file form object
            FormUtilities.OpenFormInMdiOnce(findFile, this.ParentForm);  // open the add file form in the parent MDI form
        }

        /// <summary>
        /// Checks which File tab is currently open and opens the EditFile form for the 
        /// selected file. 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditFileButton_Click(object sender, EventArgs e)
        {
            // check what list is being viewed
            ListView currentList = new ListView();
            switch (CustomerTabs.SelectedIndex)
            {
                case 0: // All Files ListView
                    currentList = AllFilesListView;
                    break;
                case 1: // Images ListView
                    currentList = ImagesListView;
                    break;
                case 2: // Missing Files ListView
                    currentList = MissingFilesListView;
                    break;
            }

            // Check that an item was selected
            if(currentList.SelectedItems.Count > 0)
            {
                // assign list item tag to CustomerFile object
                CustomerFile customerFile = (CustomerFile)currentList.SelectedItems[0].Tag;

                FileForms.EditFile editFile = new FileForms.EditFile(customerFile); // open the form with the selected item
                FormUtilities.OpenFormInMdiOnce(editFile, this.MdiParent);          // open form in this MDI parent
            }

        }

        /// <summary>
        /// Opens a SaveFileDialog and generates a customer report at the location 
        /// specified by the user. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            // Get current date time formatted in yyyyMMddHHmmssff
            // * yyyy = 4 digit year e.g. 2022
            // * MM = 2 digit month e.g. 07
            // * dd = 2 digit day e.g 11
            // * HH = 2 digit hour using 24 hour clock e.g. 08=8am 20=8pm
            // * mm = 2 digit minute e.g 16 = 16 minutes past the hour
            // * ss = 2 digit seconds e.g. 56 = 56 seconds past the minute
            // * ff = 2 digit hundreths of a second e.g. 61 = 61/100 of a second
            string datetime = DateTime.Now.ToString("yyyyMMddHHmmssff");

            // Convert customer name to uppercase
            string name = customer.Name.ToUpper();

            SaveFileDialog saveReport = new SaveFileDialog();               // create new 
            saveReport.Filter = "Text files (*.txt)|*.txt";                 // Only save file as a .txt file
            saveReport.Title = $"Save Customer Report for {customer.Name}"; // Title of the Dialog
            saveReport.FileName = $"Report {name} {datetime}";              // Default Filename

            try
            {
                // only generate report if user clicks OK in dialog
                if (saveReport.ShowDialog() == DialogResult.OK)
                {
                    // Generate a customer report
                    CustomerReport.GenerateReport(customer, saveReport.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
