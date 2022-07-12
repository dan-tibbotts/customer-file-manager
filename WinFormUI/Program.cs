/***********************************************************************\
 *  
 *  File:       Program.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  Project Summary:
 *  This application is a file management system that allows users
 *  to associate files located in various locations of the file system
 *  with a Customer record. 
 *  
 *  
 *  File Summary: 
 *  This file holds the class for the Program.cs object. 
 *  
 *  The static Program.cs class is the entry point of the application and first loads 
 *  the splash screen.  When the splash screen closes, the Main.cs form
 *  is run allowing the user to use the programs functionality.
 *  
 *  
 \***********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
            Application.Run(new Main());
        }
    }
}
