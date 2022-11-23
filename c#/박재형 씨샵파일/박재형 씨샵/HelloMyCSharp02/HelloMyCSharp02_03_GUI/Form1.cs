using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp02_03_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double info2 = (double)Convert.ToInt32(textBox1.Text)+ (double)Convert.ToInt32(textBox2.Text);

            int info = Convert.ToInt32(textBox1.Text)+ Convert.ToInt32(textBox2.Text);
            MessageBox.Show(info.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int info = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
            MessageBox.Show(info.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int info = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
            MessageBox.Show(info.ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int info = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
            MessageBox.Show(info.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int info = Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text);
            MessageBox.Show(info.ToString());

        }
    }
}
