using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading;


namespace DcrawUi
{
    public delegate void WorkHasFinishedDelegate(int ID);
    

    public class ProcessWorker 
    {
        public event WorkHasFinishedDelegate WorkHasFinished;
        public DcrawUi.Form1.TextRecievedDelegate texthasrecieved;
        int ID;
        Process startInfo;
        bool running;

        public ProcessWorker(int ID, string parameters)
        {
            this.parameters = parameters;
            this.ID = ID;
        }

        private string parameters { get; set; }

        public void StartProcess()
        {

            startInfo = new Process();
            startInfo.StartInfo.FileName = @"dcraw.exe";
            startInfo.StartInfo.UseShellExecute = false;
            startInfo.StartInfo.RedirectStandardOutput = true;
            startInfo.StartInfo.RedirectStandardError = true;
            startInfo.StartInfo.RedirectStandardInput = true;
            
            startInfo.StartInfo.CreateNoWindow = true;
            startInfo.EnableRaisingEvents = true;
            startInfo.StartInfo.Arguments = parameters; // your arguments
            sendMessage("Starting converting : " + parameters);
            startInfo.OutputDataReceived += new DataReceivedEventHandler(startInfo_OutputDataReceived);
            startInfo.Exited += new EventHandler(startInfo_Exited);
            startInfo.ErrorDataReceived += new DataReceivedEventHandler(startInfo_ErrorDataReceived);


            running = startInfo.Start();
            startInfo.StandardInput.AutoFlush = true;
            startInfo.BeginOutputReadLine();
            startInfo.BeginErrorReadLine();
            //new Thread(read).Start();
           
            
            
            //string output = startInfo.StandardOutput.ReadToEnd();
               
            //startInfo.WaitForExit();
            //if (WorkHasFinished != null)
            //{
            //    WorkHasFinished(ID);
            //    sendMessage("End converting : " + parameters);
            //}
            
        }

        void startInfo_Exited(object sender, EventArgs e)
        {
            running = false;
            //r.Stop();
            if (WorkHasFinished != null)
            {
                WorkHasFinished(ID);
                sendMessage("End converting : " + parameters);
            }
            
        }

        void startInfo_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            sendMessage(e.Data);
        }

        void startInfo_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            sendMessage(e.Data);
        }

        private void sendMessage(string text)
        {
            if (texthasrecieved != null)
            {
                texthasrecieved(text);
            }
        }


        private void read()
        {
             while (!startInfo.HasExited)
            {
                String line;
                //startInfo.StandardError.BaseStream.Flush();
                if ((line = startInfo.StandardError.ReadLine()) != null)
                {
                    sendMessage(line);
                }
                line = null;
                //startInfo.StandardOutput.BaseStream.Flush();
                if ((line = startInfo.StandardOutput.ReadLine()) != null)
                {
                    sendMessage(line);
                }
            }
        }

    }
}
