using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 아침2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Jik
        {
            private int garo;
            private int sero;


            public int wide()
            {
                return (this.garo * this.sero);
            }
            public void setGaro(int g)
            {
                this.garo = g;
            }
            public void setSero(int s)
            {
                this.sero = s;
            }
            public int getGaro()
            {
                return this.garo;
            }
            public int getSero()
            {
                return this.sero;
            }

        }
        public class Circle
        {

            private int r;
            public static double pi = 3.14;
            public double wide()
            {
                return this.r * this.r * pi;
            }
            public int getR()
            {
                return this.r;
            }
            public void setR(int r)
            {
                this.r = r;
            }

        }

        public class Jung : Jik
        {
            private int height;

            public void setHeight(int h)
            {
                this.height = h;
            }

            public int bupi()
            {
                return (getHeight() * getGaro() * getSero());
            }
            public int getHeight()
            {
                return this.height;
            }
        }

        public class Gu : Circle
        {
            public double bupi()
            {
                return ((4.0 / 3.0) * (getR() * getR() * getR()) * pi);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Gu g = new Gu();
            g.setR(int.Parse(textBox6.Text));
            MessageBox.Show(g.wide().ToString());
            MessageBox.Show(g.bupi().ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Circle g = new Circle();
            g.setR(int.Parse(textBox6.Text));
            MessageBox.Show(g.wide().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Jik j = new Jik();
            j.setGaro(int.Parse(textBox1.Text));
            j.setSero(int.Parse(textBox2.Text));
            MessageBox.Show(j.wide().ToString());

            Label label = new Label();
            label.Location = new Point(524,74);
            label.Text=j.wide().ToString();
            Controls.Add(label);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Jung j = new Jung();
            j.setGaro(int.Parse(textBox3.Text));
            j.setSero(int.Parse(textBox4.Text));
            j.setHeight(int.Parse(textBox5.Text));
            MessageBox.Show(j.bupi().ToString());

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
