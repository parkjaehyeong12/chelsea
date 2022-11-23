using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문제3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문제3
            //16
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i+1)+" ");
            }
            Console.WriteLine();
            //17
            int sum = 1;
            for (int i = 1; i <= 10; i++)
                sum *= i;
            Console.WriteLine("1부터 10까지 곱은 "+sum);
            //18
            int count = 1;
            while (count<11)
            {
                Console.WriteLine("안녕하세요 "+count+"번째 손님");
                count++;
            }
            //19
            Console.Write("숫자 입력 ");
            int n;
            do
            {
            n = int.Parse(Console.ReadLine());
                Console.WriteLine("제곱 "+n*n);
            } while (n!=0);
            //20-1
            sum = 1;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                sum *= i;
            }
            Console.WriteLine("20-1 : 1부터 10까지 홀수만 곱하면 "+sum);
            //20-2
            sum = 1;
            for (int i = 1; i <=10 ; i+=2)
            {
                sum *= i;
            }
            Console.WriteLine("20-2 : 1부터 10까지 홀수만 곱하면 " + sum);
        }
    }
}
