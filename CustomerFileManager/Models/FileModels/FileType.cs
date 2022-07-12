/***********************************************************************\
 *  
 *  File:       FileType.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the a FileType model. 
 *  
 *  The purpose of this class is to define the structure of a FileType 
 *  object and contains a Validation method to ensure the Type is valid.
 *  
 *  A FileType represents a user defined file category (e.g. Invoice, Quote, Image etc..) 
 *  and does not represent the file extenstion.
 *  
 *  
 \***********************************************************************/

using System;

namespace CustomerFileManager.Models.FileModels
{
    public class FileType
    {
        public int FileTypeId { get; set; }
        public string Type { get; set; }    // user defined file type e.g. Invoice, Quote

        /// <summary>
        /// Overrides the objects ToString() method to return the Type
        /// </summary>
        /// <returns>string of FileType.Type</returns>
        public override string ToString()
        {
            return Type;
        }

        /// <summary>
        /// Validates the FileType.Type property.
        /// Types cannot be empty and must be between 2 and 25 characters in length
        /// </summary>
        public void Validate()
        {
            // Name cannot be empty
            if (string.IsNullOrEmpty(Type))
                throw new Exception("File Type cannot be empty");

            // Name must be between 2 and 50 characters
            if (Type.Trim().Length < 2 || Type.Trim().Length > 25)
                throw new Exception("File Type must be between 2 and 25 characters in length");
        }
    }
}
