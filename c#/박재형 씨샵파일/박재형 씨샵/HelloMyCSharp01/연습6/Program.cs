using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 5개 입력");

            int[] aa = new int[5];

            for (int i = 0; i < aa.Length; i++)
            {
                aa[i] = int.Parse(Console.ReadLine());

            }
            int big = aa[0];
            int small = aa[0];
            for (int i = 0; i < aa.Length; i++)
            {
                if (aa[0] > aa[i])
                {
                    big = aa[i];
                }
                if (aa[i] < aa[0])
                {
                    small = aa[i];
                }
            }
            Console.WriteLine(big);
            Console.WriteLine(small);

            big = aa[0];
            small = aa[0];
            foreach (var item in aa)
            {
                if (item>big)
                {
                    big = item;
                }
                if(item<small)
                {
                    small = item;
                }
            }

            int bigwhere = 0;
            int smallwhere = 0;
            for (int i = 0; i < aa.Length; i++)
            {
                if (aa[i] == big)
                    bigwhere = i;
                if (aa[i] == small)
                    smallwhere = i;
                

            }

            
            foreach (var item in aa)
            {
                
            }

        }
    }
}
