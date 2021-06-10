using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num, ans;
        int count;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(Screen.Text, Screen.Font);
            Screen.Width = size.Width;
            Screen.Height = size.Height;
            Screen.ReadOnly = true;
           
        }
        private void Sevenbtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || label1.Text == "0")
            {
                Screen.Clear();
            }

            label1.Text = label1.Text + "7";
            Screen.Text = Screen.Text + 7;
        }

        private void Eightbtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || label1.Text == "0")
            {
                Screen.Clear();
            }
            label1.Text = label1.Text + "8";
            Screen.Text = Screen.Text + 8;
        }

        private void Ninebtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || label1.Text == "0")
            {
                Screen.Clear();
            }
            label1.Text = label1.Text + "9";
            Screen.Text = Screen.Text + 9;
        }

        private void Fourbtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || label1.Text == "0")
            {
                Screen.Clear();
            }
            label1.Text = label1.Text + "4";
            Screen.Text = Screen.Text + 4;
        }

        private void Fivebtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || label1.Text == "0")
            {
                Screen.Clear();
            }
            label1.Text = label1.Text + "5";
            Screen.Text = Screen.Text + 5;
        }

        private void Sixbtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || label1.Text == "0")
            {
                Screen.Clear();
            }
            label1.Text = label1.Text + "6";
            Screen.Text = Screen.Text + 6;
        }

        private void Onebtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || label1.Text == "0")
            {
                Screen.Clear();
            }
            label1.Text = label1.Text + "1";
            Screen.Text = Screen.Text + 1;
        }

        private void Twobtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || label1.Text == "0")
            {
                Screen.Clear();
            }
            label1.Text = label1.Text + "2";
            Screen.Text = Screen.Text + 2;
        }

        private void Threebtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || label1.Text == "0")
            {
                Screen.Clear();
            }
            label1.Text = label1.Text + "3";
            Screen.Text = Screen.Text + 3;
        }

        private void Zerobtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0" || label1.Text == "0")
            {
                Screen.Clear();
            }
            label1.Text = label1.Text + "0";
            Screen.Text = Screen.Text + 0;
        }

        private void Dotbtn_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Clear();
            }
            label1.Text = label1.Text + ".";
            Screen.Text = Screen.Text + ".";
        }

        private void ACbtn_Click(object sender, EventArgs e)
        {  
            Ninebtn.Enabled = true;
            Eightbtn.Enabled = true;
            Sevenbtn.Enabled = true;
            Sixbtn.Enabled = true;
            Fivebtn.Enabled = true;
            Fourbtn.Enabled = true;
            Threebtn.Enabled = true;
            Twobtn.Enabled = true;
            Onebtn.Enabled = true;
            Zerobtn.Enabled = true;
            Dotbtn.Enabled = true;
            Screen.Enabled = true;

            Minusbtn.Enabled = true;
            Modulusbtn.Enabled = true;
            Clearbtn.Enabled = true;
            Divisionbtn.Enabled = true;
            Multiplicationbtn.Enabled = true;
            Additionbtn.Enabled = true;
            Dotbtn.Enabled = true;
            Equaltobtn.Enabled = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ninebtn.Enabled = false;
            Eightbtn.Enabled = false;
            Sevenbtn.Enabled = false;
            Sixbtn.Enabled = false;
            Fivebtn.Enabled = false;
            Fourbtn.Enabled = false;
            Threebtn.Enabled = false;
            Twobtn.Enabled = false;
            Onebtn.Enabled = false;
            Zerobtn.Enabled = false;
            Dotbtn.Enabled = false;
            Screen.Enabled = false;


            Minusbtn.Enabled = false;
            Modulusbtn.Enabled = false;
            Clearbtn.Enabled = false;
            Divisionbtn.Enabled = false;
            Multiplicationbtn.Enabled = false;
            Additionbtn.Enabled = false;
            Dotbtn.Enabled = false;
            Equaltobtn.Enabled = false;
            

        }

        private void Plusorminusbtn_Click(object sender, EventArgs e)
        {
            Screen.Clear();
            Screen.Text = "0";
            num = 0;
            ans = 0;
            count = 0;
            label1.Text = "";
        }

        private void Modulusbtn_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Screen.Text + "%";
                num = Double.Parse(Screen.Text);
                Screen.Clear();
                Screen.Focus();
                count = 5;
            }
            catch (Exception)
            {
                Screen.Clear();
            }
        }

        private void Divisionbtn_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Screen.Text + "/";
                num = Double.Parse(Screen.Text);
                Screen.Clear();
                Screen.Focus();
                count = 3;
                
            }
            catch (Exception)
            {
                Screen.Clear();
            }
        }

        private void Additionbtn_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Screen.Text + "+";
                num = Double.Parse(Screen.Text);
                Screen.Clear();
                Screen.Focus();
                count = 1;
            }
            catch (Exception)
            {
                Screen.Clear();
            }
        }

        private void Equaltobtn_Click(object sender, EventArgs e)
        {
            try {
                switch (count)
                {
                    case 1:

                        ans = num + double.Parse(Screen.Text);
                        Screen.Text = ans.ToString();
                        label1.Text = ans.ToString();
                        break;
                    case 2:
                        ans = num - double.Parse(Screen.Text);
                        //label1.Text = label1.Text + "=";
                        Screen.Text = ans.ToString();
                        label1.Text = ans.ToString();
                        break;
                    case 3:
                        ans = num / double.Parse(Screen.Text);
                        //label1.Text = label1.Text + "=";
                        Screen.Text = ans.ToString();
                        label1.Text = ans.ToString();
                        break;
                    case 4:
                        ans = num * double.Parse(Screen.Text);
                        //label1.Text = label1.Text + "=";
                        Screen.Text = ans.ToString();
                        label1.Text = ans.ToString();
                        break;
                    case 5:
                        ans = num % double.Parse(Screen.Text);
                        //label1.Text = label1.Text+"=";
                        Screen.Text = ans.ToString();
                        label1.Text = ans.ToString();
                        break;
                    default:
                        Screen.Text = "Invalid Input !!";
                        break;
                }
                
            }
            catch (Exception)
            {
                label1.Text = "";
                Screen.Text = "Invalid Input !!";
            }
        }

        private void Minusbtn_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = label1.Text + "-";
                num = Double.Parse(Screen.Text);
                Screen.Clear();
                Screen.Focus();
                count = 2;
            }
            catch (Exception)
            {
                Screen.Clear();
            }
        }

        private void Multiplicationbtn_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = label1.Text + "x";
                num = Double.Parse(Screen.Text);
                Screen.Clear();
                Screen.Focus();
                count = 4;
            }
            catch (Exception)
            {
                Screen.Clear();
                
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
