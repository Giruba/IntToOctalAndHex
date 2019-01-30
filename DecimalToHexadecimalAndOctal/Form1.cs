using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecimalToHexadecimalAndOctal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            try
            {
                num1 = int.Parse(textBox1.Text);
            }
            catch (Exception exception) {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    num1 = 0;
                }
                else {
                    MessageBox.Show(exception.Message);
                }
            }
            textBox3.Text = num1.ToString("X");
            try
            {
                textBox2.Text = Convert.ToInt32(num1.ToString(), 8).ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
