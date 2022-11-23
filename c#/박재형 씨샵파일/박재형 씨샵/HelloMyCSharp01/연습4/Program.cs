using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            for (int i =1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            int j = 1;
            while (j<=10)
            {
                Console.WriteLine(j);
                j++;
            }
            //2
            Console.WriteLine("숫자 두개 a, b 입력");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            for (int i = a; i <= a; i++)
            {
                Console.WriteLine(i);
            }
            while (a <= b)
            {
                Console.WriteLine(a);
                a++;
            }

            //3
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                    continue;
                Console.WriteLine(i);
            }
            int c = 1;
            while (c<=100)
            {
                if (c % 2 == 0)
                    Console.WriteLine(c);
                c++;
            }
            //4
            Console.WriteLine("숫자 a, b를 입력하시오");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }


            for (int i = b; i >= a; i--)
            {
                Console.WriteLine(i);
            }
            while(a<=b)
            {
                Console.WriteLine(b);
                b--;
            }




        }
    }
}
