using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace DcrawUi
{
    public delegate void WorkHasFinishedDelegate(int ID);
    

    public class ProcessWorker 
    {
        public event WorkHasFinishedDelegate WorkHasFinished;
        public DcrawUi.Form1.TextRecievedDelegate texthasrecieved;
        int ID;
        public ProcessWorker(int ID, string parameters)
        {
            this.parameters = parameters;
            this.ID = ID;
        }

        private string parameters { get; set; }

        public void StartProcess()
        {

                Process startInfo = new Process();
                startInfo.StartInfo.FileName = @"dcraw.exe";
                startInfo.StartInfo.UseShellExecute = false;
                startInfo.StartInfo.RedirectStandardOutput = true;
                startInfo.StartInfo.RedirectStandardError = true;
                startInfo.StartInfo.CreateNoWindow = true;
                startInfo.EnableRaisingEvents = true;
                startInfo.StartInfo.Arguments = parameters; // your arguments
                startInfo.OutputDataReceived += new DataReceivedEventHandler(startInfo_OutputDataReceived);
                startInfo.ErrorDataReceived += new DataReceivedEventHandler(startInfo_ErrorDataReceived);
                startInfo.Start();
                //string output = startInfo.StandardOutput.ReadToEnd();
                startInfo.WaitForExit();
                if (WorkHasFinished != null)
                {
                    WorkHasFinished(ID);
                }
        }

        void startInfo_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (texthasrecieved != null)
            {
                texthasrecieved(e.Data);
            }
        }

        void startInfo_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (texthasrecieved != null)
            {
                texthasrecieved(e.Data);
            }
        }
    }
}
