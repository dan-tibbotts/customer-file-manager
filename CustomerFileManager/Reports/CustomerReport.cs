/***********************************************************************\
 *  
 *  File:       CustomerReport.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the CustomerReport class. 
 *  The purpose of this class is to contain methods related to 
 *  generating and saving a CustomerReport to the file system.
 *  
 *  A Customer report contains information related to a customer 
 *  and their associated files
 *  
 * ## EXAMPLE OF THE CUSTOMER REPORT OUTPUT ##
 * 
 * REPORT FOR CUSTOMER NAME
 * ------------------------
 * Generated: 11/07/2022 7:45am
 * 
 * Customer Id: Customer Id
 * Name: Customer Name
 * Phone: Customer Phone
 * Email: Customer Email
 * 
 * Total Files: Total Number of Files
 * 
 * Files
 * ------------------------------------------------------
 * ID  | FILE TYPE |  NAME     |   LOCATION
 * ------------------------------------------------------
 * 1   | Image     |  Logo     |   C:/Images/Logos/logo.png  (example record)
 * ...
 * 
 \***********************************************************************/

using System;
using System.IO;
using System.Collections.Generic;

using CustomerFileManager.Models.CustomerModels;
using CustomerFileManager.Models.FileModels;
using CustomerFileManager.DataAccess;

namespace CustomerFileManager.Reports
{
    /// <summary>
    /// Class for generating Customer reports and saving the generated report to the file system.
    /// </summary>
    public class CustomerReport
    {
        /// <summary>
        /// Generates a Customer report and saves the report to the File System 
        /// at the specified location
        /// </summary>
        /// <param name="customer">The customer associated with this report</param>
        /// <param name="fileName">The output filename to save the report including the directory path e.g. c:/folder/file.txt</param>
        /// <exception cref="Exception"></exception>
        public static void GenerateReport(Customer customer, string fileName)
        {
            if (File.Exists(fileName)) throw new Exception("The file already exists, please select a new filename");
         
            // Get customer files 
            List<CustomerFile> fileList = FileDataAccess.GetCustomerFiles(customer);

            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                // Write heading and underline
                string heading = $"REPORT FOR {customer.Name.ToUpper()}";
                sw.WriteLine(heading);
                sw.WriteLine(new string('-', heading.Length));  // repeat '-' character to the length of the heading

                // Write generated day / time formatted dd/MM/yyyy h:mmtt
                sw.WriteLine($"Generated: {DateTime.Now.ToString("dd/MM/yyyy h:mmtt")}");

                sw.WriteLine(); // write a blank line

                // Write Customer Details
                sw.WriteLine($"Customer Id:\t{customer.CustomerId}");
                sw.WriteLine($"Name:\t\t{customer.Name}");
                sw.WriteLine($"Phone:\t\t{customer.Phone}");
                sw.WriteLine($"Email:\t\t{customer.Email}");

                sw.WriteLine(); // write a blank line

                sw.WriteLine($"Total Files:\t{fileList.Count.ToString()}"); // write total files
                
                sw.WriteLine(); // write a blank line

                // Write files heading and underline
                string filesHeading = "Customer Files";
                sw.WriteLine("Customer Files");
                sw.WriteLine(new string('-', filesHeading.Length));  // repeat '-' character to the length of the heading

                // sub heading string
                string subHeading = $"{PadString("ID", 5)} | " +
                                    $"{PadString("FILE TYPE", 15)} | " +
                                    $"{PadString("NAME", 20)} | " +
                                    $"LOCATION";

                // write sub-headings and underline
                sw.WriteLine(subHeading);
                sw.WriteLine(new string('-', subHeading.Length + 20)); // repeat '-' character to the length of the heading + 20 characters

                // loop through each file and write to the report
                foreach (CustomerFile customerFile in fileList)
                {
                    sw.WriteLine($"" +
                        $"{PadString(customerFile.FileId.ToString(), 5)} | " +  // FileId
                        $"{PadString(customerFile.FileType.Type, 15)} | " +     // File Type
                        $"{PadString(customerFile.Name, 20)} | " +              // User Defined File Name 
                        $"{customerFile.FileLocation}");                        // File Location
                }

                // If no files, write that the customer has no files
                if(fileList.Count == 0)
                {
                    sw.WriteLine("This customer does not have any files associated with their account");
                }

                sw.Close(); // close the stream reader

            }
        }

        /// <summary>
        /// Pads a string with empty characters on the right.
        /// The method ensures the returned string is always of the same length.
        /// If the string is greater than the maxLength, then the string is truncated to the length of the maxLength
        /// </summary>
        /// <param name="str"></param>
        /// <param name="maxLength"></param>
        /// <returns>A new string of matching the length of the maxLength</returns>
        private static string PadString(string str, int maxLength)
        {
            // if the string exceeds the maxLength
            // return the maxLength of characters
            if(str.Length > maxLength)
            {
                return str.Substring(0, maxLength);
            }
            // return new string with additional spaces padded to the right
            return str.PadRight(maxLength); 
        }
        

    }
}
