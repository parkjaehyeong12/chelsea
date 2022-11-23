using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 연습1
{
    public partial class Form1 : Form
    {
        public List<string> list = new List<string>();
        Label label = new Label();//쓸거
        Label label2 = new Label();//랜덤
        static int a = 0; //아직 한번도 안 누름
        public Form1()
        {
            InitializeComponent();
            label.AutoSize = true;
            label.Location = new Point(30, 250);
            label.Text = "";
            Controls.Add(label);

            label2.AutoSize = true;
            label2.Location=new Point(30, 150);
            label2.Text = "";
            Controls.Add(label2);

                Random rand = new Random();
                label2.Text = rand.Next(100) + "";
               
            
        }



        private void button1_Click(object sender, EventArgs e)
        {

            list.Add(label2.Text);
            label.Text = "";
            foreach (var item in list)
            {
                label.Text += item + " ";
            }
            a = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* list.Remove(label2.Text);
             label.Text = "";
             foreach (var item in list)
             {
                 label.Text += item + " ";
             }*/
            if (a == -1)
            {
                Random rand = new Random();
                label2.Text = rand.Next(100) + "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
