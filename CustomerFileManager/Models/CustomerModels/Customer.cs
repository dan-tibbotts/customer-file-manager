/***********************************************************************\
 *  
 *  File:       Customer.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for a Customer model. 
 *  The purpose of this class is to define the structure of a Customer object
 *  and contains methods relating to a Customer object. 
 *  
 *  This class implements the ICustomer interface
 *  
 \***********************************************************************/


using System;
using System.Text.RegularExpressions;

namespace CustomerFileManager.Models.CustomerModels
{
    public class Customer : ICustomer
    {
        // Structure/Model of a Customer object
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Validates the customer object and throws an exception if validation failed
        /// </summary>
        public void Validate()
        {
            ValidateName(); // validate Name property
            ValidatePhone(); // validate Phone property
            ValidateEmail(); // validate Email property
        }

        /// <summary>
        /// Creates a deep copy of this Customer object
        /// The new object will contain the same values as this object but be stored in a new location within memory
        /// </summary>
        /// <returns>A new Customer object with the copied values</returns>
        public Customer DeepCopy()
        {
            Customer customerCopy = new Customer();
            try
            {
                // Create a deep copy of the customer
                customerCopy.CustomerId = this.CustomerId;
                customerCopy.Name = this.Name;
                customerCopy.Phone = this.Phone;
                customerCopy.Email = this.Email;

            return customerCopy; // return the new Customer object
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Copies the values from the Customer parameter to this Customer object
        /// </summary>
        /// <param name="client">Customer object containing the new values</param>
        public void CopyValues(Customer customer)
        {
            // Copy the values of the client parameter to the current object
            this.CustomerId = customer.CustomerId;
            this.Name = customer.Name;
            this.Phone = customer.Phone;
            this.Email = customer.Email;
        }

        /// <summary>
        /// Validates the Customer.Name property.
        /// Names cannot be empty and must be between 2 and 50 characters in length
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void ValidateName()
        {
            // Name cannot be empty
            if (string.IsNullOrEmpty(Name)) 
                throw new Exception("Customer Name cannot be empty");

            // Name must be between 2 and 50 characters
            if (Name.Trim().Length < 2 || Name.Trim().Length > 50)
                throw new Exception("Customer Name must be between 2 and 50 characters in length");
        }

        /// <summary>
        /// Validates the Customer.Phone property.
        /// If provided, a phone number must be between 7 and 25 characters in length.
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void ValidatePhone()
        {
            // Phone must be between 7 and 25 characters if provided
            if (!string.IsNullOrEmpty(Phone.Trim()))
            {
                // check Phone is between 7 and 25 characters in length
                if (Phone.Trim().Length < 7 || Phone.Trim().Length > 25)
                    throw new Exception("Phone number must between 7 and 25 characters in length");
            }
        }

        /// <summary>
        /// Validates the Customer.Email property. 
        /// Email must be a valid format using [\w-\.]+@([\w-]+\.)+[\w-]{2,10} regular expression.
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void ValidateEmail()
        {
            // Email must be a valid format if provided
            if (!string.IsNullOrEmpty(Email.Trim()))
            {
                // defined new email regular expression
                Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,10}$");

                // check provided email mataches regular expression
                if (!regex.IsMatch(Email.Trim())) 
                    throw new Exception("Email must be a valid format.  Ex. user@domain.com");
            }
        }
    }
}
