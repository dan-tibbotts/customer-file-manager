/***********************************************************************\
 *  
 *  File:       Main.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the Main MDI form container. 
 *  The purpose of this form is a container for child forms, and 
 *  to display a common menu navigation.
 *  
 \***********************************************************************/

using System;
using System.Windows.Forms;
using WinFormUI.Utilities;
using WinFormUI.FileForms;
using WinFormUI.CustomerForms;

namespace WinFormUI
{
    public partial class Main : Form
    {
        /// <summary>
        /// The default constructor that initializes the form components
        /// </summary>
        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When this form loads a Dashboard form is also shown using this as the MDI parent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();  // create new Dashboard object
            dashboard.MdiParent = this;             // set Main.cs as the parent MDI container
            dashboard.Show();                       // open the form
        }

        /// <summary>
        /// CLoses the form / program when the user clicks the Exit toolstrip menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // end the application
        }

        /// <summary>
        /// Opens the CreateCustomer form using this form as the MDI container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForms.CreateCustomer createCustomer = new CustomerForms.CreateCustomer();   // create a new createCustomerForm
            FormUtilities.OpenFormInMdiOnce(createCustomer, this);                              // open the form in this MDI container
        }

        /// <summary>
        /// Opens the Dashbaord form using this form as the MDI container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();              // create a new Dashboard object
            FormUtilities.OpenFormInMdiOnce(dashboard, this);   // open the Dashboard form in this MDI container
        }

        /// <summary>
        /// Opens the AddFile form using this form as the MDI container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFile addFile = new AddFile();                    // create a new AddFile form
            FormUtilities.OpenFormInMdiOnce(addFile, this);     // open the form in this MDI container
        }

        /// <summary>
        /// Opens the FindFile form using this form as the MDI container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindFile findFile = new FindFile();                 // create a new FindFile form
            FormUtilities.OpenFormInMdiOnce(findFile, this);    // open the form in this MDI container
        }

        /// <summary>
        /// Opens the ViewFileTypes form using this form as the MDI container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewFileTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewFileTypes viewFileTypes = new ViewFileTypes();      // creates a new ViewFileTypes object
            FormUtilities.OpenFormInMdiOnce(viewFileTypes, this);   // open the form
        }

        /// <summary>
        /// Opens the FindCustomer form using this form as the MDI container
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void findCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindCustomerModal findCustomer = new FindCustomerModal();   // create a new FindCustomerModal object
            FormUtilities.OpenFormInMdiOnce(findCustomer, this);        // open the form
        }
    }
}
