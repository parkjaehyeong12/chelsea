using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp07
{
    public partial class Form1 : Form
    {
        //ref키워드: 참조자
        //포인터와 같은 점:그 변수의 위치를 가리킨다.
        //포인터와 다른점: 그 변수의 값을 출력함
        void swapFunction(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        void swapFunction( int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public Form1()
        {
            InitializeComponent();
            label5.Text = "";
            int a = 3;
            int b = 5;
            swapFunction(ref a, ref b);
            Console.WriteLine($"a={a},b={b}");
            swapFunction(a, b);
            Console.WriteLine($"a={a},b={b}");

            label1.Click += Label1_Click;
            
        }

        private void Label1_Click(object sender,EventArgs e)
        {
            label1.Text = "a";
            label2.Text = "b";
            label3.Text = "c";
            label4.Text = "d";

        }
        private void Label2_Click(object sender,  FormClosedEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(sender);
            //Console.WriteLine(e);
            int.TryParse(textBox1.Text, out int a);
            int.TryParse(textBox2.Text, out int b);
            swapFunction(ref a, ref b);
            textBox3.Text = a.ToString();
            textBox4.Text = b.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text
                = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
    }
}
