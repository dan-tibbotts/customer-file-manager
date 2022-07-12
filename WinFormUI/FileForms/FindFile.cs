/***********************************************************************\
 *  
 *  File:       FindFile.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the FindFile form. 
 *  The purpose of this form is to provide the user an easy way to 
 *  find a file by filtering file types and using a search string to 
 *  limit the search results
 *  
 \***********************************************************************/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using CustomerFileManager.DataAccess;
using CustomerFileManager.Models.FileModels;

namespace WinFormUI.FileForms
{
    public partial class FindFile : Form
    {
        private List<CustomerFile> customerFiles = new List<CustomerFile>();    // holds a list of CustomerFiles
        private ArrayList searchResults = new ArrayList();                      // holds a list of the search results

        /// <summary>
        /// Default constructor for initializing the FindFile object and form components.
        /// Loads the CustomerFiles and sets all FileTypes to be displayed (checked) 
        /// </summary>
        public FindFile()
        {
            InitializeComponent();
            try
            {
                // populate customerFiles list with data
                customerFiles = FileDataAccess.GetAllCustomerFiles();

                LoadFileTypes();            // load file types Checked ListBox
                CheckAllFileTypeBoxes();    // Check All boxes on the file type list
                FilterCustomerFiles();      // apply filters
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FindFile_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method filters the CustomerFiles by the selected FileTypes and 
        /// the search string in the FileFileTextBox.  The search checks 
        /// to see if the CustomerFile Name and Customer Name contains the text 
        /// in the search string and is not case sensitive. 
        /// the text 
        /// </summary>
        private void FilterCustomerFiles()
        {
            FileSearchResultsListBox.Items.Clear(); // clear previous list items
            searchResults.Clear();                  // clear previous search results array list

            // get checked filetypes 
            string[] fileTypes = new string[FileTypeListBox.CheckedItems.Count];
            
            // add selected FileTypes to fileTypes array
            int i = 0;
            foreach(FileType fileTypeItem in FileTypeListBox.CheckedItems)
            {
                fileTypes[i] = fileTypeItem.Type; // add FileType.Type to string array
                i++;
            }

            string searchString = FindFileTextBox.Text.Trim().ToLower(); // trim search text and convert to lower case

            // Loop through the customerFiles list and compare against search filters
            foreach(CustomerFile customerFile in customerFiles)
            {
                // Loop through each file type
                // compare customerFile.FileType.Type against the fileTypes array
                foreach(string fileType in fileTypes)
                {
                    // Check if the current customerFile.FileType matches the current fileType
                    // and also contains 
                    if (customerFile.FileType.Type.ToLower() == fileType.ToLower() &&
                        (customerFile.Name.ToLower().Contains(searchString) ||
                        customerFile.Customer.Name.ToLower().Contains(searchString)))
                    {
                        searchResults.Add(customerFile); // add customerFile to searchResults Array List
                    }
                }
            }

            // Loop through each CustomerFile in the searchResult and add to 
            // the FileSearchResults ListBox
            foreach (CustomerFile result in searchResults)
            {
                FileSearchResultsListBox.Items.Add(result);
            }
        }

        /// <summary>
        /// Load the FileTypes into the FileType Checked ListBox
        /// </summary>
        private void LoadFileTypes()
        {
            try
            {
                FileTypeListBox.Items.Clear();  // clear previous ListBox items
                foreach(FileType fileType in FileDataAccess.LoadFileTypes())
                {
                    FileTypeListBox.Items.Add(fileType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Clears all filters and resets the form to it's initial state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearFiltersButton_Click(object sender, EventArgs e)
        {
            FindFileTextBox.Text = string.Empty;    // clear the search text
            CheckAllFileTypeBoxes();                // check all boxes to include everything in the search
            FilterCustomerFiles();                  // reapply filter
        }

        /// <summary>
        /// Loops through each FileTypeListBox item and checks all boxes
        /// </summary>
        private void CheckAllFileTypeBoxes()
        {
            for (int i = 0; i < FileTypeListBox.Items.Count; i++)
                FileTypeListBox.SetItemCheckState(i, CheckState.Checked);
        }

        /// <summary>
        /// Calls the search filter whenever a user changes the search text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindFileTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterCustomerFiles();
        }

        /// <summary>
        /// Calls the FilterCustomerFiles() method whenever the user checks/unchecks 
        /// a FileTypeListBox item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileTypeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCustomerFiles();
        }

        /// <summary>
        /// Opens the selected CustomerFile by starting an explorer process with the 
        /// CustomerFile.FileLocation property.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSearchResultsListBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // Cast Selected index to CustomerFile object
                CustomerFile customerFile = (CustomerFile)FileSearchResultsListBox.Items[FileSearchResultsListBox.SelectedIndex];

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FileSearchPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
