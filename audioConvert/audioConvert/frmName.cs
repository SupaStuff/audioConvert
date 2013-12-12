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

        private void add2txt()
        {
            //pastes a selected item's subItem[2] at the cursor in the text box
            if (this.listName.SelectedItems.Count > 0) this.txtName.Paste(this.listName.SelectedItems[0].SubItems[2].Text);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            this.txtFormat = this.txtName.Text; //store the txtbox in a String so the main frame can get it
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtName.Text = ""; //clears the textbox
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            this.txtName.Paste("\\");//adds a \ character
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            this.txtName.Paste(" "); //adds a space
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add2txt(); //when you click the button, adds the selected property to the textbox
        }

        private void listName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            add2txt(); //when you double click a property, it adds it to the textbox
        }
    }
}
