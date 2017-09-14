using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
Author:         Caio Marteli
Creation Date:  06/09/2017
Version:        1.0
*/

namespace Calculator
{
    public partial class CalculatorGUI : Form
    {
        
        public CalculatorGUI()
        {
            InitializeComponent();
            
        }
        //button clicks for numbers 0 to 9
        private void btnZero_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + btnZero.Text;
        }
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + btnOne.Text;                            
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + btnNine.Text;
        }
        //disables button after one dot press adds zero if box is empty
        private void btnDot_Click(object sender, EventArgs e)
        {
            if(!txtOutput.Text.Contains(".")) //checks if there's already a "." in the output string
            {
                if (String.IsNullOrEmpty(txtOutput.Text))
                {
                     txtOutput.Text = "0" + btnDot.Text;
                     btnDot.Enabled = false;
                }        
                else
                { 
                    txtOutput.Text = txtOutput.Text + btnDot.Text;
                    btnDot.Enabled = false;
                }                       
            }
            
        }
        //button clear click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();            
            btnDot.Enabled = true;
            doubleVariable1 = 0; 
            doubleVariable2 = 0; 

        }
        double doubleVariable1 = 0; //Variables we will be using to perform calculations
        double doubleVariable2 = 0; //Try using the built-in REFACTOR
        //these variables will be used with the equal method
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;   
        
        //button click event for addition
        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                doubleVariable1 += double.Parse(txtOutput.Text);
                txtOutput.Clear();
                plusButtonClicked = true;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
                btnDot.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
        }
        //button click for subtraction
        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                doubleVariable1 += double.Parse(txtOutput.Text);
                txtOutput.Clear();
                plusButtonClicked = false;
                minusButtonClicked = true;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
                btnDot.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
        }
        //button click event for divide
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                doubleVariable1 += double.Parse(txtOutput.Text);
                txtOutput.Clear();
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = true;
                multiplyButtonClicked = false;
                btnDot.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
        }
        //button click event for multiply
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                doubleVariable1 += double.Parse(txtOutput.Text);
                txtOutput.Clear();
                plusButtonClicked = false;
                minusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = true;
                btnDot.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
        }
        //button click event for square root
        private void btnSQRT_Click(object sender, EventArgs e)
        {
            try
            {
                doubleVariable1 += double.Parse(txtOutput.Text);
                if (doubleVariable1 >= 0)
                {
                    doubleVariable2 = Algebraic.Arithmetic.sqrt(doubleVariable1);
                    txtOutput.Text = doubleVariable2.ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtOutput.Text = "0";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
            finally
            {
                //re-enable "." button
                btnDot.Enabled = true;
            }
        }
        //button click event for cubic root
        private void btnCRT_Click(object sender, EventArgs e)
        {
            try
            {
                doubleVariable1 += double.Parse(txtOutput.Text);
                if (doubleVariable1 >= 0)
                {
                    doubleVariable2 = Algebraic.Arithmetic.cubert(doubleVariable1);
                    txtOutput.Text = doubleVariable2.ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtOutput.Text = "0";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
            finally
            {
                //re-enable "." button
                btnDot.Enabled = true;
            }
        }
        //button click event for inverse root
        private void btnInv_Click(object sender, EventArgs e)
        {
            try
            {
                doubleVariable1 += double.Parse(txtOutput.Text);
                if (doubleVariable1 >= 0)
                {
                    doubleVariable2 = Algebraic.Arithmetic.inversert(doubleVariable1);
                    txtOutput.Text = doubleVariable2.ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtOutput.Text = "0";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
            finally
            {
                //re-enable "." button
                btnDot.Enabled = true;
            }
        }
        //button click event for tangent
        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                doubleVariable1 += double.Parse(txtOutput.Text);
                if (doubleVariable1 == 90)
                {
                    MessageBox.Show("Undefined");
                }
                else if (doubleVariable1 == 180)
                {
                    txtOutput.Text = "0";
                }
                else if (doubleVariable1 >= 0 || doubleVariable1 != 90)
                {
                    doubleVariable2 = Trigonometric.Arithmetic.tangent(doubleVariable1);
                    txtOutput.Text = doubleVariable2.ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtOutput.Text = "0";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
            finally
            {
                //re-enable "." button
                btnDot.Enabled = true;
            }
        }
        //button click event for sine
        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                doubleVariable1 += double.Parse(txtOutput.Text);
                if (doubleVariable1 >= 0)
                {
                    doubleVariable2 = Trigonometric.Arithmetic.sine(doubleVariable1);
                    txtOutput.Text = doubleVariable2.ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtOutput.Text = "0";
                }                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
            finally
            {
                //re-enable "." button
                btnDot.Enabled = true;
            }
        }
        //button click event for cosine
        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                doubleVariable1 += double.Parse(txtOutput.Text);
                if (doubleVariable1 >= 0)
                {
                    doubleVariable2 = Trigonometric.Arithmetic.cosine(doubleVariable1);
                    txtOutput.Text = doubleVariable2.ToString();
                }
                else
                {
                    MessageBox.Show("Number must be positive", "Error Message");
                    txtOutput.Text = "0";
                }                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
            finally
            {
                //re-enable "." button
                btnDot.Enabled = true;
            }
        }
        //button click event for equal implements basicmath library
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (plusButtonClicked == true)
                {
                    doubleVariable2 = double.Parse(txtOutput.Text);
                    doubleVariable2 = BasicMath.Arithmetic.Add(doubleVariable1, doubleVariable2);
                }
                else if (minusButtonClicked == true)
                {
                    doubleVariable2 = double.Parse(txtOutput.Text);
                    doubleVariable2 = BasicMath.Arithmetic.Sub(doubleVariable1, doubleVariable2);
                }
                else if (divideButtonClicked == true)
                {
                    doubleVariable2 = double.Parse(txtOutput.Text);
                    doubleVariable2 = BasicMath.Arithmetic.Div(doubleVariable1, doubleVariable2);
                }
                else if (multiplyButtonClicked == true)
                {
                    doubleVariable2 = double.Parse(txtOutput.Text);
                    doubleVariable2 = BasicMath.Arithmetic.Mult(doubleVariable1, doubleVariable2);
                }
                txtOutput.Text = doubleVariable2.ToString();
                doubleVariable1 = 0;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please Enter a Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message :" + ex);
            }
            finally
            {
                //re-enable "." button
                btnDot.Enabled = true;
            }
        }

        
    }
}
