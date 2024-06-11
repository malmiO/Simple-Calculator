using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();

        }

        double a = 0; double b = 0; int count = 0; double result;

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 6;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 0 + 0 + 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Result_txt.Text);
            Result_txt.Clear();
            count = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Result_txt.Text);
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
           
        }

        private void historyp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totaldisplayP_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Result_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(Result_txt.Text);

            if (count == 1)
            {
                result = a + b;
                Result_txt.Text = result.ToString();
            }
            else if (count == 2)
            {
                result = a - b;
                Result_txt.Text = result.ToString();
            }
            else if (count == 3)
            {
                result = a * b;
                Result_txt.Text = result.ToString();
            }
            else if (count == 4)
            {
                if(a !=0 || b!=0)
                {
                    if (a < b)
                    {
                        result = b / a;
                    }
                    else
                    {
                        result = a / b;
                    }
                }
                else 
                {
                    Result_txt.Clear();
                    MessageBox.Show("Can't Divide By Zero!");
                }
    
                Result_txt.Text = result.ToString();
            }
            else if (count == 5)
            {

                if (a < b)
                {
                    result = b % a;
                }
                else
                {
                    result = a % b;
                }
                
                Result_txt.Text = result.ToString();
            }

            else
            {
                MessageBox.Show("Error");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {

        }

        private void btn_5_Click(object sender, EventArgs e)
        {

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            Result_txt.Clear();
            a = 0;
            b = 0;
            count = 0;
        }

        private void btn_1_Click_1(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 3;
        }

        private void btn_5_Click_1(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 5;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 4;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 9;
        }

        private void btn_00_Click_2(object sender, EventArgs e)
        {
            Result_txt.Text = Result_txt.Text + 0 + 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Result_txt.Text);
            Result_txt.Clear();
            count = 1;
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Result_txt.Text);
            Result_txt.Clear();
            count = 3;
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Result_txt.Text);
            Result_txt.Clear();
            count = 4;
        }

        private void btn_percentage_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(Result_txt.Text);
            Result_txt.Clear();
            count = 5;
        }
    }
}
