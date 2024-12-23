using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        
        }

        private void btn_Decrements(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0")) 
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text.Insert(0, "-");//Substring
        
        }

        private void btn_0(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
            
        }

        private void btn_Point(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0"))
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void btn1(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0"))
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void btn2(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0"))
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void btn3(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0"))
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void btn4(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0"))
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void btn5(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0"))
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void btn6(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0"))
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void btn7(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0"))
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void btn8(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0"))
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void btn9(object sender, EventArgs e)
        {

            if (textBox1.Text.Equals("0"))
            {

                textBox1.Clear();

            }

            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;

        }

        private void btnClear(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("C/F/K");
            comboBox1.Items.Add("Celsius");
            comboBox1.Items.Add("Farenheit");
            comboBox1.Items.Add("Kelvin");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
        {

            double ctemp;
            double ftemp;
            double ktemp;

            try
            {

                ctemp = double.Parse(textBox1.Text);

                if (double.TryParse(textBox1.Text, out double temp))
                {
                    
                    if (comboBox1.Text.Equals("Celsius"))
                    {

                        ftemp = (temp * 9 / 5) + 32;
                        ktemp = temp + 273.15;
                        textBox2.Text = $"{ftemp:F2} °F  \n{ktemp:F2} K";

                    }
                    else if (comboBox1.Text.Equals("Farenheit"))
                    {

                        ctemp = (temp - 32) * 5 / 9;
                        ktemp = (temp + 459.67) * 5 / 9;
                        textBox2.Text = $"{ctemp:F2} °C   \n{ktemp:F2} K";

                    }
                    else if (comboBox1.Text.Equals("Kelvin"))
                    {

                        ctemp = temp - 273.15;
                        ftemp = (temp * 9 / 5) - 459.67;
                        textBox2.Text = $"{ctemp:F2} °C   \n{ftemp:F2} °F";

                    }
                    else //In case user won't choose combobox will automatically show the temperature base on the default field which is 0
                    {

                        ctemp = (temp - 32) * 5 / 9;
                        ftemp = (temp * 9 / 5) + 32;
                        ktemp = temp + 273.15;
                        textBox2.Text = $"{ctemp:F2} °C,  \n{ftemp:F2} °F,  {ktemp:F2} K";

                    }

                }
            
            }
            catch (FormatException)
            {

                textBox2.Text = $"Please input a number thanks";
            
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Equals("Celsius") || comboBox1.Equals("Farenheit") || comboBox1.Equals("Kelvin"))
            {

                textBox1.Focus();

            }

        }

        private void btnX(object sender, EventArgs e)
        {

            if(textBox1.Text.Length > 0) 
            {

                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

            }
            
        }

        private void equals_Click(object sender, EventArgs e)
        {

            double ctemp;
            double ftemp;
            double ktemp;

            try
            {

                ctemp = double.Parse(textBox1.Text);

                if (double.TryParse(textBox1.Text, out double temp))
                {

                    if (comboBox1.Text.Equals("Celsius"))
                    {

                        ftemp = (temp * 9 / 5) + 32;
                        ktemp = temp + 273.15;
                        textBox2.Text = $"{ftemp:F2} °F  \n{ktemp:F2} K";

                    }
                    else if (comboBox1.Text.Equals("Farenheit"))
                    {

                        ctemp = (temp - 32) * 5 / 9;
                        ktemp = (temp + 459.67) * 5 / 9;
                        textBox2.Text = $"{ctemp:F2} °C   \n{ktemp:F2} K";

                    }
                    else if (comboBox1.Text.Equals("Kelvin"))
                    {

                        ctemp = temp - 273.15;
                        ftemp = (temp * 9 / 5) - 459.67;
                        textBox2.Text = $"{ctemp:F2} °C   \n{ftemp:F2} °F";

                    }
                    else //In case user won't choose combobox will automatically show the temperature base on the default field which is 0
                    {

                        ctemp = (temp - 32) * 5 / 9;
                        ftemp = (temp * 9 / 5) + 32;
                        ktemp = temp + 273.15;
                        textBox2.Text = $"{ctemp:F2} °C,  \n{ftemp:F2} °F,  {ktemp:F2} K";

                    }

                }

            }
            catch (FormatException)
            {

                textBox2.Text = $"Please enter a number thanks";

            }

        }

    }


}
