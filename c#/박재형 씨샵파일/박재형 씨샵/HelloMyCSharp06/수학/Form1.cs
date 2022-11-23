using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 수학
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMath math = new MyMath();
            label1.Text =
            (math.Power(int.Parse(textBox1.Text))).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyMath math = new MyMath();
            label2.Text =
               math.Multi(int.Parse(textBox2.Text),int.Parse(textBox3.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyMath math = new MyMath();
            label3.Text =
               math.Power(int.Parse(textBox4.Text), int.Parse(textBox5.Text)).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
