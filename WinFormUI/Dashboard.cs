/***********************************************************************\
 *  
 *  File:       Dashboard.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the Dashboard form. 
 *  This form is automatically loaded as a child form of the Main.cs MDI parent
 *  This form displays a customer and file list as well as common actions
 *  such as Add and Find for both the customer and files sub-system.
 *  
 \***********************************************************************/



using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

using CustomerFileManager.DataAccess;
using CustomerFileManager.Models.CustomerModels;
using CustomerFileManager.Models.FileModels;

using WinFormUI.CustomerForms;
using WinFormUI.FileForms;
using WinFormUI.Utilities;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        private List<Customer> customers;       // holds a list of Customer objects
        readonly Timer timer = new Timer();     // timer for the dashbaord clock

        /// <summary>
        /// Default constructor to initialize form components, subscribe to events, 
        /// and load form data
        /// </summary>
        public Dashboard()
        {
            InitializeComponent();

            // listen for CustomerDataAccess events
            CustomerDataAccess.CustomerSaved += CustomerDataAccess_CustomerEvent;
            CustomerDataAccess.CustomerUpdated += CustomerDataAccess_CustomerEvent;
            CustomerDataAccess.CustomerDeleted += CustomerDataAccess_CustomerEvent;

            // listen for FileDataAccess events
            FileDataAccess.FileSaved += FileDataAccess_FileEvent;
            FileDataAccess.FileUpdated += FileDataAccess_FileEvent;
            FileDataAccess.FileDeleted += FileDataAccess_FileEvent;

            // start the dashboard clock timer
            timer.Tick += UpdateDashboardClock;             // event to run on timer tick
            timer.Interval = 1000;                          // timer interval
            timer.Enabled = true;                           // start the timer

            try
            {
                customers = CustomerDataAccess.LoadCustomers(); // load the customers list

                InitalizeCustomersList();        // setup the CustomersList ListView
                LoadCustomersList();             // populate CustomersList ListView with data
                LoadFilesList();                 // populate Files ListBox with data
                UpdateStats();                   // Update Customer and Files statistics
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                                            
        }

        /// <summary>
        /// Finalizer (historically Destructor) to dispose of the 
        /// timer when the class instance is collected by the garbage collector
        /// </summary>
        ~Dashboard()
        {
            timer.Dispose();                                // remove timer resources
        }

        /// <summary>
        /// Event handler for FileDataAccess events. 
        /// Updates the FileListBox and Customer/File statistics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileDataAccess_FileEvent(object sender, EventArgs e)
        {
            LoadFilesList();                                // update the FilesListBox
            UpdateStats();                                  // update the Customer and Files statistics
        }
        
        /// <summary>
        /// Event handler for CustomerDataAccess events.
        /// Updates and reloads the customer list as well as the statistics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerDataAccess_CustomerEvent(object sender, EventArgs e)
        {
            customers = CustomerDataAccess.LoadCustomers(); // update the customers list
            LoadCustomersList();                            // reload the CustomersList
            UpdateStats();                                  // Update Customer and Files statistics
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Updates the Customer and Files statistics.
        /// Updates the values of the TotalCustomersValue and TotalFilesValue labels
        /// </summary>
        private void UpdateStats()
        {
            TotalCustomersValue.Text = CustomerDataAccess.LoadCustomers().Count.ToString();
            TotalFilesValue.Text = FileDataAccess.GetAllCustomerFiles().Count.ToString();
        }
        /// <summary>
        /// Event Handler for Timer.Tick event. 
        /// Updates the TimeLabel text to the current time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDashboardClock(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt"); // set TimeLabel to current time
        }

        /// <summary>
        /// Initializes the CustomerListView properties and columns
        /// </summary>
        private void InitalizeCustomersList()
        {
            // define CustomersList ListView properties
            CustomersList.Columns.Clear();
            CustomersList.View = View.Details;
            CustomersList.AllowColumnReorder = true;
            CustomersList.FullRowSelect = true;
            CustomersList.GridLines = true;
            CustomersList.Sorting = SortOrder.Ascending;

            // define the CustomersList ListView columns
            // width of -2 indicates auto-size
            CustomersList.Columns.Add("Customer Name", -2);
            CustomersList.Columns.Add("Phone", 100);
            CustomersList.Columns.Add("Email", 150);
        }

        /// <summary>
        /// Loads the Customer data into the CustomersListView
        /// </summary>
        private void LoadCustomersList()
        {
            CustomersList.Items.Clear(); // clear the current list items

            // loop through each customer record and add to the CustomersList
            foreach (Customer customer in customers)
            {
                ListViewItem item = new ListViewItem(customer.Name);
                item.SubItems.Add(customer.Phone);
                item.SubItems.Add(customer.Email);
                item.Tag = customer; // associate the Customer object with the ListViewItem

                // add the customer item to the CustomersList
                CustomersList.Items.Add(item);
            }
        }

        /// <summary>
        /// Loads all the CustomerFiles into the FilesListBox
        /// </summary>
        private void LoadFilesList()
        {
            FilesListBox.Items.Clear();                 // Empty the ListBox

            // Loop through each item in the CustomerFiles table
            foreach(CustomerFile customerFile in FileDataAccess.GetAllCustomerFiles())
            {
                FilesListBox.Items.Add(customerFile);   // Add the item to the FilesListBox
            }
        }

        /// <summary>
        /// Performs a filter on the Customers using the search string
        /// of the CustomerSearchTextBox and populates the results 
        /// into the CustomersListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ArrayList filteredCustomers = new ArrayList();

            CustomersList.Items.Clear(); // clear the current list items

            // add the customer to the filteredCustomers ArrayList if
            // customer contains search term in name, phone, or email field
            foreach (Customer customer in customers)
            {
                // get the search term, remove spaces and convert to lowercase
                string searchTerm = CustomerSearchTextBox.Text.Trim().ToLower();

                // check if name, phone, or email contains search term
                if (customer.Name.ToLower().Contains(searchTerm) ||
                    customer.Phone.ToLower().Contains(searchTerm) ||
                    customer.Email.ToLower().Contains(searchTerm))
                {
                    filteredCustomers.Add(customer); // match found, add to filtered customers list
                }
            }

            // loop through each filteredCustomer and add to the CustomersList
            foreach (Customer customer in filteredCustomers)
            {
                ListViewItem item = new ListViewItem(customer.Name);
                item.SubItems.Add(customer.Phone);
                item.SubItems.Add(customer.Email);
                item.Tag = customer; // associate the Customer object with the ListViewItem

                // add the customer item to the CustomersList
                CustomersList.Items.Add(item);
            }

        }

        /// <summary>
        /// Clears the text in the CustomerSearchTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCustomerSearchButton_Click(object sender, EventArgs e)
        {
            CustomerSearchTextBox.Text = string.Empty; // clear the search text
        }

        /// <summary>
        /// Opens the ViewCustomer form using the selected customer in the 
        /// CustomerListView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersList_DoubleClick(object sender, EventArgs e)
        {
            // check to make sure an item has been selected
            if(CustomersList.SelectedItems.Count > 0)
            {
                try
                {
                    // assign customer to selected item
                    Customer customer = (Customer)CustomersList.SelectedItems[0].Tag;

                    // create a new instance of the view customer form 
                    // use the selected customer as the argument
                    ViewCustomer viewCustomer = new ViewCustomer(customer);
                    viewCustomer.MdiParent = this.MdiParent; // open form in same MDI parent
                    viewCustomer.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Opens the Create Customer Form in this.MdiParent if not open
        /// If form already open, the form is brought to the front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateCustomerButton_Click(object sender, EventArgs e)
        {
            CreateCustomer createCustomer = new CreateCustomer();               // create new form object
            FormUtilities.OpenFormInMdiOnce(createCustomer, this.MdiParent);    // Open form in this.MdiParent
            
        }

        /// <summary>
        /// Opens the Find Customer Form in this.MdiParent if not open
        /// If form already open, the form is brought to the front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindCustomerButton_Click(object sender, EventArgs e)
        {
            FindCustomerModal findCustomer = new FindCustomerModal();           // create new form object
            FormUtilities.OpenFormInMdiOnce(findCustomer, this.MdiParent);      // Open form in this.MdiParent
        }

        /// <summary>
        /// Opens the Add File Form in this.MdiParent if not open
        /// If form already open, the form is brought to the front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFileButton_Click(object sender, EventArgs e)
        {
            AddFile addFile = new AddFile();                               // create new form object
            FormUtilities.OpenFormInMdiOnce(addFile, this.MdiParent);      // Open form in this.MdiParent
        }

        /// <summary>
        /// Opens the Find File Form in this.MdiParent if not open
        /// If form already open, the form is brought to the front.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindFileButton_Click(object sender, EventArgs e)
        {
            FindFile findFile = new FindFile();                            // create new form object
            FormUtilities.OpenFormInMdiOnce(findFile, this.MdiParent);     // Open form in this.MdiParent
        }

        /// <summary>
        /// Gets the selected item from the FilesListBox, converts it to a CustomerFile
        /// and opens the EditFile form with the selected CustomerFile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilesListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                // assign CustomerFile to selected item in FilesListBix
                CustomerFile customerFile = FilesListBox.SelectedItem as CustomerFile;

                // Check to ensure customer is not null and a selection is made
                if (customerFile != null && FilesListBox.SelectedItems.Count > 0)
                {
                    EditFile editFile = new EditFile(customerFile);            // create new form object
                    FormUtilities.OpenFormInMdiOnce(editFile, this.MdiParent); // Open form in this.MdiParent
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
