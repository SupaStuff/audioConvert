namespace audioConvert
{
    partial class frmName
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "album",
            "Inserts the album title in all lowercase",
            "<album>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Album",
            "Inserts the album title with the capitalization found in the file\'s properties",
            "<Album>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "ALBUM",
            "Inserts the album title in all UPPERCASE",
            "<ALBUM>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "albumartist",
            "Inserts the album artist in all lowercase",
            "<albumartist>"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.WindowText, null);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Albumartist",
            "Inserts the album artist with the capitalization found in the file\'s properties",
            "<Albumartist>"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.WindowText, null);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "ALBUMARTIST",
            "Inserts the album artist in all UPPERCASE",
            "<ALBUMARTIST>"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.WindowText, null);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "artist",
            "Inserts the track artist in all lowercase",
            "<artist>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Artist",
            "Inserts the track artist with the capitalization found in the file\'s properties",
            "<Artist>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "ARTIST",
            "Inserts the track artist in all UPPERCASE",
            "<ARTIST>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Disc",
            "Inserts the disc number",
            "<disc>"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.WindowText, null);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Discs",
            "Inserts the total discs number. (eg. <disc> of <discs>)",
            "<discs>"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.WindowText, null);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Filename",
            "Inserts the old filename (not the path)",
            "<filename>"}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.WindowText, null);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "genre",
            "Inserts the genre in all lowercase",
            "<genre>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Genre",
            "Inserts the genre with the capitalization found in the file\'s properties",
            "<Genre>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "GENRE",
            "Inserts the genre in all UPPERCASE",
            "<GENRE>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "title",
            "Inserts the title in all lowercase",
            "<title>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem(new string[] {
            "Title",
            "Inserts the title with the capitalization found in the file\'s properties",
            "<Title>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem(new string[] {
            "TITLE",
            "Inserts the title in all UPPERCASE",
            "<TITLE>"}, -1);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem(new string[] {
            "Track #",
            "Inserts the track number with leading 0s to math the #s",
            "#"}, -1);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem(new string[] {
            "Year",
            "Inserts the album year",
            "<year>"}, -1);
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.listName = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSpace = new System.Windows.Forms.Button();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpName.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.HideSelection = false;
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(367, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGo.Location = new System.Drawing.Point(385, 9);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Done!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.listName);
            this.grpName.Controls.Add(this.btnAdd);
            this.grpName.Controls.Add(this.btnSpace);
            this.grpName.Controls.Add(this.btnDir);
            this.grpName.Controls.Add(this.btnClear);
            this.grpName.Location = new System.Drawing.Point(12, 39);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(456, 427);
            this.grpName.TabIndex = 2;
            this.grpName.TabStop = false;
            // 
            // listName
            // 
            this.listName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2});
            this.listName.FullRowSelect = true;
            this.listName.GridLines = true;
            this.listName.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listName.HideSelection = false;
            this.listName.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20});
            this.listName.Location = new System.Drawing.Point(8, 50);
            this.listName.MultiSelect = false;
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(440, 368);
            this.listName.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listName.TabIndex = 5;
            this.listName.UseCompatibleStateImageBehavior = false;
            this.listName.View = System.Windows.Forms.View.Details;
            this.listName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listName_MouseDoubleClick);
            // 
            // col1
            // 
            this.col1.Text = "Property";
            this.col1.Width = 84;
            // 
            // col2
            // 
            this.col2.Text = "Description";
            this.col2.Width = 352;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "/\\ /\\  Enter selected Property  /\\ /\\";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSpace
            // 
            this.btnSpace.Location = new System.Drawing.Point(292, 19);
            this.btnSpace.Name = "btnSpace";
            this.btnSpace.Size = new System.Drawing.Size(75, 23);
            this.btnSpace.TabIndex = 2;
            this.btnSpace.Text = "Space";
            this.btnSpace.UseVisualStyleBackColor = true;
            this.btnSpace.Click += new System.EventHandler(this.btnSpace_Click);
            // 
            // btnDir
            // 
            this.btnDir.Location = new System.Drawing.Point(211, 19);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(75, 23);
            this.btnDir.TabIndex = 1;
            this.btnDir.Text = "Folder";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(373, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 480);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtName);
            this.Name = "frmName";
            this.Text = "Format Help";
            this.grpName.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.Button btnSpace;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView listName;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
    }
}