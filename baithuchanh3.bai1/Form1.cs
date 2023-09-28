using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baithuchanh3.bai1
{
    public partial class Mynameproject : Form
    {
        public Mynameproject()
        {
            InitializeComponent();
        }

        private void btnclear_click(object sender, EventArgs e)
        {
            txtyourname.Clear();
            txtyob.Clear();
            txtyourname. Focus();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year;
            age = Convert.ToInt32(txtyob.Text);
            string s ="My name is: "+ txtyourname.Text + "\n" + age.ToString();
            MessageBox.Show(s);
        }

        private void txtyourname_Leave(object sender, EventArgs e)
        {
            Control ctr =(Control)sender;
            if (ctr.Text.Length == 0 )
            {
                this.errorProvider1.SetError(txtyourname, "You must enter your name");
            }
            else 
                this.errorProvider1.Clear();
        }

        private void txtyob_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !char.IsDigit(ctr.Text, ctr.Text.Length - 1))
                this.errorProvider1.SetError(txtyob, "This is not avalid number");
            else this.errorProvider1.Clear();
                
        }

        

       
        private void Mynameproject_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Do you want to close?", "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
