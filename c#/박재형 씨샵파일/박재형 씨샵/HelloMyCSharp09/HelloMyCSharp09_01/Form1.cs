using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp09_01
{
    public partial class Form1 : Form, ISubject
    {
        public Form1()
        {
            //this =Form1을 의미
            //Form1이 들어갈 수 있는 이유는 Isubject를 구현해서.
            InitializeComponent();
            Form2 frm2 = new Form2(this);
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm2);
            frm2.Show();

            Form3 frm3 = new Form3(this);
            frm3.TopLevel = false;
            frm3.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm3);
            frm3.Show();

            Form4 frm4 = new Form4(this,frm2,frm3);
            frm4.TopLevel = false;
            frm4.FormBorderStyle = FormBorderStyle.None;
            panel3.Controls.Add(frm4);
            frm4.Show();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //다형성에 의해 둘다 된다.
            //Notifier n = new Notifier();
            ISubject s = new Notifier();
            s.register(new Observer1() { name = "스타1" });
            s.register(new Observer2());
            IObserver o1 = new Observer1();
            (o1 as Observer1).name = "허영무의 옵저버";
            s.register(o1);
            s.notify("스타크래프트"); //옵저버 3마리가 update를 한다.
            s.unregister(o1); //허영무의 옵저버가 빠진 상태에서
            s.notify(",스2,"); //2마리의 옵저버만 update를 호출
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<IObserver> observers = new List<IObserver>();

        public void register(IObserver o)
        {
            observers.Add(o);
        }

        public void unregister(IObserver o)
        {
            observers.Remove(o);
        }

        public void notify(string msg)
        {
            foreach (IObserver o in observers)
            {
                o.update(msg);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //notify(textBox1.Text);
            notify((sender as TextBox).Text);
        }
    }
}
