using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("나이?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("이름?");
            string name = Console.ReadLine();
            Console.WriteLine("mbti?");
            string mbti = Console.ReadLine();
            Console.WriteLine("혈액형?");
            string blood = Console.ReadLine();
            Console.WriteLine("태어난 연도?");
            int year = int.Parse(Console.ReadLine());
            int myage = DateTime.Now.Year - year + 1;

            Console.WriteLine("원의 반지름?");
            int r = int.Parse
                (Console.ReadLine());

            Console.WriteLine("내 시력?");
            double myeye = double.Parse(Console.ReadLine());

            Console.WriteLine("나이 : "+myage+", 이름 : "+name+", mbti : "+mbti+", 혈액형 : "+blood+", 시력 : "+myeye);
            Console.WriteLine(String.Format("나이:{0}, 이름:{1}, mbti:{2}, 혈액형:{3}, 시력:{4}",myage,name,mbti,blood,myeye));
            Console.WriteLine("원의 넓이 : "+(r*r*3.14)+", 원의 둘레:"+(r*2*3.14));


        }
    }
}
