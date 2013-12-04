namespace audioConvert
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOut = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.listFormat = new System.Windows.Forms.ComboBox();
            this.grpOut = new System.Windows.Forms.GroupBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.grpIn = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.listIn = new System.Windows.Forms.ListBox();
            this.grpEncode = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpOut.SuspendLayout();
            this.grpIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(6, 33);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(280, 20);
            this.txtOut.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(292, 30);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Browse...";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(292, 68);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 3;
            this.btnName.Text = "Format Help";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(220, 433);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Convert!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // listFormat
            // 
            this.listFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listFormat.FormattingEnabled = true;
            this.listFormat.Items.AddRange(new object[] {
            "MP3",
            "FLAC",
            "Ogg Vorbis",
            "WMA",
            "WAV",
            "AAC"});
            this.listFormat.SelectedIndex = 0;
            this.listFormat.Location = new System.Drawing.Point(6, 131);
            this.listFormat.Name = "listFormat";
            this.listFormat.Size = new System.Drawing.Size(121, 21);
            this.listFormat.TabIndex = 5;
            // 
            // grpOut
            // 
            this.grpOut.Controls.Add(this.chkDefault);
            this.grpOut.Controls.Add(this.lblOut);
            this.grpOut.Controls.Add(this.lblName);
            this.grpOut.Controls.Add(this.listFormat);
            this.grpOut.Controls.Add(this.lblFormat);
            this.grpOut.Controls.Add(this.txtName);
            this.grpOut.Controls.Add(this.btnName);
            this.grpOut.Controls.Add(this.txtOut);
            this.grpOut.Controls.Add(this.btnOut);
            this.grpOut.Location = new System.Drawing.Point(9, 119);
            this.grpOut.Name = "grpOut";
            this.grpOut.Size = new System.Drawing.Size(373, 158);
            this.grpOut.TabIndex = 6;
            this.grpOut.TabStop = false;
            this.grpOut.Text = "Output Options";
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Location = new System.Drawing.Point(9, 97);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(282, 17);
            this.chkDefault.TabIndex = 9;
            this.chkDefault.Text = "Use old file name and path (just change the extension)";
            this.chkDefault.UseVisualStyleBackColor = true;
            this.chkDefault.CheckedChanged += new System.EventHandler(this.chkDefault_CheckedChanged);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(6, 17);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(288, 13);
            this.lblOut.TabIndex = 8;
            this.lblOut.Text = "Specify the destination folder to store your converted music:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Specify the naming scheme:";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(3, 117);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(197, 13);
            this.lblFormat.TabIndex = 6;
            this.lblFormat.Text = "Select the format you wish to convert to:";
            // 
            // grpIn
            // 
            this.grpIn.Controls.Add(this.btnDelete);
            this.grpIn.Controls.Add(this.btnAdd);
            this.grpIn.Controls.Add(this.btnOpen);
            this.grpIn.Controls.Add(this.listIn);
            this.grpIn.Location = new System.Drawing.Point(9, 13);
            this.grpIn.Name = "grpIn";
            this.grpIn.Size = new System.Drawing.Size(373, 100);
            this.grpIn.TabIndex = 7;
            this.grpIn.TabStop = false;
            this.grpIn.Text = "Files to Convert";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(292, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(292, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Files...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(292, 14);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // listIn
            // 
            this.listIn.AllowDrop = true;
            this.listIn.FormattingEnabled = true;
            this.listIn.Location = new System.Drawing.Point(9, 20);
            this.listIn.Name = "listIn";
            this.listIn.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listIn.Size = new System.Drawing.Size(277, 69);
            this.listIn.Sorted = true;
            this.listIn.TabIndex = 0;
            // 
            // grpEncode
            // 
            this.grpEncode.Location = new System.Drawing.Point(9, 284);
            this.grpEncode.Name = "grpEncode";
            this.grpEncode.Size = new System.Drawing.Size(367, 143);
            this.grpEncode.TabIndex = 8;
            this.grpEncode.TabStop = false;
            this.grpEncode.Text = "Encoder Options";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(301, 433);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Done!";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 468);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpEncode);
            this.Controls.Add(this.grpIn);
            this.Controls.Add(this.grpOut);
            this.Controls.Add(this.btnGo);
            this.Name = "frmMain";
            this.Text = "audioConvert";
            this.grpOut.ResumeLayout(false);
            this.grpOut.PerformLayout();
            this.grpIn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ComboBox listFormat;
        private System.Windows.Forms.GroupBox grpOut;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.GroupBox grpIn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox listIn;
        private System.Windows.Forms.GroupBox grpEncode;
        private System.Windows.Forms.Button btnExit;
    }
}

