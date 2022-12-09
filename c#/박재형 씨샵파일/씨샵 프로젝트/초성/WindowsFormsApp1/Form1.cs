using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static List<string> str = new List<string>();
        public static int time = 60;
        public static int word = 0;
        public Form1()
        {
            InitializeComponent();

            label3.Text = "";
            label5.Text = word.ToString();



        }

        private void enter_key(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button3_Click(sender, e);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (str.Contains(textBox1.Text))
            {
                textBox1.Text = "";
                MessageBox.Show("중복된 단어!");
                return;
            }

            str.Add(textBox1.Text);
            label3.Text += "[" +textBox1.Text +"]" + ", ";
            textBox1.Text = "";
            time = 60;
            MessageBox.Show("성공");
            word++;
            label5.Text = word.ToString();
            textBox1.Focus();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            label2.Text = time.ToString();
            time--;

            if(time < 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("시간끝!!!!!!!!!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            str.Clear();
            time = 60;
            timer1.Enabled = false;
            label3.Text = "";
            label5.Text = "0";
            word = 0;
        }
    }
}
