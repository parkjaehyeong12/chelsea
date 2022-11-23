using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문제2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문제2
            //11
            Console.Write("숫자를 입력 ");
            int a = int.Parse(Console.ReadLine());  
            if(a < 0)
                Console.WriteLine("음수");
            //12
            Console.Write("숫자 하나 입력 ");
            a = int.Parse(Console.ReadLine());
            if(a>0)
                Console.WriteLine("자연수");
            else
                Console.WriteLine("자연수 아님");
            //13
            int rcp = new Random().Next(3);
            switch (rcp)
            {
                case 0:
                    Console.WriteLine("가위");
                    break;
                case 1:
                    Console.WriteLine("바위");
                    break;
                case 2:
                    Console.WriteLine("보");
                    break;
                default:
                    break;
            }
            //14
            Console.WriteLine("너도 하나 입력해봐 ");
            int rcp2 = int.Parse(Console.ReadLine());
            switch (rcp2)
            {
                case 0:
                    switch (rcp)
                    {
                        case 0:
                            Console.WriteLine("비김");
                            break;
                        case 1:
                            Console.WriteLine("짐");
                            break;
                        case 2:
                            Console.WriteLine("이김");
                            break;
                        default:
                            Console.WriteLine("잘못된 값");
                            break;
                    }
                    break;
                case 1:
                    switch (rcp)
                    {
                        case 0:
                            Console.WriteLine("이김");
                            break;
                        case 1:
                            Console.WriteLine("비김");
                            break;
                        case 2:
                            Console.WriteLine("짐");
                            break;
                        default:
                            Console.WriteLine("잘못된 값");
                            break;
                    }
                    break;
                case 2:
                    switch (rcp)
                    {
                        case 0:
                            Console.WriteLine("짐");
                            break;
                        case 1:
                            Console.WriteLine("이김");
                            break;
                        case 2:
                            Console.WriteLine("비김");
                            break;
                        default:
                            Console.WriteLine("잘못된 값");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("잘못된 값");
                    break;
            }
            //15
            if (rcp==rcp2)
                Console.WriteLine("비겼습니다.");
            else if(rcp2>rcp || (rcp2==0&&rcp==2))
                Console.WriteLine("이겼습니다");
            else
                Console.WriteLine("졌습니다.");




        }
    }
}
