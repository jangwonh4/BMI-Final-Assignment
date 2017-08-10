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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {

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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
