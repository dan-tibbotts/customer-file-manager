/***********************************************************************\
 *  
 *  File:       EditFile.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the EditFile form. 
 *  The purpose of this form is to edit the CustomerFile properties
 *  and update the database.  This form also allows the user to open the
 *  file using an explorer process.
 *  
 \***********************************************************************/


using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using WinFormUI.CustomerForms;
using CustomerFileManager.Models.FileModels;
using CustomerFileManager.DataAccess;


namespace WinFormUI.FileForms
{
    public partial class EditFile : Form
    {
        private CustomerFile customerFile = new CustomerFile(); // holds the customerFile object
        private List<FileType> fileTypes;                       // holds a list of FileTypes

        /// <summary>
        /// Default constructor that initializes the form components
        /// Constructor has a Private access modifier to restrict 
        /// creating the form without overloads
        /// </summary>
        private EditFile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded contstructor that takes a CustomerFile object to 
        /// initialize the form text fields.  Also loads the FileTypes.
        /// </summary>
        /// <param name="customerFile"></param>
        public EditFile(CustomerFile customerFile) : this()
        {
            // Populate the fields with the customer File data
            this.customerFile = customerFile;   // assign the customer to the customer file
            LoadFileTypes();                    // load FileTypes into FileType combobox
            PopulateTextFields();               // populate the text fields with CustomerFile values
        }

        /// <summary>
        /// Loads the FileTypes into the FileType combo box
        /// </summary>
        private void LoadFileTypes()
        {
            try
            {
                // load FileTypes from Database
                fileTypes = FileDataAccess.LoadFileTypes();

                // Loop through each FileType and add to the ComboBox
                foreach (FileType fileType in fileTypes)
                {
                    FileTypeCombo.Items.Add(fileType); // add FileType to ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Populates the text fields with the customer file data
        /// </summary>
        private void PopulateTextFields()
        {
            // populate the file type combo box with the correct file type

            //FileTypeCombo.SelectedItem = customerFile.FileType;
            FileTypeCombo.SelectedIndex = FileTypeCombo.FindString(customerFile.FileType.Type);

            NameTextBox.Text = customerFile.Name;   // set the value for the user defined file name

            // If file does not exist, change file location text color to red
            // If file does exist, file location text color is black
            if (File.Exists(customerFile.FileLocation))
            {
                // file location valid, text color should be black
                FileLocationTextBox.ForeColor = Color.Black;
                FileLocationLabel.ForeColor = Color.Black;
            }
            else
            {
                // file location NOT valid, text color should be red
                FileLocationTextBox.ForeColor = Color.Red;
                FileLocationLabel.ForeColor = Color.Red;
            }

            FileLocationTextBox.Text = customerFile.FileLocation;   // set the value for the file location
            CustomerTextBox.Text = customerFile.Customer.Name;      // set the value for the customer name
        }

        /// <summary>
        /// Opens the FindCustomerModal form as a Dialog and populates the 
        /// fileCustomer.Customer property to customerFile.Customer property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindCustomerButton_Click(object sender, EventArgs e)
        {
            using (FindCustomerModal findCustomer = new FindCustomerModal())
            {
                // Open findCustomer form as a Dialog
                // If the user clicks 'ok' load selected customer into Customer property
                if (findCustomer.ShowDialog() == DialogResult.OK)
                {
                    // Load selected Customer in dialog into the CustomerFile.Customer property
                    this.customerFile.Customer = findCustomer.Customer;
                    CustomerTextBox.Text = customerFile.Customer.Name;
                }
            }
        }

        /// <summary>
        /// Closes the EditFile Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the form
        }

        /// <summary>
        /// Saves the Updated CustomerFile object and saves the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // assign text fields to customerFile object
                customerFile.Name = NameTextBox.Text;
                customerFile.FileLocation = FileLocationTextBox.Text;
                customerFile.FileType = (FileType)FileTypeCombo.SelectedItem;

                FileDataAccess.UpdateCustomerFile(customerFile);    // attempt to update the customerFile
                MessageBox.Show("File Updated");                    // alert the user the file was updated
                this.Close();                                       // close the form

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Opens a File Dialog to select the desired file and assigns the
        /// file path to the customerFile.Location and textbox text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileLocation_Click(object sender, EventArgs e)
        {
            // show the open file dialog to select the file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // user has selected a file and clicked OK
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // get the path of the selected file
                    string filePath = openFileDialog.FileName;

                    // if path is not null add 
                    if (filePath != null)
                    {
                        customerFile.FileLocation = filePath; // add value to CustomerFile.FileLocation
                        FileLocationTextBox.Text = filePath; // add value to FileLocationTextBox
                    }
                }
            }
        }

        /// <summary>
        /// Prompts the user with a confirmation dialog to confirm delete. 
        /// If the user selects 'yes' the CustomerFile is deleted from the 
        /// database, thereby removing the association to the Customer
        /// If the user selects 'no' then no further action is taken
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Confirm that the user actually wants to delete this record
            DialogResult deleteConfirmation = MessageBox.Show(
                $"Are you sure you want to remove this customer file?\n" +
                $"This action will not delete the file from the file system, but only remove the reference to the customer!\n\n",
                "Remove Customer File?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // if user selects 'Yes' then delete the CustomerFile object
            if (deleteConfirmation == DialogResult.Yes)
            {
                try // Delete the Customer
                {
                    FileDataAccess.DeleteCustomerFile(customerFile);                // Attempt to delete the CustomerFile
                    MessageBox.Show($"Customer file successfully removed!");        // show delete confirmation
                    this.Close();                                                   // close the form
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); // display exception message
                }
            }
        }

        /// <summary>
        /// Starts a new explorer process to open the file at the FileLocation 
        /// specificed in the CustomerFile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            // Check that an item was selected
            if (File.Exists(customerFile.FileLocation))
            {
                // Attempt to open the file in a new Process
                using (Process openFileProcess = new Process())
                {
                    openFileProcess.StartInfo.FileName = "explorer";                    // application to start the process
                    openFileProcess.StartInfo.Arguments = customerFile.FileLocation;    // file to open
                    openFileProcess.Start();                                            // start the process
                }

            } else
            {
                MessageBox.Show("The file does not exist at the specified location");
            }
        }

        private void EditFile_Load(object sender, EventArgs e)
        {

        }
    }
}
