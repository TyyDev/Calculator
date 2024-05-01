using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        public double num1;
        public double num2;
        public double result;
        public string strResult;
        public string strNum1;
        public string strNum2;



        public Form1()
        {
            InitializeComponent();
        }



        public void Form1_Load(object sender, EventArgs e)
        {





        }




        private void buttonAdd_Click(object sender, EventArgs e)
        {
            label5.Text = "+";
            strNum1 = textBox3.Text;
            strNum2 = textBox4.Text;
   
            num1 = Convert.ToDouble(strNum1);

            num2 = Convert.ToDouble(strNum2);

            result = num1 + num2;

            strResult = result.ToString();

            label4.Text = strResult;
        }




        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            label5.Text = "-";
            strNum1 = textBox3.Text;
            strNum2 = textBox4.Text;

            num1 = Convert.ToDouble(strNum1);

            num2 = Convert.ToDouble(strNum2);

            result = num1 - num2;

            strResult = result.ToString();

            label4.Text = strResult;


        }




        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            label5.Text = "x";
            strNum1 = textBox3.Text;
            strNum2 = textBox4.Text;

            num1 = Convert.ToDouble(strNum1);

            num2 = Convert.ToDouble(strNum2);

            result = num1 * num2;

            strResult = result.ToString();

            label4.Text = strResult;

        }

     


        private void buttonDivide_Click(object sender, EventArgs e)
        {
            label5.Text = "÷";
            strNum1 = textBox3.Text;
            strNum2 = textBox4.Text;

            num1 = Convert.ToDouble(strNum1);

            num2 = Convert.ToDouble(strNum2);

            result = num1 / num2;

            strResult = result.ToString();

            label4.Text = strResult;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
