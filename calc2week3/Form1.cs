using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc2week3
{
    public partial class Form1 : Form
    {
        Single sngNum1, sngNum2, sngAnswer;
        string strCalc;

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            
                //copy the number to the num1 variable
                sngNum1 = Convert.ToSingle(txtNum1.Text); //set the calc variable with multiply
                strCalc = "multiply"; //clear the txtnum1.text box and remove the numbers ready for the new numbers
                txtNum1.Text = string.Empty; //Puts the cursor back in the textbox
                txtNum1.Focus();


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            // copy the number on the text of the button to the textbox
            txtNum1.Text += btn1.Text;
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // copy the number on the text of the button to the textbox
            txtNum1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNum1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNum1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNum1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNum1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNum1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNum1.Text += btn8.Text;

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNum1.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNum1.Text += btn0.Text;
        }

        public Single add(Single sngnum1, Single sngnum2)
        {
            return sngNum1 + sngNum2; //Pass the answer to the label and the listbox
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            sngNum2 = Convert.ToSingle(txtNum1.Text);
            txtNum1.Text = string.Empty; //if the calc holds the text of multiply (note the == for absolute)
            if (strCalc == "multiply")
            { //run the calculation
                sngAnswer = sngNum1 * sngNum2; //Pass the answer to the label and the listbox
                lblAnswer.Text = Convert.ToString(sngAnswer);
                lbxAnswer.Items.Add(sngNum1 + " X " + sngNum2 + " = " + sngAnswer);
            }
            if (strCalc == "divide")
            { //run the calculation
                sngAnswer = sngNum1 / sngNum2; //Pass the answer to the label and the listbox
                lblAnswer.Text = Convert.ToString(sngAnswer);
                lbxAnswer.Items.Add(sngNum1 + " / " + sngNum2 + " = " + sngAnswer);
            }
            if (strCalc == "plus")
            { //run the calculation
                sngAnswer = add(sngNum1, sngNum2); //Pass the answer to the label and the listbox
                lblAnswer.Text = Convert.ToString(sngAnswer);
                lbxAnswer.Items.Add(sngNum1 + " + " + sngNum2 + " = " + sngAnswer);
            }
            if (strCalc == "minus")
            { //run the calculation
                sngAnswer = sngNum1 - sngNum2; //Pass the answer to the label and the listbox
                lblAnswer.Text = Convert.ToString(sngAnswer);
                lbxAnswer.Items.Add(sngNum1 + " - " + sngNum2 + " = " + sngAnswer);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset the number variables to 0
            sngNum1 = 0;
            sngNum2 = 0;
            sngAnswer = 0; //reset the string variable to nothing (two empty quote marks) and the text box to nothing
            strCalc = "";
            txtNum1.Text = "";
            lblAnswer.Text = ""; //clear the listbox
            lbxAnswer.Items.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //copy the number to the num1 variable
            sngNum1 = Convert.ToSingle(txtNum1.Text); //set the calc variable with multiply
            strCalc = "divide"; //clear the txtnum1.text box and remove the numbers ready for the new numbers
            txtNum1.Text = string.Empty; //Puts the cursor back in the textbox
            txtNum1.Focus();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //copy the number to the num1 variable
            sngNum1 = Convert.ToSingle(txtNum1.Text); //set the calc variable with multiply
            strCalc = "plus"; //clear the txtnum1.text box and remove the numbers ready for the new numbers
            txtNum1.Text = string.Empty; //Puts the cursor back in the textbox
            txtNum1.Focus();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //copy the number to the num1 variable
            sngNum1 = Convert.ToSingle(txtNum1.Text); //set the calc variable with multiply
            strCalc = "minus"; //clear the txtnum1.text box and remove the numbers ready for the new numbers
            txtNum1.Text = string.Empty; //Puts the cursor back in the textbox
            txtNum1.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //two variables to hold the text and the length of the text
            string text;
            int textlength;
            //pass the text from the text box to the text variable
            text = txtNum1.Text;
            //find the length of the text (how many numbers)
            textlength = Convert.ToInt16(text.Length);
            //create a substring of that text starting at the first number (0) and ending with the one before the last (-1)
            text = text.Substring(0, textlength - 1);
            //pass the new string back to the text box
            txtNum1.Text = text;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
