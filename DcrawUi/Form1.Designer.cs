namespace DcrawUi
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Settings = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_Parameters = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Add_Files = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_addFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_ConvertFiles = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.Settings.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(686, 535);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(686, 560);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Settings);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(686, 535);
            this.tabControl.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.listView1);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(678, 509);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Files";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(672, 503);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox_Parameters);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_Parameters
            // 
            this.textBox_Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Parameters.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DcrawUi.Properties.Settings.Default, "Settings_textbox", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox_Parameters.Location = new System.Drawing.Point(9, 16);
            this.textBox_Parameters.Name = "textBox_Parameters";
            this.textBox_Parameters.Size = new System.Drawing.Size(663, 20);
            this.textBox_Parameters.TabIndex = 0;
            this.textBox_Parameters.Text = global::DcrawUi.Properties.Settings.Default.Settings_textbox;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_Log);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 509);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_Log
            // 
            this.textBox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Log.Location = new System.Drawing.Point(3, 3);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Log.Size = new System.Drawing.Size(672, 503);
            this.textBox_Log.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Add_Files,
            this.toolStripButton_addFolder,
            this.toolStripButton_ConvertFiles});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(219, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton_Add_Files
            // 
            this.toolStripButton_Add_Files.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Add_Files.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Add_Files.Image")));
            this.toolStripButton_Add_Files.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Add_Files.Name = "toolStripButton_Add_Files";
            this.toolStripButton_Add_Files.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton_Add_Files.Text = "Add Files";
            this.toolStripButton_Add_Files.Click += new System.EventHandler(this.toolStripButton_Add_Files_Click);
            // 
            // toolStripButton_addFolder
            // 
            this.toolStripButton_addFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_addFolder.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_addFolder.Image")));
            this.toolStripButton_addFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_addFolder.Name = "toolStripButton_addFolder";
            this.toolStripButton_addFolder.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton_addFolder.Text = "Add Folder";
            this.toolStripButton_addFolder.Click += new System.EventHandler(this.toolStripButton_addFolder_Click);
            // 
            // toolStripButton_ConvertFiles
            // 
            this.toolStripButton_ConvertFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_ConvertFiles.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_ConvertFiles.Image")));
            this.toolStripButton_ConvertFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_ConvertFiles.Name = "toolStripButton_ConvertFiles";
            this.toolStripButton_ConvertFiles.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton_ConvertFiles.Text = "Convert Files";
            this.toolStripButton_ConvertFiles.Click += new System.EventHandler(this.toolStripButton_ConvertFiles_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "RAW|*.raw|RAW|.*RAW";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(470, 459);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 560);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "DcrawUI";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.Settings.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Add_Files;
        private System.Windows.Forms.ToolStripButton toolStripButton_addFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox_Parameters;
        private System.Windows.Forms.ToolStripButton toolStripButton_ConvertFiles;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox_Log;
        private System.Windows.Forms.TextBox textBox1;
    }
}

