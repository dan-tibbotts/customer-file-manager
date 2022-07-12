/***********************************************************************\
 *  
 *  File:       CustomerDataAccess.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the CustomerDataAccess object. 
 *  
 *  The purpose of this class is to contain methods related 
 *  to creating, updating, retrieving and deleting records in the 
 *  SQLite database for a Customer (Customers table). 
 *  
 *  This class uses Dapper ORM (Object-relational mapping) to map objects 
 *  to an SQLite database record.
 *  
 \***********************************************************************/


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

using CustomerFileManager.Models.CustomerModels;
using Dapper;

namespace CustomerFileManager.DataAccess
{
    public class CustomerDataAccess
    {
        // Create events
        public static event EventHandler CustomerSaved;     // invoked when a customer record is saved
        public static event EventHandler CustomerUpdated;   // invoked when a customer record is updated
        public static event EventHandler CustomerDeleted;   // invoked when a customer record is deleted

        /// <summary>
        /// Connects to the SQLite database to return all records in the Customers table
        /// </summary>
        /// <returns>Generic List of Customers containing all customer records in the database</returns>
        /// <exception cref="Exception"></exception>
        public static List<Customer> LoadCustomers()
        {
            // Open a new connection to the database
            using (IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
            {
                try
                {
                    // Perform SQL query with no parameters
                    var output = connection.Query<Customer>("SELECT * FROM Customers", new DynamicParameters());
                    return output.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Validates a customer object and saves a new record into the 
        /// SQLite database if the validation successful
        /// </summary>
        /// <param name="customer">The new customer object to be saved</param>
        /// <returns>The customer object with a newly generated Id</returns>
        /// <exception cref="Exception"></exception>
        public static Customer SaveCustomer(Customer customer)
        {
            customer.Validate(); // validate customer
            
            // Open a new connection to the database
            using (IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
            {
                try
                {
                    // Perform SQL Data Manipulation and return the last inserted rowID
                    int customerId = connection.ExecuteScalar<int>(
                        "INSERT INTO Customers (Name, Phone, Email) VALUES (@Name, @Phone, @Email);" +
                        "SELECT last_insert_rowid() AS int", customer);

                    customer.CustomerId = customerId; // add auto generated id to the customer object

                    // invoke the CustomerSaved event
                    CustomerSaved?.Invoke(customer, EventArgs.Empty);
                    return customer; // return the customer object
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Updates a Customer record in the SQLite database based on the Customer.CustomerId.
        /// The Customer.Validate() method is first called to validate the data and if successfull
        /// the customer will be updated .
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>The updated Customer object</returns>
        /// <exception cref="Exception"></exception>
        public static Customer UpdateCustomer(Customer customer)
        {
            customer.Validate(); // validate customer

            // Open a new connection to the database
            using (IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
            {
                try
                {
                    // Perform SQL Data Manipulation to update a customer where the Id matches the Customer.CustomerId
                    connection.Execute("UPDATE Customers SET Name=@Name, Phone=@Phone, Email=@Email WHERE CustomerId=@Id;", 
                        new 
                        { 
                            Name = customer.Name,
                            Phone = customer.Phone,
                            Email = customer.Email,
                            Id = customer.CustomerId,
                        });
                    
                    CustomerUpdated?.Invoke(customer, EventArgs.Empty); // invoke the CustomerSaved event
                    return customer; // return customer object
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Deletes a Customer record in the Customers table of the SQLite database 
        /// where the Customer.CustomerId matches the CustomerId in the Customer table.
        /// </summary>
        /// <param name="customer"></param>
        /// <exception cref="Exception"></exception>
        public static void DeleteCustomer(Customer customer)
        {
            // Open a new connection to the database
            using (IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
            {
                try
                {
                    // Perform SQL Data Manipulation to delete a customer
                    connection.Execute("DELETE FROM Customers WHERE CustomerId=@Id", new { Id = customer.CustomerId });
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            // invoke the CustomerSaved event
            CustomerDeleted?.Invoke(customer, EventArgs.Empty);
        }

    }
}
