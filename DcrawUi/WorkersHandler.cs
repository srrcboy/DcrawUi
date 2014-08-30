using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace DcrawUi
{
    public class WorkersHandler
    {
        List<String> files;
        String parameters;
        ProcessWorker[] runningProcesses = new ProcessWorker[3];
        Thread workerListner;
        DcrawUi.Form1.TextRecievedDelegate texthasrecieved;

        public void Start(List<String> files, String parameters, DcrawUi.Form1.TextRecievedDelegate dataoutput)
        {
            this.files = @files;
            this.parameters = parameters;
            this.texthasrecieved = dataoutput;
            

            //ProcessWorker worker2 = new ProcessWorker(1);
            //worker2.WorkHasFinished += new WorkHasFinishedDelegate(worker1_WorkHasFinished);
            //runningProcesses[1] = worker2;

            //ProcessWorker worker3 = new ProcessWorker(2);
            //worker1.WorkHasFinished += new WorkHasFinishedDelegate(worker1_WorkHasFinished);
            //runningProcesses[2] = worker2;

            if (files.Count > 0)
            {
                string tmp = parameters + " " + files[0];
                ProcessWorker worker1 = new ProcessWorker(0, tmp);
                worker1.WorkHasFinished += new WorkHasFinishedDelegate(worker1_WorkHasFinished);
                runningProcesses[0] = worker1;
                workerListner = new Thread(worker1.StartProcess);
                worker1.texthasrecieved = texthasrecieved;
                workerListner.Start();

                
                files.RemoveAt(0);
            }
            //if (files.Count > 0)
            //{
            //    worker2.StartProcess(parameters + files[0]);
            //    files.RemoveAt(0);
            //}
            //if (files.Count > 0)
            //{
            //    worker3.StartProcess(parameters + files[0]);
            //    files.RemoveAt(0);
            //}

        }

        void worker1_WorkHasFinished(int ID)
        {
            if (files.Count > 0)
            {
                string tmp = parameters + " " + files[0];
                ProcessWorker worker1 = new ProcessWorker(0,tmp);
                worker1.WorkHasFinished += new WorkHasFinishedDelegate(worker1_WorkHasFinished);
                worker1.texthasrecieved = texthasrecieved;
                runningProcesses[ID] = worker1;
                workerListner = new Thread(worker1.StartProcess);
                workerListner.Start();
                files.RemoveAt(0);
            }
        }

        
    }

}
