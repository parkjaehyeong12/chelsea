using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharp05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers1 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers1[i] = i;
            }
            foreach (var item in numbers1)
            {
                Console.WriteLine(item);
            }
            //2.list
            List<int> numbers2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers2.Add(i * i);
            }
            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }
            //자바의 arralist와는 달리 각 구성요소 접근시
            //배열이랑 똑같이 접근함// 자바에서는 get 사용
            for (int i = 0; i < numbers2.Count; i++)
            {
                Console.WriteLine(numbers2[i]);
            }//배열과 같은 기능을 하는 클래스라고 봐도 무방하다.
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine(numbers1[i]);
            }

        }
    }
}
