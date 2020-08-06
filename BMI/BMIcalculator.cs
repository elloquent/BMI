using System;
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

        private bool _weightIsSelected;
        private bool _backspace;

        
        public BMIcalculator()
        {
            InitializeComponent();
        }

      

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            this._weightIsSelected = false;
            this._backspace = false;
           
        }

        private void BMIButton_Click(object sender, EventArgs e)
        {
      
            Button bmiButton = sender as Button;


            if (this._weightIsSelected)
            {
               
               weighttextBox.Text += bmiButton.Text;
            }
            if (!this._weightIsSelected)
            {
              
            heighttextBox.Text += bmiButton.Text;
            }
          


            if (bmiButton.Text.Length >7)
            {
                bmiButton.Font = new Font("Microsoft Sans Serif", 14.0f);
            }
            else
            {
                bmiButton.Font = new Font("Microsoft Sans Serif", 20.0f);
            }

            if (bmiButton.Tag.ToString() == "operator")
            {

                if(bmiButton.Name == "clearbutton")
                {
                    weighttextBox.Text = "";
                    heighttextBox.Text = "";
                    resulttextBox.Text = "";
                    poundButton.Checked = false;
                    kiloButton.Checked = false;

                }
                if (bmiButton.Name == "backbutton")
                {
                    if (_backspace)
                    {
                        try
                        {
                            weighttextBox.Text = weighttextBox.Text.Remove(weighttextBox.Text.Length - 1);
                        }
                        catch { }
                    }
                    if (!_backspace)
                    {

                        try
                        {
                            heighttextBox.Text = heighttextBox.Text.Substring(0, heighttextBox.Text.Length - 1);
                        }
                        catch { }

                    }
                }

                }
           

        }

        private void calulatebutton_Click(object sender, EventArgs e)
        {
            if (poundButton.Checked == true)
            {
                if (weighttextBox.Text =="")    //check to see if the text is empty
                {
                    errorProvider1.SetError(weighttextBox, "Please enter a value");  //display the following message
                    weighttextBox.Focus(); //refocuses cursor
                }
                else if (heighttextBox.Text =="")    //check to see if the text is empty
                {
                    errorProvider1.SetError(heighttextBox, "Please enter a value");  //display the following message
                    heighttextBox.Focus(); //refocuses cursor
                }
                else
                {
                    try
                    {
                        _weightvalue = double.Parse(weighttextBox.Text);
                     
                    }
                    catch
                    {
                        MessageBox.Show("you must input a number and not a letter");
                        weighttextBox.Text = "";
                        weighttextBox.Focus();
                    }
                    try
                    {
                        _heightvalue = double.Parse(heighttextBox.Text);
                        
                    }
                    catch
                    {

                        MessageBox.Show("you must input a number and not a letter");
                        heighttextBox.Text = "";
                        heighttextBox.Focus();
                    }
                    
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
                if (weighttextBox.Text == "")    //check to see if the text is empty
                {
                    errorProvider1.SetError(weighttextBox, "Please enter a value");  //display the following message
                    weighttextBox.Focus(); //refocuses cursor
                }
                else if (heighttextBox.Text == "")    //check to see if the text is empty
                {
                    errorProvider1.SetError(heighttextBox, "Please enter a value");  //display the following message
                    heighttextBox.Focus(); //refocuses cursor
                }
                else
                {
                    try
                    {
                        _weightvalue = double.Parse(weighttextBox.Text);

                    }
                    catch
                    {
                        MessageBox.Show("you must input a number and not a letter");
                        weighttextBox.Text = "";
                        weighttextBox.Focus();
                    }
                    try
                    {
                        _heightvalue = double.Parse(heighttextBox.Text);

                    }
                    catch
                    {

                        MessageBox.Show("you must input a number and not a letter");
                        heighttextBox.Text = "";
                        heighttextBox.Focus();
                    }
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

        private void weighttextBox_Click(object sender, EventArgs e)
        {
            this._weightIsSelected = true;
            this._backspace = true;
        }

        private void heighttextBox_Click(object sender, EventArgs e)
        {
            this._weightIsSelected = false;
            this._backspace = false;
        }
    }
}
