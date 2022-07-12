/***********************************************************************\
 *  
 *  File:       ViewFileTypes.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the ViewFileTypes form.  
 *  The purpose of this form is to allow users to View and Add FileTypes 
 *  to the database. 
 *  
 \***********************************************************************/


using System;
using System.Windows.Forms;

using CustomerFileManager.DataAccess;
using CustomerFileManager.Models.FileModels;

namespace WinFormUI.FileForms
{
    public partial class ViewFileTypes : Form
    {
        /// <summary>
        /// Default constructor that initializes the components, subscribes 
        /// to the FileDataAccess.FileTypeSaved event to update the FileType 
        /// ListBox.
        /// </summary>
        public ViewFileTypes()
        {
            InitializeComponent();

            FileDataAccess.FileTypeSaved += RefreshFileTypeList; // subscribe to events
            LoadFileTypeList(); // load the FileType list box items
        }

        /// <summary>
        /// Event handler that for the FileDataAccess.FileTypeSaved event. 
        /// When the event is invoked, the FileTypeListBox items are repopulated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshFileTypeList(object sender, EventArgs e)
        {
            LoadFileTypeList(); // repopulate FileType listbox items
        }

        /// <summary>
        /// Loads the FileTypes into the FileTypeListBox from the database
        /// </summary>
        private void LoadFileTypeList()
        {
            try
            {
                FileTypesListBox.Items.Clear(); // clear the the previous ListBox items

                // Loop through each FileType from the FileTypes list 
                foreach (FileType fileType in FileDataAccess.LoadFileTypes())
                {
                    FileTypesListBox.Items.Add(fileType); // add the filetype to the database
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Close the ViewFileTypes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close this form
        }

        /// <summary>
        /// Saves a FileType to the database using the type specified in 
        /// the FileTypeTextBox.text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFileTypeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // attempt to Save the FileType
                FileDataAccess.SaveFileType(new FileType { Type = FileTypeTextBox.Text });
                MessageBox.Show("New File Type Added!");    // show message box altering save success
                FileTypeTextBox.Text = String.Empty;        // reset the FileTypeTextBox
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewFileTypes_Load(object sender, EventArgs e)
        {

        }
    }
}
