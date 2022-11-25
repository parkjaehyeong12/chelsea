using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp10_01
{
    public partial class Form1 : Form
    {
        //델리게이트 : 대리자
        //일종의 클래스처럼 사용자의 정의 자료형 같은 것
        //함수를 매개변수로처럼 쓰게 만드는것
        //js의 콜백함수와 같은것
        //델리게이트와 람다를 이용하면 코드를 적게 쓰고
        //많은 기능 동작하게 하거나
        //불필요한 함수 선언을 줄일수있다.


        public delegate void VoidFunc();//함수를 담는 자료형, 반환형 없고, 매개변수 없는거
        public delegate int IntegerFunc();
        public delegate void ParameterFunc(int i);
        public delegate int IntegerParamFunc(int i);

        /*
         public delegate int IntegerParamFuncd(int i);

        public int age;
         */


        public int power(int num)
        {
            return num * num;
        }


        public void myTest()
        {
            MessageBox.Show("MyTest");
        }

        public void yourTest()
        {
            MessageBox.Show("YourTest");
        }

        public void executeFunc(VoidFunc v, int c)
        {
            for (int i = 0; i < c; i++)
                v();
        }

        public void executeFunc(IntegerParamFunc i, int num)
        {
            MessageBox.Show("num의 제곱 "+i(num));
        }

        List<Product> products = new List<Product>();

        public Form1()
        {
            InitializeComponent();

            products.Add(new Product() { id = 5, name = "감자", price = 100 });
            products.Add(new Product() { id = 1, name = "돌", price = 50 });
            products.Add(new Product() { id = 3, name = "칫솔살균기", price = 0 });

            button4.Click += (s, e) =>
            {
                MessageBox.Show("버튼4 클릭");
            };

            button4.Click += delegate (object s, EventArgs e)
            {
                MessageBox.Show((s as Button).Text);
            };

            button4.Click += button1_Click;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            executeFunc(myTest, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //무명델리게이트
            //함수는 함수인데, 이름이 없다.
            //한군데에서만 쓰일 거라면 굳이 함수를 만들 필요도 없다.
            executeFunc(delegate (){
                MessageBox.Show("안녕하세요");
            }, 3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //람다
            //무명 델리게이트를 더 줄인 형태
            //무명 델리게이트와 마찬가지로 간단하게 함수를 쓰고 싶을때 씀
            //임시, 한번만 쓰는 함수 쓸때 이렇게 하는데, 메모리 관리측면 효율적임(무명, 람다)
            executeFunc(() => { MessageBox.Show("AAA");},10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            executeFunc(power, 10); //10의 제곱인 100 출력
            VoidFunc myvoid = yourTest;
            myvoid();//델리게이트를 매개변수나 변수로 만들 수 있다.
        }

        private void button6_Click(object sender, EventArgs e)
        {   // (세제곱하는 함수) 를 매개변수로 한다.
            //매개변수는 5
            executeFunc(delegate (int n) { return n * n * n; }, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            executeFunc((n) => n * n * n * n, 10);
            executeFunc((n) => { return n * n * n * n * n; }, 10);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //id정렬
            products.Sort(delegate (Product a, Product b)
            {
                return a.id.CompareTo(b.id);
            });
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //가격정렬
            products.Sort((a,b)=> a.price.CompareTo(b.price));    
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //출력
            foreach (Product p in products)
            {
                MessageBox.Show($"이름:{p.name}, 가격:{p.price}, 아이디:{p.id}");
            }
        }
    }
}
