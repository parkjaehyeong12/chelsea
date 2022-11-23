using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp07_03
{
    enum 가위바위보
    {
        가위, 바위, 보
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(가위바위보.가위.ToString());
            MessageBox.Show(가위바위보.바위.ToString());
            MessageBox.Show(가위바위보.보.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Animal a = new Animal();
            //List에 여러 개의 자료형을 추가하거나
            //메소드의 매개변수로써 조상클래스를 활용한다.
            Animal a = new Dog();
            a.name = "퍼피";
            a.age = 10;
            a.eat();
            a.sleep();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Animal b = new Cat() { name="야옹야옹", age = 5 };
            b.sleep();
            b.eat();
        }

        private void sleep_and_eat(Animal a)
        {
            a.sleep();
            a.eat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sleep_and_eat(new Cat() { name="랑이", age = 7});
            sleep_and_eat(new Dog() { name="행복이", age = 8});
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat() { name="야홍이", age=1});
            animals.Add(new Dog() { name = "멍뭉이", age = 10 });
            animals.Add(new Cat() { name = "캣캣캣", age = 5 });
            foreach (var item in animals)
            {
                sleep_and_eat(item);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {            
            sleep_and_eat(new Lion() { name = "사돌이", age = 111 });
            sleep_and_eat(new Pig() { name = "윌버", age = 8 });
        }
    }
}
