/***********************************************************************\
 *  
 *  File:       FormUtilities.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the FormUtilities 
 *  The purpose of this class is to contain helper methods related to 
 *  UI Forms and can used commonly across multiple classes.
 *  This class is sealed so cannot be inherited.
 *  
 \***********************************************************************/


using System.Windows.Forms;

namespace WinFormUI.Utilities
{
    public sealed class FormUtilities
    {
        /// <summary>
        /// Checks to see if the Form is currently open
        /// </summary>
        /// <param name="form"></param>
        /// <returns>true if form is open otherwise returns false</returns>
        public static bool FormOpen(Form form)
        {   // check if a form is open
            return System.Windows.Forms.Application.OpenForms[form.Name] != null;
        }

        /// <summary>
        /// Opens a the form in the specified MDI parent. 
        /// Only allows one instance of the form to be open at once.  
        /// If the form is already open, it is brought to the front. 
        /// </summary>
        /// <param name="form"></param>
        /// <param name="mdiParent"></param>
        public static void OpenFormInMdiOnce(Form form, Form mdiParent)
        {
            form.MdiParent = mdiParent; // set MDI parent

            // check if a form is open
            if (Application.OpenForms[form.Name] != null)
            {
                // loop through the open forms
                foreach(Form f in Application.OpenForms)
                {   // compare form name to open forms
                    if(f.Name == form.Name)
                        f.BringToFront(); // form is open, bring to front
                }
                form.Dispose(); // form object not needed
            } else
            {
                form.Show(); // form not open, open form
            }
        }
    }
}
