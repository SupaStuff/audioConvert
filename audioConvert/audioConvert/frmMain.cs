using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audioConvert
{
    public partial class frmMain : Form
    {
        private String s;
        public frmMain()
        {
            InitializeComponent();
        }

        private void removeStuff()
        {
            while (this.listIn.SelectedItems.Count != 0) this.listIn.Items.Remove(this.listIn.SelectedItems[0]);
        }

        private void addStuff(bool deleteIt)
        {
            OpenFileDialog openStuff = new OpenFileDialog();
            openStuff.Multiselect = true;

            if (openStuff.ShowDialog() == DialogResult.OK)
            {
                if (deleteIt)
                {
                    for (int i = 0; i < this.listIn.Items.Count; i++) this.listIn.SetSelected(i, true);
                    removeStuff();
                }
                foreach (String file in openStuff.FileNames) this.listIn.Items.Add(file);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            removeStuff();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            addStuff(true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addStuff(false);
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderStuff = new FolderBrowserDialog();
            if (folderStuff.ShowDialog() == DialogResult.OK) this.txtOut.Text = folderStuff.SelectedPath;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            frmName formatHelp = new frmName(this.txtName.Text);
            if (formatHelp.ShowDialog() == DialogResult.OK) this.txtName.Text = formatHelp.txtFormat;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            //output path or same dir [1]
            if (this.chkDefault.Checked) s = "\"\"";
            else s = "\"" + this.txtOut.Text + "\\\\\"";

            //selected codec [2]
            s += " " + this.listFormat.SelectedIndex + " ";
            
            //codec options [3] delimiter " "
            s += " \"\"";

            //name format [4] delimiter " "
            s += " \"" + this.txtName.Text + "\"";

            //input files [5+]
            for (int i = 0; i < this.listIn.Items.Count; i++ ) s += " \""+ this.listIn.Items[i].ToString()+"\"";
            
            //do work
            Process.Start("convertIt.exe", s);
        }

        private void chkDefault_CheckedChanged(object sender, EventArgs e)
        {
            this.txtOut.Enabled ^= true;
            this.btnOut.Enabled ^= true;
        }
    }
}
