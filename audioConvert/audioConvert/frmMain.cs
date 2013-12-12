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
            //removes selected items from the input listbox
            while (this.listIn.SelectedItems.Count != 0) this.listIn.Items.Remove(this.listIn.SelectedItems[0]);
        }

        private void addStuff(bool deleteIt)
        {
            //open file dialog box
            OpenFileDialog openStuff = new OpenFileDialog();
            openStuff.Multiselect = true;
            openStuff.Filter = "Audio Files (*.wav, *.ogg, *.flac)|*.wav;*.ogg;*.flac";

            if (openStuff.ShowDialog() == DialogResult.OK)
            {
                //delete it is true for one button and false for another
                if (deleteIt)
                {
                    //deletes existing items by selecting them and calling removeStuff()
                    for (int i = 0; i < this.listIn.Items.Count; i++) this.listIn.SetSelected(i, true);
                    removeStuff();
                }
                //add files from the openfile dialog box
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
            addStuff(true);//delete first then add to the list
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addStuff(false);//add to the existing list
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //folder dialog box for selecting the path
            FolderBrowserDialog folderStuff = new FolderBrowserDialog();
            //store the folder in the text box
            if (folderStuff.ShowDialog() == DialogResult.OK) this.txtOut.Text = folderStuff.SelectedPath;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            //brings up the format helper
            frmName formatHelp = new frmName(this.txtName.Text);
            //puts the results in the text box
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
            //checkbox enables/disables these button and textbox
            this.txtOut.Enabled ^= true;
            this.btnOut.Enabled ^= true;
        }
    }
}
