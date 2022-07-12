/***********************************************************************\
 *  
 *  File:       DataAccess.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the DataAccess object.
 *  
 *  The purpose of this class is to contain helper methods for 
 *  working with the Database.
 *  
 \***********************************************************************/

using System.Configuration;

namespace CustomerFileManager.DataAccess
{
    internal class DataAccess
    {
        /// <summary>
        /// Returns the connection string for the SQLite database 
        /// as defined in the App.Config file
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static string LoadConnectionString(string id = "Default")
        {
            // return connection string from the App.Config file
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
