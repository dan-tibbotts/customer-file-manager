/***********************************************************************\
 *  
 *  File:       FileDataAccess.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the FileDataAccess object. 
 *  
 *  The purpose of this class is to contain methods related 
 *  to creating, updating, retrieving and deleting records in the 
 *  SQLite database for a CustomerFile (CustomerFiles table). 
 *  
 *  This class uses Dapper ORM (Object-relational mapping) to map objects 
 *  to an SQLite database record.
 *  
 \***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SQLite;
using Dapper;

using CustomerFileManager.Models.FileModels;
using CustomerFileManager.Models.CustomerModels;


namespace CustomerFileManager.DataAccess
{
    public class FileDataAccess
    {
        // Create events for CustomerFiles database actions
        public static event EventHandler FileSaved;     // invoked when a new CustomerFile is saved
        public static event EventHandler FileUpdated;   // invoked when a CustomerFile is updated
        public static event EventHandler FileDeleted;   // invoked when a CustomerFile is deleted

        // Create events for the FileTypes database actions
        public static event EventHandler FileTypeSaved; // invoked when a FileType is Saved

        /// <summary>
        /// Saves the specified File to the Database depending on the object type. 
        /// </summary>
        /// <param name="file"></param>
        /// <returns>The saved IFile object</returns>
        public static IFile SaveFile(IFile file)
        {
            file.Validate(); // validate the file

            Type objType = file.GetType(); // get the object type

            // check to see if object is a CustomerFile
            if (objType == typeof(CustomerFile))
            {
                try
                {
                    CustomerFile customerFile = (CustomerFile)file; // cast IFile to CustomerFile object
                    SaveCustomerFile(customerFile);                 // attempt to save the CustomerFile object
                    return customerFile;                            // return the saved CustomerFile
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            FileSaved?.Invoke(file, EventArgs.Empty);               // invoke the FileSaved event
            return file;
        }

        /// <summary>
        /// Validates the FileType and saves it to the FileTypes table in the SQLite database
        /// </summary>
        /// <param name="fileType"></param>
        /// <returns>The Saved FileType object</returns>
        /// <exception cref="Exception"></exception>
        public static FileType SaveFileType(FileType fileType)
        {
            fileType.Validate();

            try
            {
                // open a new connection to the database
                using (IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
                {
                    // perform SQL data manipulation on the FileTypes table and return last inserted rowID
                    int fileTypeId = connection.ExecuteScalar<int>(
                        "INSERT INTO FileTypes (Type) VALUES (@Type);" +
                        "SELECT last_insert_rowid() AS int",
                        new { Type = fileType.Type });

                    fileType.FileTypeId = fileTypeId; // add auto generated is to the customer object

                    FileTypeSaved?.Invoke(fileType, EventArgs.Empty); // invoke the FileTypeSaved event
                    return fileType;
                }  
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Gets all the FileTypes from the FileTypes table in the SQLite database
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<FileType> LoadFileTypes()
        {
            // Open a new connection to the database
            using (IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
            {
                try
                {
                    // Perform SQL query with no parameters
                    var output = connection.Query<FileType>("SELECT * FROM FileTypes", new DynamicParameters());
                    return output.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Connects to the SQLite database 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>A list (List<T>) of CustomerFiles for the selected customer </returns>
        /// <exception cref="Exception"></exception>
        public static List<CustomerFile> GetAllCustomerFiles()
        {
            try
            {
                // open a new connection to the database
                using (IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
                {
                    // Create the SQL to retrieve the CustomerFiles for the specified Customer
                    var sql = @"SELECT f.FileId, f.Name, f.FileLocation, t.*, c.*
                                FROM CustomerFiles f
                                INNER JOIN FileTypes t ON FileType = t.FileTypeId
                                INNER JOIN Customers c ON Customer = c.CustomerId";

                    // Execute SQL query to get the files for the provided Customer using mapping array
                    var customerFiles = connection.Query<CustomerFile, FileType, Customer, CustomerFile>(sql,
                        (customerFile, fileType, cust) => {     // assign variables to specified Models above
                            customerFile.FileType = fileType;   // assign FileType property to FileType Model
                            customerFile.Customer = cust;       // assign Customer property to Customer Model

                            return customerFile; // return CustomerFile record
                        }, splitOn: "FileTypeId, CustomerId"); // set split points for dapper multi-mapping

                    return customerFiles.ToList(); // return the output as a List<T>
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Connects to an SQLite database and attempts to retrieve all CustomerFiles for a specified Customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>A list (List<T>) of CustomerFiles for the selected customer </returns>
        /// <exception cref="Exception"></exception>
        public static List<CustomerFile> GetCustomerFiles(Customer customer)
        {
            try
            {
                // open a new connection to the database
                using (IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
                {
                    // Anonymous object with an Id property to be used in the Query
                    var id = new { Id = customer.CustomerId };

                    // Create the SQL to retrieve the CustomerFiles for the specified Customer
                    var sql = @"SELECT f.FileId, f.Name, f.FileLocation, t.*, c.*
                                FROM CustomerFiles f
                                INNER JOIN FileTypes t ON FileType = t.FileTypeId
                                INNER JOIN Customers c ON Customer = c.CustomerId
                                WHERE Customer = @id;";

                    // Execute SQL query to get the files for the provided Customer using mapping array
                    var customerFiles = connection.Query<CustomerFile, FileType, Customer, CustomerFile>(sql,
                        (customerFile, fileType, cust) => {     // assign variables to specified Models above
                            customerFile.FileType = fileType;   // assign FileType property to FileType Model
                            customerFile.Customer = cust;       // assign Customer property to Customer Model

                            return customerFile; // return CustomerFile record
                        }, id, splitOn: "FileTypeId, CustomerId"); // set split points for dapper multi-mapping
                
                    return customerFiles.ToList(); // return the output as a List<T>
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// Attempts to save a new CustomerFile record to the database
        /// </summary>
        /// <param name="customerFile">The CustomerFile object to be saved</param>
        /// <returns>The CustomerFile object with a newly generated Id</returns>
        private static CustomerFile SaveCustomerFile(CustomerFile customerFile)
        {
            customerFile.Validate(); // validate the customer file

            // open a new connection to the database
            using(IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
            {
                try
                {
                    // perform SQL data manipulation and return last inserted rowID
                    int customerFileId = connection.ExecuteScalar<int>(
                        "INSERT INTO CustomerFiles (Name, Customer, FileType, FileLocation) VALUES (@Name, @Customer, @FileType, @FileLocation);" +
                        "SELECT last_insert_rowid() AS int", 
                        new {
                                Name = customerFile.Name,
                                Customer = customerFile.Customer.CustomerId,
                                FileType = customerFile.FileType.FileTypeId,
                                FileLocation = customerFile.FileLocation
                            });

                    customerFile.FileId = customerFileId; // add auto generated is to the customer object

                    FileSaved?.Invoke(customerFile, EventArgs.Empty); // invoke FileSaved event
                    return customerFile; // return the customerFile object
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Attempts to update a CustomerFile record in the database, then invokes the FileUpdated event
        /// </summary>
        /// <returns></returns>
        public static CustomerFile UpdateCustomerFile(CustomerFile customerFile)
        {
            customerFile.Validate(); // validate CustomerFile

            // Open a new connection to the database
            using (IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
            {
                try
                {
                    // Perform SQL Data Manipulation
                    connection.Execute("UPDATE CustomerFiles " +
                        "SET FileType=@FileType, Customer=@Customer, Name=@Name, FileLocation=@FileLocation WHERE FileId=@Id;",
                        new
                        {
                            FileType = customerFile.FileType.FileTypeId,
                            Customer = customerFile.Customer.CustomerId,
                            Name = customerFile.Name,
                            FileLocation = customerFile.FileLocation,
                            Id = customerFile.FileId
                        });

                    FileUpdated?.Invoke(customerFile, EventArgs.Empty); // invoke the FileUpdated event
                    return customerFile; // return updated CustomerFile object
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        /// <summary>
        /// Attempts to delete a CustomerFile record from the database then invokes the FileDeleted event
        /// </summary>
        /// <param name="customerFile">The CustomerFile to be deleted</param>
        /// <returns>The delete CustomerFile object</returns>
        public static CustomerFile DeleteCustomerFile(CustomerFile customerFile)
        {
            // Open a new connection to the database
            using (IDbConnection connection = new SQLiteConnection(DataAccess.LoadConnectionString()))
            {
                try
                {
                    // Perform SQL Data Manipulation to delete a Customer File
                    connection.Execute("DELETE FROM CustomerFiles WHERE FileId=@Id", new { Id = customerFile.FileId });
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            FileDeleted?.Invoke(customerFile, EventArgs.Empty); // invoke the File Deleted event
            return customerFile; // return the deleted customerfile object
        }
       
    }
}
