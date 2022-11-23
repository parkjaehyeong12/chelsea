using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp08_02
{
    public partial class Form1 : Form
    {
            Gwen Zeus = new Gwen();
          
            Caitlyn Deft = new Caitlyn();

        static int number;
        public Form1()
        {
            InitializeComponent();     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Zeus = new Gwen();
            if (number == 1)
                Zeus.Attack();
            else if (number == 2)
                Deft.Attack();
           // Caitlyn Deft = new Caitlyn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  Gwen Zeus = new Gwen();
          //  Zeus.sayHello();
            //Caitlyn Deft = new Caitlyn();
            if (number == 1)
                Zeus.sayHello();
            else if (number == 2)
                Deft.sayHello();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Gwen Zeus = new Gwen();
            if (number == 1)
                Zeus.Ekey();
            else if (number == 2)
                Deft.Ekey();
            //  Caitlyn Deft = new Caitlyn();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Gwen Zeus = new Gwen();
          //  Zeus.Qkey();
            //  Caitlyn Deft = new Caitlyn();
            if (number == 1)
                Zeus.Qkey();
            else if (number == 2)
                Deft.Qkey();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // Gwen Zeus = new Gwen();
         //   Zeus.Wkey();
            //  Caitlyn Deft = new Caitlyn();
            if (number == 1)
                Zeus.Wkey();
            else if (number == 2)
                Deft.Wkey();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // Gwen Zeus = new Gwen();
          //  Zeus.Rkey();
            //  Caitlyn Deft = new Caitlyn();
            if (number == 1)
                Zeus.Rkey();
            else if (number == 2)
                Deft.Rkey();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           // Gwen Zeus = new Gwen();
          //  Zeus.MoveUp();
            //  Caitlyn Deft = new Caitlyn();
            if (number == 1)
                Zeus.MoveUp();
            else if (number == 2)
                Deft.MoveUp();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           // Gwen Zeus = new Gwen();
          //  Zeus.MoveLeft();
            // Caitlyn Deft = new Caitlyn();
            if (number == 1)
                Zeus.MoveLeft();
            else if (number == 2)
                Deft.MoveLeft();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          //  Gwen Zeus = new Gwen();
           // Zeus.MoveDown();
            if (number == 1)
                Zeus.MoveDown();
            else if (number == 2)
                Deft.MoveDown();
        }

        private void button10_Click(object sender, EventArgs e)
        {
          //  Gwen Zeus = new Gwen();
           // Zeus.MoveRight();
            if (number == 1)
                Zeus.MoveRight();
            else if (number == 2)
                Deft.MoveRight();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            number = 1;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            number = 2;
        }
    }
}
