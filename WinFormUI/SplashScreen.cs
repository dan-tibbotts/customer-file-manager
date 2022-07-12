/***********************************************************************\
 *  
 *  File:       SplashScreen.cs
 *  Project:    Customer File Manager
 *  Author:     Daniel Tibbotts
 *  Date:       July 2022
 *  
 *  File Summary: 
 *  This file holds the class for the SplashScreen form. 
 *  This form stays open for 2000ms and then closes. 
 *  The purpose of this form is to display to the user the program 
 *  information such as Logo and author details.
 *  
 \***********************************************************************/

using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class SplashScreen : Form
    {
        private readonly Timer timer = new Timer(); // holds a new Timer object
        private readonly int waitTimeMS = 2000;     // the timer interval

        /// <summary>
        /// Default constructor that initializes the form components 
        /// and starts the clock timer.
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();

            timer.Tick += OnTimerElapsed;   // subscribe to timer Tick event
            timer.Interval = waitTimeMS;    // define timer interval
            timer.Enabled = true;           // start the timer
        }

        /// <summary>
        /// The event handler for the Timer Tick event.
        /// When the timer has elapsed this form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimerElapsed(object sender, EventArgs e)
        {
            this.Close();   // close the form
        }

        /// <summary>
        /// Finalizer (historically Destrustor) to dispose of the 
        /// timer when the class instance is collected by the garbage collector
        /// </summary>
        ~SplashScreen()
        {
            timer.Dispose();    // release the timer resources
        }

        /// <summary>
        /// When the user clicks the DanielTibbottsLink a process is started
        /// that opens their default browser and navigates to the LinkedIn page for Daniel Tibbotts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DanielTibbottsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Navigate to LinkedIn page for Daniel Tibbotts
                Process.Start("https://www.linkedin.com/in/daniel-tibbotts-a1b621197/");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
