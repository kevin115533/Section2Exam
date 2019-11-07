using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section2Exam
{
    public partial class frmConverter : Form
    {
        public frmConverter()
        {
            InitializeComponent();
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {

        }

        public bool validateData(TextBox textbox)
        {
            return
                isBlank(textbox) &&
                isDecimal(textbox) &&
                isInt32(textbox);
        }

        public bool isBlank(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                lblMessage.Text = "Entry box is empty, please input a value";
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isInt32(TextBox textbox)
        {
            string string1 = textbox.Text;
            int number = 0;
            if (int.TryParse(string1, out number))
            {
                return true;
            }
            else
            {
                lblMessage.Text = "Decimals are not allow in the entries";
                return false;
            }
        }
        public bool isDecimal(TextBox textbox)
        {
            string string1 = textbox.Text;
            decimal number1 = 0;
            if (decimal.TryParse(string1, out number1))
            {
                return true;
            }
            else
            {
                lblMessage.Text = "Entry value is not numeric"; ;
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConverter_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBase.Text = "";
            txtConvertFrom.Text = "";
            lblMessage.Text = "Entry values cleared";
        }

        private void btnConvertTo_Click(object sender, EventArgs e)
        {
            if(validateData(txtConvertFrom) && validateData(txtBase))
            {
                lblMessage.Text = txtConvertFrom.Text + txtBase.Text;
            }
        }
    }
}
