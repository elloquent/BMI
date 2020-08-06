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
   // Author Name Richard Elridge
   // Student number 301107264
   // modify 06/08/2020
   // This program is built to check your Body Mass Index.It include class,methods,variables and validation techniques
    public partial class BMIcalculator : Form
    {
        //Private variables
        private double _weightvalue;
        private double _heightvalue;
        private double _result;

        private bool _weightIsSelected;
        private bool _backspace;

        // class constructor
        public BMIcalculator()
        {
            // initializing all components on the display
            InitializeComponent();
        }

      
        //Form load method get evoke when the form loads
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            //boolean variables initialise as false on start up use as criteria to type in textbox
            this._weightIsSelected = false;
            this._backspace = false;
           
        }
        // button click event method fires when user click any button on the calculator
        private void BMIButton_Click(object sender, EventArgs e)
        {
      // creating a object of any button press
            Button bmiButton = sender as Button;

            // criteria to check if the weight textbox is selected
            if (this._weightIsSelected)
            {
                try
                {
                    //concotinating the values in the textbox
                    weighttextBox.Text += bmiButton.Text;
                }
                catch { }
            }

            // criteria to check if the weight textbox is selected
            if (!this._weightIsSelected)
            {
                // general error catching
                try
                {
                    //concotinating the values in the heighttextbox
                    heighttextBox.Text += bmiButton.Text;
                }
                catch { }
            }
          

            //reducing the size of the numbers if more than 7 numbers is inputted
            if (bmiButton.Text.Length >7)
            {
                bmiButton.Font = new Font("Microsoft Sans Serif", 14.0f);
            }
            else
            {
                bmiButton.Font = new Font("Microsoft Sans Serif", 20.0f);
            }

            //checking for the tag name of the button that is clicked
            if (bmiButton.Tag.ToString() == "operator")
            {

            //clearbutton  functionality to erase the values in the textboxes             
                if(bmiButton.Name == "clearbutton")
                {
                    weighttextBox.Text = "";
                    heighttextBox.Text = "";
                    resulttextBox.Text = "";
                    poundButton.Checked = false;
                    kiloButton.Checked = false;

                }

                //Back space butto functionality to delete each number one by one
                if (bmiButton.Name == "backbutton")
                {
                    if (_backspace)
                    {
                        try
                        {
                            //Back space butto functionality to delete each number one by one for the weighttexbox
                            weighttextBox.Text = weighttextBox.Text.Remove(weighttextBox.Text.Length - 1);
                        }
                        catch { }
                    }
                    if (!_backspace)
                    {

                        try
                        {
                            //Back space butto functionality to delete each number one by one for the heighttexbox
                            heighttextBox.Text = heighttextBox.Text.Substring(0, heighttextBox.Text.Length - 1);
                        }
                        catch { }

                    }
                }

                }
           

        }

        private void calulatebutton_Click(object sender, EventArgs e)
        {
            // calculation for if the pound measurement radio button is selected
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
                    //trying for integer  input
                    try
                    {
                        _weightvalue = double.Parse(weighttextBox.Text);
                     
                    }
                    catch
                    {
                        // message to diaplay if string is inputted
                        MessageBox.Show("you must input a number and not a letter");
                        weighttextBox.Text = "";
                        weighttextBox.Focus();
                    }
                    //trying for integer  input
                    try
                    {
                        _heightvalue = double.Parse(heighttextBox.Text);
                        
                    }
                    catch
                    {
                        // message to diaplay if string is inputted
                        MessageBox.Show("you must input a number and not a letter");
                        heighttextBox.Text = "";
                        heighttextBox.Focus();
                    }
                    ////formula for calculating BMI if measurement in pound
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
            // calculation for if the pound measurement radio button is selected
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
                    //trying for integer  input
                    try
                    {
                        _weightvalue = double.Parse(weighttextBox.Text);

                    }
                    catch
                    {
                        // message to diaplay if string is inputted
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
                        // message to diaplay if string is inputted
                        MessageBox.Show("you must input a number and not a letter");
                        heighttextBox.Text = "";
                        heighttextBox.Focus();
                    }
                    ////formula for calculating BMI if measurement in pound
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
            // ensuring that one of the radio button is selected
            else if (poundButton.Checked == false && kiloButton.Checked == false)
            {
                MessageBox.Show("you must select a measurement !! ");

            }
            
        }
        //checking for clicking activity in the weight textbox
        private void weighttextBox_Click(object sender, EventArgs e)
        {
            this._weightIsSelected = true;
            this._backspace = true;
        }
        //checking for clicking activity in the height textbox
        private void heighttextBox_Click(object sender, EventArgs e)
        {
            this._weightIsSelected = false;
            this._backspace = false;
        }
    }
}
