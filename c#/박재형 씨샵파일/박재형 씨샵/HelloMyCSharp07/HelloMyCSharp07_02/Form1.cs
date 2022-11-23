using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cat c = new Cat() { age = 10, name = "야옹이" };
            c.eat();
            c.sleep();
            c.fight();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Tiger t = new Tiger()
            { age = 100, name = "호치" };
            t.sleep();
            t.eat();
            t.fight();
            ((Cat)t).eat(); //하이딩 되서 강제 형변환하면 부모클래스 메소드 호출
            ((Cat)t).fight(); //오버라이딩 되서 강제형변환해도 부모클래스 메소드 호출X
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.name = "헤라";
            c.age = 30;
            //ToString:object 클래스 있는 메소드
            //이 메소드는 오버라이딩이 가능하다.
            //public virtual string ToString
            //오버라이딩하지 않으면
            MessageBox.Show(c.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tiger t = new Tiger();
            t.name = "호치";
            t.age = 110;
            //Tiger클래스에서 정의한 모양대로
            //값들을 리턴해준다.
            MessageBox.Show(t.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
