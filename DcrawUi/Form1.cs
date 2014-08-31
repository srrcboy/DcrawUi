using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DcrawUi
{
    public partial class Form1 : Form
    {
        List<String> files;
        WorkersHandler workerHandler;
        public delegate void TextRecievedDelegate(string text);
        public event TextRecievedDelegate texthasrecieved;
        public string[] Args;

        public Form1()
        {

            InitializeComponent();
            files = new List<string>();
            workerHandler = new WorkersHandler();
            texthasrecieved = new TextRecievedDelegate(OnDataRecieved);
            textBox_Parameters.TextChanged += new EventHandler(textBox_Parameters_TextChanged);
        }

        public Form1(string[] args)
        {
            
            InitializeComponent();
            files = new List<string>();
            workerHandler = new WorkersHandler();
            texthasrecieved = new TextRecievedDelegate(OnDataRecieved);
            textBox_Parameters.TextChanged += new EventHandler(textBox_Parameters_TextChanged);
            addFiles(args);
        }

        public delegate void ProcessParametersDelegate(object sender, string[] args);
        public void ProcessParameters(object sender, string[] args)
        {
            // The form has loaded, and initialization will have been be done.

            // Add the command-line arguments to our textbox, just to confirm that
            // it reached here.
            if (args != null && args.Length != 0)
            {
                addFiles(args);
            }
        }

        private void addFiles(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].EndsWith(".raw"))
                {
                    files.Add(args[i]);
                    listView1.Items.Add(args[i]);
                }
                
            }
        }


        void textBox_Parameters_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Settings_textbox = textBox_Parameters.Text;
            Properties.Settings.Default.Save();
        }

        private void toolStripButton_Add_Files_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                files.AddRange(openFileDialog1.FileNames);
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    listView1.Items.Add(openFileDialog1.FileNames[i]);
                }
                // Assign the cursor in the Stream to the Form's Cursor property.
                
            }
        }

        private void toolStripButton_addFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(folderBrowserDialog1.SelectedPath);
                for (int i = 0; i < root.GetFiles().Length; i++)
                {
                    if (root.GetFiles()[i].FullName.EndsWith(".raw"))
                    {
                        files.Add(root.GetFiles()[i].FullName);
                        listView1.Items.Add(root.GetFiles()[i].FullName);
                    }
                    
                }
                
            }
        }

        private void toolStripButton_ConvertFiles_Click(object sender, EventArgs e)
        {
            List<String> toWork = new List<string>();
            toWork.AddRange(files);
            workerHandler.Start(toWork, textBox_Parameters.Text, OnDataRecieved);
        }

        private void OnDataRecieved(string text)
        {
            if (textBox_Log.InvokeRequired)
            {

                textBox_Log.Invoke(new Action(() => writeToLog(text)));
            }
        }

        private void writeToLog(string text)
        {
            textBox_Log.Text += text + "\r\n";
            textBox_Log.SelectionStart = textBox_Log.Text.Length;
            textBox_Log.ScrollToCaret();
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            addFiles(s);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        
    }
}
