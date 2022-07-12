/***********************************************************************\
 *  
 *  File:       IFile.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the IFile interface. 
 *  The purpose of this interface is to define the required properties and 
 *  methods for any class that implements the interface. 
 *  
 *  There can be multiple types of Files/documents (Architectual plans, 
 *  Financial Files, Compliance Documents) each requiring their own specific 
 *  implemention.  
 *
 *  Although this application currently only has one type of File (a 
 *  CustomerFile), in future additional file types may be required such as
 *  Financial Files (Invoices, Quotes etc..) so this interface was 
 *  created to allow the application to scale for future requirements.
 *  
 *  
 \***********************************************************************/


namespace CustomerFileManager.Models.FileModels
{
    public interface IFile
    { 
        string Name { get; set; }           // The user defined name of the file
        string FileLocation { get; set; }   // The location of the File in the FileSystem

        void Validate();                    // each file must implement a Validate() method
    }
}
