/***********************************************************************\
 *  
 *  File:       ICustomer.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the ICustomer interface. 
 *  The purpose of this interface is to define the required properties and 
 *  methods for any class that implements the interface. 
 *  
 *  There can be multiple customer types (residential, commercial etc...) 
 *  so this interface was created to allow this application to scale.
 *  
 *  
 \***********************************************************************/


namespace CustomerFileManager.Models.CustomerModels
{
    public interface ICustomer
    {
        int CustomerId { get; set; }    // An incrementing ID for a customer
        string Name { get; set; }       // The customers name

        void Validate();                // perform customer validation
    }
}
