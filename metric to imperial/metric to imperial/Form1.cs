using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metric_to_imperial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double inputOne = Convert.ToDouble(textBox1.Text);
            //int inputTwo = Convert.ToInt32(textBox2.Text);

            if (comboBox1.Text == "Feet")
            {
                if (comboBox2.Text == "Feet")
                {
                    textBox2.Text = textBox1.Text;
                }
                else if (comboBox2.Text == "Inches")
                {
                    double  outputOne = inputOne * 12;
                    textBox2.Text = Convert.ToString(outputOne);
                }
                else if (comboBox2.Text == "cm")
                {
                    double  outputTwo = inputOne * 30.48;
                    textBox2.Text = Convert.ToString(outputTwo);
                }
            }
            if (comboBox1.Text == "Inches")
            {
                if (comboBox2.Text == "Inches")
                {
                    textBox2.Text = textBox1.Text;
                }
                else if(comboBox2.Text == "Feet")
                {
                    double outputOne = inputOne / 12;
                    textBox2.Text = Convert.ToString(outputOne);
                }
                else if (comboBox2.Text == "cm")
                {
                    double outputTwo = inputOne * 2.54;
                    textBox2.Text = Convert.ToString(outputTwo);

                }    
            }
            if (comboBox1.Text == "cm")
            {
                if (comboBox2.Text == "cm")
                {
                    textBox2.Text = textBox1.Text;
                }
                if (comboBox1.Text == "Feet")
                {
                    double outputOne = inputOne * 0.03;
                    textBox2.Text = Convert.ToString(outputOne);
                }
                if (comboBox1.Text == "Inches")
                {
                    double outputTwo = inputOne * 0.39;
                    textBox2.Text = Convert.ToString(outputTwo);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToInt32(textBox4.Text);
            {
                if (comboBox4.Text == "F°")
                {
                    if (comboBox3.Text == "F°")
                    {
                        textBox3.Text = textBox4.Text;
                    }
                    if (comboBox3 .Text == "C°")
                    {
                        double temp1 = temp * 1.8 + 32;
                        textBox3.Text = Convert.ToString(temp1);
                    }
                    if (comboBox3 .Text == "K°")
                    {
                        double temp2 = .55 * ( temp - 32 ) + 273;
                        textBox3.Text = Convert.ToString(temp2);
                    }
                }

                if (comboBox4.Text == "C°")
                {
                    if (comboBox3.Text == "C°")
                    {
                        textBox3.Text = textBox4.Text;
                    }
                    if (comboBox3.Text == "F°")
                    {
                        double temp1 = temp * 1.8 + 32;
                        textBox3.Text = Convert.ToString(temp1);
                    }
                    if (comboBox3.Text == "K°")
                    {
                        double temp2 = temp + 273.15;
                        textBox3.Text = Convert.ToString(temp2);
                    }
                }

                if (comboBox4.Text == "K°")
                {
                    if (comboBox3.Text == "K°")
                    {
                        textBox3.Text = textBox4.Text;
                    }
                    if (comboBox3.Text == "C°")
                    {
                        double temp1 = temp - 273.15;
                        textBox3.Text = Convert.ToString(temp1);
                    }
                    if (comboBox3. Text == "F°")
                    {
                        double temp2 = temp - 273.15 * 1.8 + 32;
                        textBox3.Text = Convert.ToString(temp2);
                    }
                }
               
            }
        }
    }
}
