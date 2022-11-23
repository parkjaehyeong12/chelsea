using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            for (int i = 1; i <=5; i++)
            {
                Console.WriteLine(String.Format("안녕하세요 {0}번님",i));
            }
            //2
            int a=1;
            int count = 0;
            while (a<=10)
            {
                count += a;
                a++;
            }
            Console.WriteLine(count);
            //3
            Console.WriteLine("숫자입력하세요");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {                  
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    }
}
