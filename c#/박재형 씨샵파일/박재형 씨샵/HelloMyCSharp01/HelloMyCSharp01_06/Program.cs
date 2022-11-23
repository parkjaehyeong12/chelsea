using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //반복문
            //대표적인 것 3가지
            //for
            //시작점과 끝점을 지정
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("안녕하세요"+i+"번님");
                Console.WriteLine(string.Format("{0}은 뭘까",i));
                Console.WriteLine($"{i}번말");
            }

            //실습1번
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("안녕하세요" + i + "번님");        
            }

            //실습2번
            int sum = 0;  //for문 버전
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("1부터 10까지의 합:"+sum);

            sum = 0; //while문 버전
            int c = 0;
            while (c<11)
            {
                sum += c;
                c++;
            }
            Console.WriteLine(sum);

            //실습 3번
            Console.WriteLine("숫자 입력해"); //for문
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                for (int j = 0; j < i; j++)
                {   //1줄에 별을 다 출력
                    Console.Write("*");
                }//그 뒤에 줄을 바꾼다.
                Console.WriteLine();
            }

            int c1 = 0; //while문 버전
            int c2 = 0;
            while (c1 <= count)
            {
                while (c2 < c1)
                {
                    Console.Write("*");
                    c2++;
                }
                Console.WriteLine();
                c2 = 0;
                c1++;
            }


            //while
            while (true)
            {
                Console.WriteLine("숫자입력");
                int num = int.Parse(Console.ReadLine());
                if(num<0)
                {
                    Console.WriteLine("음수이므로 종료");
                    break;
                }
            }

            //do while
            //while처럼 일단은 무한반복하지만
            //처음 입력값에 따라 <1번 실행 or 계속 실행> 을 결정
            //무조건 1번은 실행
            int mynum = -1;
            do
            {
                Console.WriteLine("mynum=" + mynum);
                Console.WriteLine("mynum은?");
                mynum = int.Parse(Console.ReadLine());
            } while (mynum > 0);

            //비공식적인 것 하나:goto
            Mytest:
            Console.WriteLine("Hello World");

            if (mynum==-1)
            {
                Console.WriteLine("mynum?");
                mynum = int.Parse(Console.ReadLine());
                goto Mytest;//이동
            }



        }
    }
}
