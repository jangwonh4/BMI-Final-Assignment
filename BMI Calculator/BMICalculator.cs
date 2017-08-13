using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name : Mingi Jang
 * Student Number : 300932496
 * Modified : August, 3, 2017
 * Description : Create BMI Calculator
 * Version : 0.1 - Create UI Controls
 */

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Calculator_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                double h = Convert.ToDouble(HeightBox.Text);
                double w = Convert.ToDouble(WeightBox.Text);
                //BMI = Kg / (Hegiht(m) * Height(m))
                double bmi = w / (h * h);

                textBox1.Text = "BMI : " + Math.Round(bmi, 2).ToString();//
            }
            else if(radioButton2.Checked == true)
            {
                double h = Convert.ToDouble(HeightBox.Text);
                double w = Convert.ToDouble(WeightBox.Text);
                //BMI = Pound*703 / (Hegiht(Inch) * Height(Inch))
                double bmi = w*703 / (h * h);

                textBox1.Text = "BMI : " + Math.Round(bmi, 2).ToString();
            }
        }

        

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Text = "Weight(Pound)";
            label2.Text = "Height(Inch)";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label3.Text = "Weight(Kg)";
            label2.Text = "Height(M)";
        }
        

        

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label3.Text = "Weight(Pound)";
            label2.Text = "Height(Inch)";
        }
        //Block Letter in Text Box
        private void HeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //Edit: Alternative
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void WeightBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)Keys.D9 || e.KeyChar < (char)Keys.D0) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            //Edit: Alternative
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
