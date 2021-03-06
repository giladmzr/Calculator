using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        #region properties
        private double num1 = 0;
        private double num2 = 0;
        private bool mul = false;
        private bool div = false;
        private bool add = false;
        private bool sub = false;
        private int cnt = 1;
        #endregion properties

        #region Load
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "";
        }
        #endregion Load

        #region opertions
        private void button20_Click(object sender, EventArgs e)     //divison
        {
            num1 = double.Parse(label1.Text);
            label1.Text = "0";
            label2.Text = "÷";
            div = true;
        }
        private void button14_Click(object sender, EventArgs e)         //add
        {
            num1 = double.Parse(label1.Text);
            label1.Text = "0";
            label2.Text = "+";
            add = true;
        }
        private void button15_Click(object sender, EventArgs e)     //sub
        {
            num1 = double.Parse(label1.Text);
            label1.Text = "0";
            label2.Text = "-";
            sub = true;
        }
        private void button16_Click(object sender, EventArgs e)     //mul
        {
            num1 = double.Parse(label1.Text);
            label1.Text = "0";
            label2.Text = "X";
            mul = true;
        }
        #endregion opertions

        #region otherOP
        private void button18_Click(object sender, EventArgs e)     //plus minus
        {
            double num = double.Parse(label1.Text);
            num *= -1;
            label1.Text = "" + num;
        }

        private void button19_Click(object sender, EventArgs e)         //precentage
        {
            if (div)
            {
                num2 = double.Parse(label1.Text);
                double sum_div = num1 / num2;
                double precentage = sum_div * 100;
                string s = "" + precentage;
                label1.Text = s + "%";
                label2.Text = "";
            }
        }
        private void button17_Click(object sender, EventArgs e)     //back space
        {
            if (label1.Text.Length > 1)
            {
                string cur = label1.Text;
                string New = cur.Remove(cur.Length - 1, 1);
                label1.Text = New;
            }
            else
                label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)      //fractions point
        {

            label1.Text += ".";

        }

        private void button3_Click(object sender, EventArgs e)      //clear
        {
            label1.Text = "0";
            label2.Text = "";
            num1 = 0;
            num2 = 0;
            mul = false;
            div = false;
            add = false;
            sub = false;

        }

        private void button13_Click(object sender, EventArgs e)             //equals
        {
            num2 = double.Parse(label1.Text);
            label2.Text = "";
            if (div)
            {
                label1.Text = "" + (num1 / num2);
                num1 = double.Parse(label1.Text);
                div = false;
                if (num2 == 0)
                {
                    label1.Text = "Math Error";
                    num1 = 0;
                }

            }

            else if (mul)
            {
                label1.Text = "" + (num1 * num2);
                num1 = double.Parse(label1.Text);
                mul = false;
            }

            else if (add)
            {
                label1.Text = "" + (num1 + num2);
                num1 = double.Parse(label1.Text);
                add = false;
            }

            else if (sub)
            {
                label1.Text = "" + (num1 - num2);
                num1 = double.Parse(label1.Text);
                sub = false;
            }


        }

        #endregion otherOP

        #region Numbers

        private void button2_Click(object sender, EventArgs e)      //zero
        {
                label1.Text += 0;
        }

        private void button5_Click(object sender, EventArgs e)      //one
        {

            label1.Text += 1;
            char a = label1.Text[0];
            bool d = true;
            if (label1.Text.Length > 1)
            {
                char b = label1.Text[1];
                if (b == '.')
                {
                    d = false;
                }
            }
            if (a == '0' && label1.Text.Length > 1 && d)
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
        }

        private void button6_Click(object sender, EventArgs e)      //two
        {

            label1.Text += 2;
            char a = label1.Text[0];
            bool d = true;
            if (label1.Text.Length > 1)
            {
                char b = label1.Text[1];
                if (b == '.')
                {
                    d = false;
                }
            }
            if (a == '0' && label1.Text.Length > 1 && d)
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
        }


        private void button4_Click(object sender, EventArgs e)          //three
        {
            label1.Text += 3;
            char a = label1.Text[0];
            bool d = true;
            if (label1.Text.Length > 1)
            {
                char b = label1.Text[1];
                if (b == '.')
                {
                   d = false;
                }
            }
            if (a == '0' && label1.Text.Length > 1 && d)
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += 4;
            char a = label1.Text[0];
            bool d = true;
            if (label1.Text.Length > 1)
            {
                char b = label1.Text[1];
                if (b == '.')
                {
                    d = false;
                }
            }
            if (a == '0' && label1.Text.Length > 1 && d)
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += 5;
            char a = label1.Text[0];
            bool d = true;
            if (label1.Text.Length > 1)
            {
                char b = label1.Text[1];
                if (b == '.')
                {
                    d = false;
                }
            }
            if (a == '0' && label1.Text.Length > 1 && d)
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            label1.Text += 6;
            char a = label1.Text[0];
            bool d = true;
            if (label1.Text.Length > 1)
            {
                char b = label1.Text[1];
                if (b == '.')
                {
                    d = false;
                }
            }
            if (a == '0' && label1.Text.Length > 1 && d)
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            label1.Text += 7;
            char a = label1.Text[0];
            bool d = true;
            if (label1.Text.Length > 1)
            {
                char b = label1.Text[1];
                if (b == '.')
                {
                    d = false;
                }
            }
            if (a == '0' && label1.Text.Length > 1 && d)
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {

            label1.Text += 8;
            char a = label1.Text[0];
            bool d = true;
            if (label1.Text.Length > 1)
            {
                char b = label1.Text[1];
                if (b == '.')
                {
                    d = false;
                }
            }
            if (a == '0' && label1.Text.Length > 1 && d)
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += 9;
            char a = label1.Text[0];
            bool d = true;
            if (label1.Text.Length > 1)
            {
                char b = label1.Text[1];
                if (b == '.')
                {
                    d = false;
                }
            }
            if (a == '0' && label1.Text.Length > 1 && d)
            {
                label1.Text = label1.Text.Remove(0, 1);
            }
        }
        #endregion Numbers

        #region Addon
        private void button21_Click(object sender, EventArgs e)     //Theme
        {
            switch (cnt)
            {
                #region DarkMode
                case 1: //Dark Mode
                    BackColor = Color.Black;
                    ForeColor = Color.White;
                    button1.BackColor = Color.FromArgb(105, 105, 105);
                    button2.BackColor = Color.FromArgb(105, 105, 105);
                    button3.BackColor = Color.FromArgb(105, 105, 105);
                    button4.BackColor = Color.FromArgb(105, 105, 105);
                    button5.BackColor = Color.FromArgb(105, 105, 105);
                    button6.BackColor = Color.FromArgb(105, 105, 105);
                    button7.BackColor = Color.FromArgb(105, 105, 105);
                    button8.BackColor = Color.FromArgb(105, 105, 105);
                    button9.BackColor = Color.FromArgb(105, 105, 105);
                    button10.BackColor = Color.FromArgb(105, 105, 105);
                    button11.BackColor = Color.FromArgb(105, 105, 105);
                    button12.BackColor = Color.FromArgb(105, 105, 105);
                    button13.BackColor = Color.FromArgb(105, 105, 105);
                    button14.BackColor = Color.FromArgb(105, 105, 105);
                    button15.BackColor = Color.FromArgb(105, 105, 105);
                    button16.BackColor = Color.FromArgb(105, 105, 105);
                    button17.BackColor = Color.FromArgb(105, 105, 105);
                    button18.BackColor = Color.FromArgb(105, 105, 105);
                    button19.BackColor = Color.FromArgb(105, 105, 105);
                    button20.BackColor = Color.FromArgb(105, 105, 105);
                    button21.BackColor = Color.Black;
                    cnt++;
                    break;

                #endregion DarkMode
                #region PurpleGlow
                case 2:
                    BackColor = Color.FromArgb(20, 20, 20);
                    ForeColor = Color.FromArgb(96, 0, 128); ;
                    button1.BackColor = Color.FromArgb(24, 28, 24);
                    button2.BackColor = Color.FromArgb(24, 28, 24);
                    button3.BackColor = Color.FromArgb(24, 28, 24);
                    button4.BackColor = Color.FromArgb(24, 28, 24);
                    button5.BackColor = Color.FromArgb(24, 28, 24);
                    button6.BackColor = Color.FromArgb(24, 28, 24);
                    button7.BackColor = Color.FromArgb(24, 28, 24);
                    button8.BackColor = Color.FromArgb(24, 28, 24);
                    button9.BackColor = Color.FromArgb(24, 28, 24);
                    button10.BackColor = Color.FromArgb(24, 28, 24);
                    button11.BackColor = Color.FromArgb(24, 28, 24);
                    button12.BackColor = Color.FromArgb(24, 28, 24);
                    button13.BackColor = Color.FromArgb(24, 28, 24);
                    button14.BackColor = Color.FromArgb(24, 28, 24);
                    button15.BackColor = Color.FromArgb(24, 28, 24);
                    button16.BackColor = Color.FromArgb(24, 28, 24);
                    button17.BackColor = Color.FromArgb(24, 28, 24);
                    button18.BackColor = Color.FromArgb(24, 28, 24);
                    button19.BackColor = Color.FromArgb(24, 28, 24);
                    button20.BackColor = Color.FromArgb(24, 28, 24);
                    button21.BackColor = Color.FromArgb(20, 20, 20);
                    cnt++;
                    break;
                #endregion PurpleGlow
                
                case 3:
                    button1.BackColor = Color.FromArgb(5, 139, 140);
                    button2.BackColor = Color.FromArgb(5, 139, 140);
                    button3.BackColor = Color.FromArgb(5, 139, 140);
                    button4.BackColor = Color.FromArgb(5, 139, 140);
                    button5.BackColor = Color.FromArgb(5, 139, 140);
                    button6.BackColor = Color.FromArgb(5, 139, 140);
                    button7.BackColor = Color.FromArgb(5, 139, 140);
                    button8.BackColor = Color.FromArgb(5, 139, 140);
                    button9.BackColor = Color.FromArgb(5, 139, 140);
                    button10.BackColor = Color.FromArgb(5, 139, 140);
                    button11.BackColor = Color.FromArgb(5, 139, 140);
                    button12.BackColor = Color.FromArgb(5, 139, 140);
                    button13.BackColor = Color.FromArgb(5, 139, 140);
                    button14.BackColor = Color.FromArgb(5, 139, 140);
                    button15.BackColor = Color.FromArgb(5, 139, 140);
                    button16.BackColor = Color.FromArgb(5, 139, 140);
                    button17.BackColor = Color.FromArgb(5, 139, 140);
                    button18.BackColor = Color.FromArgb(5, 139, 140);
                    button19.BackColor = Color.FromArgb(5, 139, 140);
                    button20.BackColor = Color.FromArgb(5, 139, 140);
                    ForeColor = Color.FromArgb(182, 53, 48);
                    button21.BackColor = Color.FromArgb(0, 134, 135);
                    BackColor = Color.FromArgb(0, 134, 135);
                    cnt++;
                    break;
                case 4:
                    button1.BackColor = Color.FromArgb(0, 0, 63);
                    button2.BackColor = Color.FromArgb(0, 0, 63);
                    button3.BackColor = Color.FromArgb(0, 0, 63);
                    button4.BackColor = Color.FromArgb(0, 0, 63);
                    button5.BackColor = Color.FromArgb(0, 0, 63);
                    button6.BackColor = Color.FromArgb(0, 0, 63);
                    button7.BackColor = Color.FromArgb(0, 0, 63);
                    button8.BackColor = Color.FromArgb(0, 0, 63);
                    button9.BackColor = Color.FromArgb(0, 0, 63);
                    button10.BackColor = Color.FromArgb(0, 0, 63);
                    button11.BackColor = Color.FromArgb(0, 0, 63);
                    button12.BackColor = Color.FromArgb(0, 0, 63);
                    button13.BackColor = Color.FromArgb(0, 0, 63);
                    button14.BackColor = Color.FromArgb(0, 0, 63);
                    button15.BackColor = Color.FromArgb(0, 0, 63);
                    button16.BackColor = Color.FromArgb(0, 0, 63);
                    button17.BackColor = Color.FromArgb(0, 0, 63);
                    button18.BackColor = Color.FromArgb(0, 0, 63);
                    button19.BackColor = Color.FromArgb(0, 0, 63);
                    button20.BackColor = Color.FromArgb(0, 0, 63);
                    ForeColor = Color.White;
                    button21.BackColor = Color.FromArgb(0, 0, 40);
                    BackColor = Color.FromArgb(0, 0, 40);
                    cnt++;
                    break;
                case 5:
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button9.BackColor = Color.White;
                    button10.BackColor = Color.White;
                    button11.BackColor = Color.White;
                    button12.BackColor = Color.White; 
                    button13.BackColor = Color.White;
                    button14.BackColor = Color.White;
                    button15.BackColor = Color.White;
                    button16.BackColor = Color.White;
                    button17.BackColor = Color.White;
                    button18.BackColor = Color.White;
                    button19.BackColor = Color.White;
                    button20.BackColor = Color.White;
                    button21.BackColor = Color.White;
                    BackColor = Color.White;
                    ForeColor = Color.Black;
                    cnt = 1;
                    break;
            }
        }
        #endregion Addon
    }
}
