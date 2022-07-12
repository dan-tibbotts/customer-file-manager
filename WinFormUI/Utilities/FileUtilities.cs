/***********************************************************************\
 *  
 *  File:       FileUtilities.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the FileUtilities. 
 *  The purpose of this class is to contain helper methods used commonly across 
 *  multiple classes when using the file system.
 *  This class is a sealed singleton so only one instance can be instantiated at once
 *  and cannot be inherited.
 *  
 \***********************************************************************/


using System;
using System.IO;


namespace WinFormUI.Utilities
{
    public sealed class FileUtilities
    {
        private static FileUtilities instance;  // holds the single instance of this class
        private FileUtilities() { } // private default constructor as class is a singleton

        // string array that contains a list of known image file extenstions
        // Image extensions obtained from https://blog.filestack.com/thoughts-and-knowledge/complete-image-file-extension-list/
        private string[] imageFileExtenstions =
            {
                ".jpg", ".jpeg", ".jpe", ".jif", ".jfif", ".jfi", // JPG
                ".png", // PNG
                ".gif", // GIF
                ".webp", // WEBP
                ".tiff", ".tif", // TIFF             
                ".psd", // Adobe
                ".raw", ".arw", ".cr2", ".nrw", ".k25", // RAW
                ".bmp", ".dib", // BMP
                ".heif", ".heic", // HEIF
                ".ind", ".indd", ".indt", // INDD
                ".jp2", ".j2k", ".jpf", ".jpx", ".jpm", ".mj2", // JPEG 2000
                ".svg", ".svgz", // SVG
                ".ai", // AI
                ".eps" //EPS
            };

        /// <summary>
        /// Gets the one and only instance of the FileUtilities class.
        /// If no instance exists a new instnace is created.
        /// </summary>
        public static FileUtilities Instance
        {
            get
            {
                // lock the instance to a single thread to prevent 
                // other threads from making their own instance
                lock (typeof(FileUtilities))
                {
                    // create a new instance of this Class if one does not exist
                    if (instance == null)
                        instance = new FileUtilities(); // create new instance
                }
                return instance; // return the current instance

            }
        }

        /// <summary>
        /// Checks to see if the file is an image by comparing the file extenstion of the file 
        /// parameter to the list of image file extensions
        /// </summary>
        /// <param name="file"></param>
        /// <returns>true if an image, false if not image</returns>
        public static bool IsImageFile(FileInfo file)
        {
            // Loop through each image file extension and check if the 
            // file parameter extension is in the list.
            foreach(string ext in Instance.imageFileExtenstions)
            {
                if (file.Extension.Equals(ext, StringComparison.OrdinalIgnoreCase)) return true;
            }
            return false;
        }
    }
}
