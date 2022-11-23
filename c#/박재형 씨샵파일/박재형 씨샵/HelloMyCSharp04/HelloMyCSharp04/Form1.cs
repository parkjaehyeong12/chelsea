using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 10;
            int c = 0;
            c = a + b;
            c = c - a;
            
            Console.WriteLine("안녕하세요");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.AutoSize = true;
            label1.Location = new Point(54,330);
            label1.MaximumSize = new Size(600,0);
            string a = "";
            for (char i = '가'; i <= '라'; i++)
            {       
                a += i;
            }
            label1.Text = a;

            /*Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(0, 400);
           
            for (char i = '가'; i <= '힣'; i++)
            {
                label.Text += i;
                if (i % 100 == 0)
                    label.Text += "\n";
            }
            Controls.Add(label);*/


        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
