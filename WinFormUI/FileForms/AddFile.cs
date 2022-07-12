/***********************************************************************\
 *  
 *  File:       AddFile.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the AddFile form. 
 *  The purpose of this form is to allow the user to add references
 *  to a file in the file system against a customer record.
 *  
 \***********************************************************************/


using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CustomerFileManager.DataAccess;
using CustomerFileManager.Models.FileModels;
using CustomerFileManager.Models.CustomerModels;

using WinFormUI.CustomerForms;

namespace WinFormUI.FileForms
{
    public partial class AddFile : Form
    {
        private List<FileType> fileTypes;                       // the list of file types
        private CustomerFile customerFile = new CustomerFile(); // the new customerFile
        private Customer customer = new Customer();             // the customer associated with the file
        
        /// <summary>
        /// Default constructor to initialize the form components and Load the 
        /// FileTypes data
        /// </summary>
        public AddFile()
        {
            InitializeComponent();
            try
            {
                LoadFileTypes(); // Load the FileTypes into the FileType ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Overloaded constructor that takes a Customer object.
        /// The customer is assigned to the private customer variable and name displayed in the customer text box
        /// </summary>
        /// <param name="customer"></param>
        public AddFile(Customer customer) : this()
        {
            this.customer = customer;               // assign customer parameter to customer object
            CustomerTextBox.Text = customer.Name;   // put customers name in the name text box
        }

        private void AddFile_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Clears the form to its original state by clearing the text fields, 
        /// reseting the customer object, and reloading the file types (in case
        /// a new filetype was added during the add file process)
        /// </summary>
        private void ResetForm()
        {
            FileTypeCombo.SelectedIndex = -1;         // clear current selection
            NameTextBox.Text = string.Empty;          // clear NameTextBox
            FileLocationTextBox.Text = string.Empty;  // clear FileLocationTextBox
            CustomerTextBox.Text = string.Empty;      // clear CustomerTextBox
            customer = new Customer();                // remove customer reference (no customer selected)                  
            LoadFileTypes();                          // re-load filetypes in case another file type was added during the add file process
        }

        /// <summary>
        /// Loads all FileTypes into the FileTypes ComboBox 
        /// </summary>
        private void LoadFileTypes()
        {
            try
            {
                fileTypes = FileDataAccess.LoadFileTypes(); // get FileType data

                // Loop through each FileType and add to the FileTypeComboBox
                foreach (FileType fileType in fileTypes)
                {
                    FileTypeCombo.Items.Add(fileType); // add FileTYpe to the ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        /// <summary>
        /// Closes this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close the current form
        }

        /// <summary>
        /// Attempts to Save a new CustomerFile to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                // assign values to a new CustomerFile object
                CustomerFile customerFile = new CustomerFile
                {
                    Name = NameTextBox.Text,
                    FileLocation = FileLocationTextBox.Text,
                    Customer = customer,
                    FileType = (FileType)FileTypeCombo.SelectedItem
                };
                
                FileDataAccess.SaveFile(customerFile);      // attempt to save the record
                MessageBox.Show("File Saved");              // alert the user the file was saved
                ResetForm();                                // clear the form data
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Opens an OpenFileDialog to select the desired File to add. 
        /// The chosen file is added to the the FileLocation TextBox and 
        /// customerFile.FileLocation property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileLocation_Click(object sender, EventArgs e)
        {
            // show the open file dialog to select the file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // user has selected a file and clicked OK
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // get the path of the selected file
                    string filePath = openFileDialog.FileName;

                    // if path is not null add 
                    if(filePath != null)
                    {
                        customerFile.FileLocation = filePath; // add value to CustomerFile.FileLocation
                        FileLocationTextBox.Text = filePath;  // add value to FileLocationTextBox
                    }
                }
            }
        }

        /// <summary>
        /// Opens the FindCustomerModal form as a Dialog to select a Customer 
        /// object to associate with the File.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindCustomerButton_Click(object sender, EventArgs e)
        {
            // Open a FindCustomerModal Dialog
            using (FindCustomerModal findCustomer = new FindCustomerModal())
            {
                // Check the user has selected a customer
                if(findCustomer.ShowDialog() == DialogResult.OK)
                {
                    this.customer = findCustomer.Customer;  // assign selected customer to the customer object
                    CustomerTextBox.Text = customer.Name;   // Update Customer TextBox to reflect selected customer
                }
            }
        }
    }
}
