using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCalc_26112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if (int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2)) 
            {
                int result = num1 + num2;
                resultLabel.Text = "Result: " + result.ToString();
            }
            else
            { MessageBox.Show("Please enter valid numbers in both fields");
            }
        }
    }
}
