using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp06_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // label1.Text = new MyMath().Power
            //   (int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
            
            //int.Parse의 보강버전. 강제 종료 안된다.

            //int.TryParse
            //1. 텍스트박스에 공백이나 숫자가 아닌 것이 있어도
            //프로그램이 튕기지 않는다.
            /*
             만약 공백이나 문자 있으면 int x에 0을 대입해준다.
            그와 동시에 TryPalse라는 함수는 false를 리턴해준다.

             */
            int.TryParse(textBox1.Text, out int x);
            int.TryParse(textBox2.Text, out int y);
            label1.Text = new MyMath().Power(x, y).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = new MyMath().Power
                (int.Parse(textBox1.Text)).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = new MyMath().Multi
                (int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text
                = MyMath2.Power(int.Parse(textBox1.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text
                = MyMath2.Multi(int.Parse(textBox1.Text),int.Parse(textBox2.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text 
                = MyMath2.Power(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text
                = MyMath3.Power(int.Parse(textBox1.Text)).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text
                = MyMath3.Multi(int.Parse(textBox1.Text),int.Parse(textBox2.Text)).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text
                = MyMath2.Power(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
