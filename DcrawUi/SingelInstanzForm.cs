using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;

namespace DcrawUi
{
    public class SingelInstanzForm : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        public SingelInstanzForm()
        {
            this.IsSingleInstance = true;
            this.EnableVisualStyles = true;

            // There are some other things available in 
            // the VB application model, for
            // instance the shutdown style:
            this.ShutdownStyle =
              Microsoft.VisualBasic.ApplicationServices.ShutdownMode.AfterMainFormCloses;

            // Add StartupNextInstance handler
            this.StartupNextInstance +=
              new StartupNextInstanceEventHandler(this.SIApp_StartupNextInstance);
        }

        /// <summary>
        /// We are responsible for creating the application's main form in this override.
        /// </summary>
        protected override void OnCreateMainForm()
        {
            // Create an instance of the main form and set it in the application; 
            // but don't try to run it.
            this.MainForm = new Form1();

            // We want to pass along the command-line arguments to this first instance

            // Allocate room in our string array
            ((Form1)this.MainForm).Args = new string[this.CommandLineArgs.Count];
                
            // And copy the arguments over to our form
            this.CommandLineArgs.CopyTo(((Form1)this.MainForm).Args, 0);
        }

        /// <summary>
        /// This is called for additional instances. The application model will call this 
        /// function, and terminate the additional instance when this returns.
        /// </summary>
        /// <param name="eventArgs"></param>
        protected void SIApp_StartupNextInstance(object sender, 
            StartupNextInstanceEventArgs eventArgs)
        {
            // Copy the arguments to a string array
            string[] args = new string[eventArgs.CommandLine.Count];
            eventArgs.CommandLine.CopyTo(args, 0);

            // Create an argument array for the Invoke method
            object[] parameters = new object[2];
            parameters[0] = this.MainForm;
            parameters[1] = args;

            // Need to use invoke to b/c this is being called from another thread.
            this.MainForm.Invoke(new Form1.ProcessParametersDelegate(
                ((Form1)this.MainForm).ProcessParameters), 
                parameters );
        }
        
    }
}
