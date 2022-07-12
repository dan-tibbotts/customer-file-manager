/***********************************************************************\
 *  
 *  File:       CreateCustomer.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the CreateCustomer form. 
 *  This form allows the user to create a new customer. 
 *  
 \***********************************************************************/


using System;
using System.Windows.Forms;

using CustomerFileManager.DataAccess;
using CustomerFileManager.Models.CustomerModels;

namespace WinFormUI.CustomerForms
{
    public partial class CreateCustomer : Form
    {
        /// <summary>
        /// Default constructor to initialize the form components
        /// </summary>
        public CreateCustomer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); // close the current form
        }

        /// <summary>
        /// Creates a new Customer object using the values provided in the 
        /// text fields and attempts to Save the customer object into the 
        /// database.  If the save is successful, the form will close and 
        /// open the ViewCustomer form for the newly created Customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // create a new customer object with the user input
                Customer customer = new Customer
                {
                    Name = NameTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    Email = EmailTextBox.Text
                };

                // attempt to save Customer object
                customer = CustomerDataAccess.SaveCustomer(customer);

                // open the view customer form for the newly added customer 
                ViewCustomer viewCustomer = new ViewCustomer(customer);
                viewCustomer.MdiParent = this.MdiParent; // open form in same MDI parent
                viewCustomer.Show(); // open the form

                this.Close(); // close this form
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
