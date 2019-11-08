using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Kevin Tran
 * ITD 1253
 * 11/7/2019
 */

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
            if (validateData(txtConvertFrom))
            {
                int x = int.Parse(txtConvertFrom.Text);
                lblMessage.Text = conversion(x, 2);
            }
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
            if (validateData(txtConvertFrom) && validateData(txtBase))
            {
                int x = int.Parse(txtConvertFrom.Text);
                lblMessage.Text =  txtBase.Text + "x" + conversion(x, int.Parse(txtBase.Text));
            }
        }

        private string conversion(int userNumber, int baseNumber)
        {
            string convertedNumber = "";
            while (userNumber > 0)
            {
                string holder = "";
                if(userNumber % baseNumber < 10)
                {
                    convertedNumber = convertedNumber + Convert.ToString(userNumber % baseNumber);
                }
                else
                {
                    convertedNumber = convertedNumber + Convert.ToString(baseLetter(userNumber % baseNumber));
                }
                userNumber = userNumber / baseNumber;
            }

            char[] original = convertedNumber.ToCharArray();
            char[] result = new char[original.Length];
            for (int i = 0, j = convertedNumber.Length - 1; i < convertedNumber.Length; i++, j--)
            {
                result[i] = original[j];
            }
            convertedNumber = string.Join("", result);
            return convertedNumber;
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            if (validateData(txtConvertFrom))
            {
                int x = int.Parse(txtConvertFrom.Text);
                lblMessage.Text = "0x" + conversion(x, 16);
            }
        }

        private string baseLetter(int x)
        {
            int number = x;
            string letter = "";
            switch (number)
            {
                case 10:
                    letter = "A";
                    break;
                case 11:
                    letter = "B";
                    break;
                case 12:
                    letter = "C";
                    break;
                case 13:
                    letter = "D";
                    break;
                case 14:
                    letter = "E";
                    break;
                case 15:
                    letter = "F";
                    break;
                default:
                    break;
            }
            return letter;
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            if (validateData(txtConvertFrom))
            {
                int x = int.Parse(txtConvertFrom.Text);
                lblMessage.Text = "8x" + conversion(x, 8);
            }
        }

        private void btnBase5_Click(object sender, EventArgs e)
        {
            if (validateData(txtConvertFrom))
            {
                int x = int.Parse(txtConvertFrom.Text);
                lblMessage.Text = "5x" + conversion(x, 5);
            }
        }

        private void btnBase7_Click(object sender, EventArgs e)
        {
            if (validateData(txtConvertFrom))
            {
                int x = int.Parse(txtConvertFrom.Text);
                lblMessage.Text = "7x" + conversion(x, 7);
            }
        }
    }
}
