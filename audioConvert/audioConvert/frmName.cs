using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace audioConvert
{
    public partial class frmName : Form
    {
        public String txtFormat { get; set; }
        public frmName(String s)
        {
            InitializeComponent();
            this.txtName.Text = s;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.txtFormat = this.txtName.Text;
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            this.txtName.Paste("\\");
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            this.txtName.Paste(" ");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add2txt();
        }

        private void listName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            add2txt();
        }

        private void add2txt()
        {
            if (this.listName.SelectedItems.Count > 0) this.txtName.Paste(this.listName.SelectedItems[0].SubItems[2].Text);
        }

    }
}
