using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp02_01
{
    public struct KBStudent
    {
        public string name;
        public int age;
        public double eye;
        public string mbti;

        public void introduce()
        {
            Console.WriteLine("이름 : "+name);
            Console.WriteLine("나이 : " + age);
            Console.WriteLine("시력 : " + eye);
            Console.WriteLine("mbti : " + mbti);
        }
    }
}
