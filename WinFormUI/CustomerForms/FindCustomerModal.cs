/***********************************************************************\
 *  
 *  File:       FindCustomerModal.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the FindCustomerModal form. 
 *  This form can be used as both a Dialog and standalone form. 
 *  The purpose of this form is to seach for a customer record. 
 *  
 *  Modal Form
 *  If the form is used as a Dialog the customer object stored in the Public 
 *  Customer Property should be retrieved.  Double-clicking or selecting OK
 *  on a customer in the Customer list will close the dialog. 
 *  
 *  Standalone Form
 *  If the form is a standalone form double-clicking or selecting OK on a customer 
 *  in the Customer list will open the ViewCustomer form for the selected Customer
 *  
 \***********************************************************************/



using System;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

using CustomerFileManager.DataAccess;
using CustomerFileManager.Models.CustomerModels;

namespace WinFormUI.CustomerForms
{
    public partial class FindCustomerModal : Form
    {
        private List<Customer> customers;  // holds a list of Customers objects

        /// <summary>
        /// Holds the selected Customer object.  This property is Public to allow
        /// the selected object to be used when the form is being used as a Dialog box.
        /// </summary>
        public Customer Customer { get; set; } = new Customer();
        
        /// <summary>
        /// The default constructor that initializes the form components, and 
        /// sets the list of customers
        /// </summary>
        public FindCustomerModal()
        {
            InitializeComponent();

            try
            {
                customers = CustomerDataAccess.LoadCustomers(); // load the customers list
                InitalizeCustomersList();                       // setup the CustomersList ListView
                LoadCustomersList();                            // populate CustomersList ListView with data
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        /// <summary>
        /// Initializes the CustomersList ListView component properties and columns
        /// </summary>
        private void InitalizeCustomersList()
        {
            // define CustomersList ListView properties
            CustomersList.Columns.Clear();
            CustomersList.View = View.Details;
            CustomersList.AllowColumnReorder = true;
            CustomersList.MultiSelect = false;
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
        /// Loads the list of customers into the Customers List ListView component
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
        /// Close the FindCustomerModal form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();   // close this form
        }

        /// <summary>
        /// If this form is used as a standalone form, the ViewCustomer 
        /// form is shown passing in the selected Customer.  Then this form 
        /// is closed.  
        /// 
        /// If this form is used as a Dialog form, this method will call the 
        /// DialogResult.OK. As setup in the form properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            // Make sure form is not being used as a Dialog
            if(!this.Modal)
            {
                // confirm an item has been selected
                if (CustomersList.SelectedItems.Count > 0)
                {
                    try 
                    { 
                        // assign Selected item as Customer object
                        Customer customer = (Customer)CustomersList.SelectedItems[0].Tag;

                        ViewCustomer viewCustomer = new ViewCustomer(customer); // create new ViewCustomer object
                        viewCustomer.MdiParent = this.MdiParent;                // open form in this MDI parent
                        viewCustomer.Show();                                    // open the form
                    } 
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                this.Close(); // close the form
            }
        }

        /// <summary>
        /// Updates the CustomersList ListView with filtered results using the 
        /// CustomerSerachTextBox text.  If the customer Name, Phone, or Email 
        /// contains the search term that customer is returned in the results. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ArrayList filteredCustomers = new ArrayList(); // create new ArrayList for storing results

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
        /// Clears the text in the CustomerSearchTextBox and assigns the Customer 
        /// property to a new Customer object.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCustomerSearchButton_Click(object sender, EventArgs e)
        {
            CustomerSearchTextBox.Text = string.Empty;  // clear the search text
            Customer = new Customer();                  // assign new Customer object
        }

        /// <summary>
        /// Assign the selected Customer to the Public Customer property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check that a selection has been made
            if(CustomersList.SelectedItems.Count > 0)
            {
                try
                {
                    // assign the selected customer to the Public Customer property
                    this.Customer = (Customer)CustomersList.SelectedItems[0].Tag;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        /// <summary>
        /// Gets the selected customer in the CustomersList
        /// If form is used as a Dialog, the customer dialog result is set to ok and customer returned
        /// If from is standalone then the selected customer is opened
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersList_DoubleClick(object sender, EventArgs e)
        {
            if (CustomersList.SelectedItems.Count > 0) // make sure an item has been selected
            {
                // assign selected customer to customer variable
                Customer customer = (Customer)CustomersList.SelectedItems[0].Tag;

                if (this.Modal) // if not used as a modal open the form
                {
                    this.DialogResult = DialogResult.OK;    // Return OK Dialog response
                }
                else // if used as a modal form return the selected customer 
                {
                    ViewCustomer viewCustomer = new ViewCustomer(customer); // create new form object
                    viewCustomer.MdiParent = this.MdiParent;                // set new form object to load in parent MDI form
                    viewCustomer.Show();                                    // show the new form
                }
            }
            this.Close(); // close the modal form
        }

        private void FindCustomerModal_Load(object sender, EventArgs e)
        {

        }
    }
}
