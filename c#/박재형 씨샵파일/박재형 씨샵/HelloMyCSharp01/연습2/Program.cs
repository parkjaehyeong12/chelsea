using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 a값을 입력하세요");
            int a = int.Parse(Console.ReadLine());
            string result = a == 0 ? "0" : "X";
            if(result == "0")
            {
                Console.WriteLine("a는 0");
            }
            else
            {
                result = a > 0 ? "양수" : "음수";
                if(result =="양수")
                    Console.WriteLine("a는 양수");
                else
                    Console.WriteLine("a는 음수");
            }

            //1
            //************************************
            //3항 연산자의 묘미
            Console.WriteLine("숫자 다시 입력받기");
            int num1 = int.Parse(Console.ReadLine());

            string result1 = num1 == 0 ? "0" : (num1 > 0 ? "양" : "음");
            Console.WriteLine(result1);



            Console.WriteLine("정육면체 주사위 값?");
            int b = int.Parse(Console.ReadLine());
            switch (b)
            {
                case 1:
                    Console.WriteLine("주사위 값은 일");
                    break;
                case 2:
                    Console.WriteLine("주사위 값은 이");
                    break;
                case 3:
                    Console.WriteLine("주사위 값은 삼");
                    break;
                case 4:
                    Console.WriteLine("주사위 값은 사");
                    break;
                case 5:
                    Console.WriteLine("주사위 값은 오");
                    break;
                case 6:
                    Console.WriteLine("주사위 값은 육");
                    break;
                default:
                    Console.WriteLine("이상한 숫자");
                    break;
            }
            Random num = new Random();
            int dice = num.Next()%6 + 1;
            //new Random.Next(1,7)

            Console.WriteLine("다음은 랜덤 주사위값");

            switch (dice)
            {
                case 1:
                    Console.WriteLine("주사위 값은 일");
                    break;
                case 2:
                    Console.WriteLine("주사위 값은 이");
                    break;
                case 3:
                    Console.WriteLine("주사위 값은 삼");
                    break;
                case 4:
                    Console.WriteLine("주사위 값은 사");
                    break;
                case 5:
                    Console.WriteLine("주사위 값은 오");
                    break;
                case 6:
                    Console.WriteLine("주사위 값은 육");
                    break;
                default:
                    Console.WriteLine("이상한 숫자");
                    break;
            }
            //3
            int evenodd = dice % 2;
            switch (evenodd)
            {
                case 0:
                    Console.WriteLine("짝");
                    break;
                case 1:
                    Console.WriteLine("홀");
                    break;
                default:
                    Console.WriteLine("이상한 숫자일듯");
                    break;
            }
            //4
            Console.WriteLine("나이입력");
            int age = int.Parse(Console.ReadLine()); //int.Parse => Integer.parsInt
            if (age < 0)
            {
                Console.WriteLine("무효");
            }else if(age<20)
            {
                Console.WriteLine("미성년자");

            }
            else if(age<150)
            {
                Console.WriteLine("성인");
            }
            else
            {
                Console.WriteLine("불가사의ㄴ");

            }



        }
    }
}
