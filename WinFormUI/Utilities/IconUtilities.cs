/***********************************************************************\
 *  
 *  File:       IconUtilities.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the IconUtilities 
 *  The purpose of this class is to contain helper methods related to 
 *  Image Icons and can used commonly across multiple classes.
 *  This class is a sealed singleton so only one instance of this class
 *  can be instanciated and cannot be inherited.
 *  
 *  This class contains 
 *  - an ImageList of file icons in the applications resources
 *  - and, a method for retieving the index of the icon based on a file extension
 *  
 *  
 \***********************************************************************/


using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormUI.Utilities
{
    public sealed class IconUtilities
    {

        private IconUtilities() { } // private constructor for singleton

        private static IconUtilities instance; // holds the current IconUtilities instance

        /// <summary>
        /// An ImageList of 32x32 sized images used to represent file extensions
        /// </summary>
        /// <returns>An ImageList of 32x32 file images</returns>
        private ImageList images32()
        {
            ImageList imageList = new ImageList();  // create a new object instance

            imageList.ImageSize = new Size(32, 32); // set the size of the images to 32x32

            imageList.Images.Add(Properties.Resources.file32);  // [0] default icon
            imageList.Images.Add(Properties.Resources.pdf32);   // [1] pdf
            imageList.Images.Add(Properties.Resources.png32);   // [2] png
            imageList.Images.Add(Properties.Resources.jpg32);   // [3] jpg, jpeg

            return imageList;
        }

        /// <summary>
        /// Calls the instance of the IconUtilities and returns a 32x32 list of images (ImageList)
        /// </summary>
        public static ImageList ImageList32 { get => Instance.images32(); } 

        /// <summary>
        /// Gets the current instance of the the IconUtilities. 
        /// If no instance exists a new instance is created
        /// </summary>
        public static IconUtilities Instance
        {
            get
            {
                // lock the instance to a single thread to prevent 
                // other threads from making their own instance
                lock (typeof(IconUtilities))
                {
                    if(instance == null)
                        instance = new IconUtilities(); // create new instance
                }

                return instance; // return one and only instnace
            }
        }

        /// <summary>
        /// Calls the private FileIconIndex method to return the index of the associated FileType.
        /// </summary>
        /// <param name="file"></param>
        /// <returns>The index (int) of the associated file type</returns>
        public static int GetFileIconIndex(FileInfo file) => Instance.FileIconIndex(file);

        /// <summary>
        /// Gets the file extension of the file parameter and returns the image index
        /// </summary>
        /// <param name="file"></param>
        /// <returns>The index in the ImageList for the associated file extension</returns>
        private int FileIconIndex(FileInfo file)
        {

            // get the file extension 
            string fileExtension = file.Extension.ToLower();

            // choose the appropriate file icon for the chosen extension
            switch (fileExtension)
            {
                case ".pdf":
                    return 1;
                case ".png":
                    return 2;
                case ".jpg":
                case ".jpeg":
                case ".jpe":
                case ".jif":
                case ".jfif":
                case ".jfi":
                    return 3;
                default:
                    return 0;
            }
        }
    }
}