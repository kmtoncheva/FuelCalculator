using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_gorivo_15._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                double l1 = (a * b) / 100;
                double s1 = c * l1;
                double l2 = (2 * a * b) / 100;
                double s2 = c * l2;
                if (checkBox1.Checked)
                {
                    l4.Text = l2.ToString() + " liters";
                    l5.Text = s2.ToString() + " $";                   
                }
                else
                {
                    l4.Text = l1.ToString() + " liters";
                    l5.Text = s1.ToString() + " $";                   
                }
            }
            catch (FormatException)
            {
                textBox1.Text = null;
                textBox2.Text = null;
                textBox3.Text = null;
                MessageBox.Show("Invaild input!");
                checkBox1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            l4.Text = "0 $";
            l5.Text = "0 liters";
            checkBox1.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
