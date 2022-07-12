/***********************************************************************\
 *  
 *  File:       CustomerFile.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the a CustomerFile model. 
 *  A CutomerFile is any file in the file system associated with a Customer.
 *  The purpose of this form is to define the structure of a CustomerFile 
 *  object and contains methods related to the Customer object.
 *  
 *  This class implements the IFile interface
 *  
 \***********************************************************************/


using System;
using System.IO;

using CustomerFileManager.Models.CustomerModels;

namespace CustomerFileManager.Models.FileModels
{
    public class CustomerFile : IFile
    {
        public int FileId { get; set; }
        /// <summary>
        /// Name: A user defined name for this file (not necessarily the system File Name)
        /// </summary>
        public string Name { get; set; } = string.Empty;
        public Customer Customer { get; set; } = new Customer();
        public FileType FileType { get; set; } = new FileType();
        /// <summary>
        /// FileLocation: The full directory path, filename and extension of the file
        /// </summary>
        public string FileLocation { get; set; } = string.Empty;

        /// <summary>
        /// Validates the File object and throws an exception if validation failed
        /// </summary>
        public void Validate()
        {
            ValidateFileType(); // validate FileType
            ValidateName(); // validate Name
            ValidateFileLocation(); //validate FileLocation
            ValidateCustomer(); // validate Customer
            
        }

        /// <summary>
        /// Validates the File.Name property.
        /// Names cannot be empty and must be between 2 and 25 characters in length
        /// </summary>
        private void ValidateName()
        {
            // Name cannot be empty
            if (string.IsNullOrEmpty(Name.Trim()))
                throw new Exception("File Name cannot be empty");

            // Name must be between 2 and 50 characters
            if (Name.Trim().Length < 2 || Name.Trim().Length > 50)
                throw new Exception("File Name must be between 2 and 50 characters in length");
        }

        /// <summary>
        /// Validates a Customer has been provided. 
        /// If provided, the Customer validation is called
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void ValidateCustomer()
        {
            // confirm customer has been provided
            if(Customer == null) throw new Exception("No Customer provided");
            Customer.Validate(); // validate the customer
        }

        /// <summary>
        /// Validates a FileType has been provided. 
        /// If provided, the FileType validation is called.
        /// </summary>
        /// <exception cref="Exception"></exception>
        private void ValidateFileType()
        {
            // confirm that a file type has been provided
            if (FileType == null) throw new Exception("No File Type provided");
            FileType.Validate(); // validate the file type
        }

        /// <summary>
        /// Validates the FileLocation property.
        /// File Location is Required.  FileLocation must be valid/exist
        /// </summary>
        private void ValidateFileLocation()
        {
            // File Location cannot be empty
            if (string.IsNullOrEmpty(FileLocation.Trim()))
                throw new Exception("File Location cannot be empty");
        
            // File Location must be valid/exist
            if(!File.Exists(FileLocation))
                throw new Exception("File does not exist");
        }

        /// <summary>
        /// overrides the objects ToString() method to return a custom string 
        /// </summary>
        /// <returns>FileType.Type: Name - Customer.Name</returns>
        public override string ToString()
        {
            return $"{FileType.Type}: {Name} - {Customer.Name}";
        }
    }
}
