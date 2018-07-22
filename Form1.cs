using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorOving
{
    public partial class Form1 : Form
    {

        infix2postfix i2p = new infix2postfix();
        
       
        public Form1()
        {
            InitializeComponent();
        }
       

        private void nr1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "2";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "*";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "4";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "5";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "6";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "7";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "8";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "9";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "3";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "/";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Clear();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            PostfixEvaluator p = new PostfixEvaluator();
            string infixBuffer = richTextBox1.Text;
            string postfixBuffer = "";
            i2p.InfixToPostfixConvert(ref infixBuffer, out postfixBuffer);

            richTextBox1.Text = postfixBuffer;

            char[] postfix = richTextBox1.Text.ToCharArray();
            
            int a = p.EvaluatePostfix(postfix);
            resultbox.Text = a.ToString();
              
        }



        private void label14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "0";
        }

        private void resultbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += ")";
        }

        private void label18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "(";
        }
        

    }
}
