using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sysout = cw
            //cw 누르고 tab tab
            Console.WriteLine("안녕");
            //자바의 System.out.println("안녕"); 과 동일

            int num1 = 10;
            double num2 = 3.14;

            //c#에서는 문자열 변수 저장시 s를 주로 소문자로 한다.
            //둘의 의미는 같다.
            string m1 = "Hello";
            String m2 = "이것도 됨";

            char lastName = '이';//한글자 저장
            bool tf = true; //자바에선 boolean
            Boolean tf2 = false; //Boolean과 bool 둘 다 된다.

            char c1 = "안녕하세요"[0]; //첫글자 가져온다. 안.
            string s1 = "hello";
            char c2 = s1[1]; //알파벳 e.

            Console.WriteLine(c1);
            Console.WriteLine(s1);
            Console.WriteLine(c2);

            Console.WriteLine(10+20);//30
            Console.WriteLine("안녕"+"하세요");//안녕하세요
            Console.WriteLine("10" + 20);//1020

            //연산자는 자바랑 마찬가지로
            //+,-,*,/,%

            //문자열 처리
            //1.더하기를 통해서 변수랑 문자열 더한다.
            int age = 34;
            int age2 = 30;
            string info = "내 나이:" + age;//문자열+변수 //내 나이:34
            Console.WriteLine(info);
            //2. string.format
            string info2 = string.Format("내 나이:{0},{1}", age,age2);  //내 나이:34,30
            Console.WriteLine(info2);
            //3. $ 표시
            string info3 = $"내 나이:{age}";  //내 나이:34
            Console.WriteLine(info3);
        


        }
    }
}
