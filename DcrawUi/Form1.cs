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

        public Form1()
        {
            InitializeComponent();
            files = new List<string>();
            workerHandler = new WorkersHandler();
            texthasrecieved = new TextRecievedDelegate(OnDataRecieved);
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
            workerHandler.Start(files, textBox_Parameters.Text, OnDataRecieved);
        }

        private void OnDataRecieved(string text)
        {
            if (textBox_Log.InvokeRequired)
            {

                textBox_Log.Invoke(new Action(() => textBox_Log.Text += text + "\r\n"));
            }
        }
        
    }
}
