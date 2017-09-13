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
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //int inputTwo = Convert.ToInt32(textBox2.Text);
            try
            {   Double inputOne = Convert.ToDouble(textBox1.Text);

                if (comboBox1.Text == "Feet")
                {
                    if (comboBox2.Text == "Feet")
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    if (comboBox2.Text == "Inches")
                    {
                        double outputOne = inputOne * 12;
                        textBox2.Text = Convert.ToString(outputOne);
                    }
                    if (comboBox2.Text == "cm")
                    {
                        double outputTwo = inputOne * 30.48;
                        textBox2.Text = Convert.ToString(outputTwo);
                    }
                }
                if (comboBox1.Text == "Inches")
                {
                    if (comboBox2.Text == "Inches")
                    {
                        textBox2.Text = textBox1.Text;
                    }
                    else if (comboBox2.Text == "Feet")
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
            catch (System.FormatException)
            {
                 textBox1.Text = "Numbers Only";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double temp = Convert.ToInt32(textBox4.Text);
                {
                    if (comboBox4.Text == "F°")
                    {
                        if (comboBox3.Text == "F°")
                        {
                            textBox3.Text = textBox4.Text;
                        }
                        if (comboBox3.Text == "C°")
                        {
                            double temp1 = (temp - 32) * 5 / 9;
                            textBox3.Text = Convert.ToString(temp1);
                        }
                        if (comboBox3.Text == "K°")
                        {
                            double temp2 = .55 * (temp - 32) + 273;
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
                        if (comboBox3.Text == "F°")
                        {
                            double temp2 = temp - 273.15 * 1.8 + 32;
                            textBox3.Text = Convert.ToString(temp2);
                        }
                    }
                }
                                          
            }
            catch (System.FormatException)
            {
                textBox4.Text = "Numbers Only";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int year = 31104000;
                int month = 2592000;
                int week = 604800;
                int day = 86400;
                int hour = 3600;
                int min = 60;
                int sec = 1;

                int input = Convert.ToInt32(textBox5.Text);

                int year2 = year * input; ;
                int month2 = month * input;
                int week2 = week * input;
                int day2 = day * input;
                int hour2 = hour * input;
                int min2 = min * input;
                int sec2 = sec * input;

                if (comboBox5.Text == "Year")
                {
                    if (comboBox6.Text == "Year")
                    {
                        textBox6.Text = textBox5.Text;
                    }
                    if (comboBox6.Text == "Month")
                    {
                        textBox6.Text = Convert.ToString(year2 / month);
                    }
                    if (comboBox6.Text == "Week")
                    {
                        textBox6.Text = Convert.ToString(year2 / week);
                    }
                    if (comboBox6.Text == "Day")
                    {
                        textBox6.Text = Convert.ToString(year2 / day);
                    }
                    if (comboBox6.Text == "Hour")
                    {
                        textBox6.Text = Convert.ToString(year2 / hour);
                    }
                    if (comboBox6.Text == "Min")
                    {
                        textBox6.Text = Convert.ToString(year2 / min);
                    }
                    if (comboBox6.Text == "Sec")
                    {
                        textBox6.Text = Convert.ToString(year2 / sec);
                    }

                }
                if (comboBox5.Text == "Month")
                {
                    if (comboBox6.Text == "Month")
                    {
                        textBox6.Text = textBox5.Text;
                    }
                    if (comboBox6.Text == "Year")
                    {
                        textBox6.Text = Convert.ToString(month2 / year);
                    }
                    if (comboBox6.Text == "Week")
                    {
                        textBox6.Text = Convert.ToString(month2 / week);
                    }
                    if (comboBox6.Text == "Day")
                    {
                        textBox6.Text = Convert.ToString(month2 / day);
                    }
                    if (comboBox6.Text == "Hour")
                    {
                        textBox6.Text = Convert.ToString(month2 / hour);
                    }
                    if (comboBox6.Text == "Min")
                    {
                        textBox6.Text = Convert.ToString(month2 / min);
                    }
                    if (comboBox6.Text == "Sec")
                    {
                        textBox6.Text = Convert.ToString(month2 / sec);
                    }
                }
                if (comboBox5.Text == "Week")
                {
                    if (comboBox6.Text == "Week")
                    {
                        textBox6.Text = textBox5.Text;
                    }
                    if (comboBox6.Text == "Year")
                    {
                        textBox6.Text = Convert.ToString(week2 / year);
                    }
                    if (comboBox6.Text == "Month")
                    {
                        textBox6.Text = Convert.ToString(week2 / month);
                    }
                    if (comboBox6.Text == "Day")
                    {
                        textBox6.Text = Convert.ToString(week2 / day);
                    }
                    if (comboBox6.Text == "Hour")
                    {
                        textBox6.Text = Convert.ToString(week2 / hour);
                    }
                    if (comboBox6.Text == "Min")
                    {
                        textBox6.Text = Convert.ToString(week2 / min);
                    }
                    if (comboBox6.Text == "Sec")
                    {
                        textBox6.Text = Convert.ToString(week2 / sec);
                    }
                }
                if (comboBox5.Text == "Day")
                {
                    if (comboBox6.Text == "Day")
                    {
                        textBox6.Text = textBox5.Text;
                    }
                    if (comboBox6.Text == "Year")
                    {
                        textBox6.Text = Convert.ToString(day2 / year);
                    }
                    if (comboBox6.Text == "Month")
                    {
                        textBox6.Text = Convert.ToString(day2 / month);
                    }
                    if (comboBox6.Text == "Week")
                    {
                        textBox6.Text = Convert.ToString(day2 / week);
                    }
                    if (comboBox6.Text == "Hour")
                    {
                        textBox6.Text = Convert.ToString(day2 / hour);
                    }
                    if (comboBox6.Text == "Min")
                    {
                        textBox6.Text = Convert.ToString(day2 / min);
                    }
                    if (comboBox6.Text == "Sec")
                    {
                        textBox6.Text = Convert.ToString(day2 / sec);
                    }
                }
                if (comboBox5.Text == "Hour")
                {
                    if (comboBox6.Text == "Hour")
                    {
                        textBox6.Text = textBox5.Text;
                    }
                    if (comboBox6.Text == "Year")
                    {
                        textBox6.Text = Convert.ToString(hour2 / year);
                    }
                    if (comboBox6.Text == "Month")
                    {
                        textBox6.Text = Convert.ToString(hour2 / month);
                    }
                    if (comboBox6.Text == "Week")
                    {
                        textBox6.Text = Convert.ToString(hour2 / week);
                    }
                    if (comboBox6.Text == "Day")
                    {
                        textBox6.Text = Convert.ToString(hour2 / day);
                    }
                    if (comboBox6.Text == "Min")
                    {
                        textBox6.Text = Convert.ToString(hour2 / min);
                    }
                    if (comboBox6.Text == "Sec")
                    {
                        textBox6.Text = Convert.ToString(hour2 / sec);
                    }
                }
                //if (comboBox5.Text == "Min")
                {

                }
                //if (comboBox5.Text == "Sec")
                {

                }
            }
            catch (System.FormatException )
            {
                textBox5.Text = " Numbers Only";
            }
                                 
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //label10.Text = Convert.ToString(DateTime.Now.TimeOfDay);

            DateTime dateTime = DateTime.Now;
            this.label10.Text = dateTime.ToString("MMM-dd-yy hh:mm:ss tt");

        }
    }
}
