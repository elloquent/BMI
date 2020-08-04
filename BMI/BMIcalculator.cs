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

                }
            }
           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void heighttextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void weighttextBox_Click(object sender, EventArgs e)
        {
           
        }

        private void heighttextBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
