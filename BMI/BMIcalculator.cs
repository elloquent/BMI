﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class BMIcalculator : Form
    {
        private double _weightvalue;
        private double _heightvalue;
        private double _result;

        
        public BMIcalculator()
        {
            InitializeComponent();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BMIButton_Click(object sender, EventArgs e)
        {
      
            Button bmibotton = sender as Button;
            if (heighttextBox.Focus())
            {
             
                heighttextBox.Text += bmibotton.Text;
                
            }
            else if (weighttextBox.Focus())
            {

              
                weighttextBox.Text += bmibotton.Text;
               
            }
            if (bmibotton.Text.Length >7)
            {
                bmibotton.Font = new Font("Microsoft Sans Serif", 14.0f);
            }
            else
            {
                bmibotton.Font = new Font("Microsoft Sans Serif", 20.0f);
            }

            if (bmibotton.Tag.ToString() == "operator")
            {

                if(bmibotton.Name == "clearbutton")
                {
                    weighttextBox.Text = "";
                    heighttextBox.Text = "";
                    resulttextBox.Text = "";
                    poundButton.Checked = false;
                    kiloButton.Checked = false;

                }
               
            }
           

        }

        private void calulatebutton_Click(object sender, EventArgs e)
        {
            if (poundButton.Checked == true)
            {
                if (string.IsNullOrEmpty(weighttextBox.Text))    //check to see if the text is empty
                {
                    errorProvider1.SetError(weighttextBox, "Please enter a value");  //display the following message
                    weighttextBox.Focus(); //refocuses cursor
                }
                else if (string.IsNullOrEmpty(heighttextBox.Text))    //check to see if the text is empty
                {
                    errorProvider1.SetError(heighttextBox, "Please enter a value");  //display the following message
                    heighttextBox.Focus(); //refocuses cursor
                }
                else
                {
                    _weightvalue = double.Parse(weighttextBox.Text);
                    _heightvalue = double.Parse(heighttextBox.Text);
                    
                    _result = (_weightvalue * 703) / (_heightvalue * _heightvalue);
                    resulttextBox.Text = _result.ToString();
                    if (_result < 18.5)
                    {
                        MessageBox.Show("You are Underweight");
                    }
                    else if (_result >= 18.5 || _result <= 24.9)
                    {
                        MessageBox.Show("Your weight is normal");
                    }
                    else if (_result >= 25 || _result <= 29.9)
                    {
                        MessageBox.Show("You are Overweight");
                    }
                    else
                    {
                        MessageBox.Show("You are Obese");
                    }


                }
            }
            else if (kiloButton.Checked == true)
            {
                if (string.IsNullOrEmpty(weighttextBox.Text))    //check to see if the text is empty
                {
                    errorProvider1.SetError(weighttextBox, "Please enter a value");  //display the following message
                    weighttextBox.Focus(); //refocuses cursor
                }
                else if (string.IsNullOrEmpty(heighttextBox.Text))    //check to see if the text is empty
                {
                    errorProvider1.SetError(heighttextBox, "Please enter a value");  //display the following message
                    heighttextBox.Focus(); //refocuses cursor
                }
                else
                {
                    _weightvalue = Convert.ToDouble(weighttextBox.Text);
                    _heightvalue = Convert.ToDouble(heighttextBox.Text);
                    _result = _weightvalue / (_heightvalue * _heightvalue);
                    resulttextBox.Text = _result.ToString();
                    if (_result < 18.5)
                    {
                        MessageBox.Show("You are Underweight");
                    }
                    else if (_result >= 18.5 || _result <= 24.9)
                    {
                        MessageBox.Show("Your weight is normal");
                    }
                    else if (_result >= 25 || _result <= 29.9)
                    {
                        MessageBox.Show("You are Overweight");
                    }
                    else
                    {
                        MessageBox.Show("You are Obese");
                    }
                }
            }
            else if (poundButton.Checked == false && kiloButton.Checked == false)
            {
                MessageBox.Show("you must select a measurement !! ");

            }
            
        }
    }
}
