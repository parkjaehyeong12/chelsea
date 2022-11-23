using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if(i%2==0)
                    Console.WriteLine("짝수");
                Console.WriteLine("i="+i);
            }
            //반복문을 끝내는 것은 break;
            //특정 조건에서만 다음 step으로 넘기는 거시:continue;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("i="+i);
                if (i % 2 != 0)
                    continue;//밑에꺼 실행 안하고 i++
                Console.WriteLine("짝수");
            }
            

        }
    }
}
