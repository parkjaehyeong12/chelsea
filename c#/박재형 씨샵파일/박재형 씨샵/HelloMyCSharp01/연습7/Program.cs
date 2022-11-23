using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //문제1
            //1
            Console.WriteLine("안녕하세요");
            //2
            Console.Write(10+20+" ");
            Console.Write((((float)7.0 / 3).ToString("F2")) + " ");
            
            double b = double.Parse(((float)7 / 3).ToString("F2"));
            
            Console.Write(7 % 3 + " ");
            Console.Write(7 - 3 + " ");
            Console.WriteLine(10 * 20 + " ");
            //3
            Console.Write("10"+20+" ");
            Console.Write('2'+100+" ");
            Console.WriteLine("10"+'2');
            //4
            Console.Write("태어난 연도? ");
            int birth = int.Parse(Console.ReadLine());
            Console.WriteLine(birth);
            //5
            Console.Write("이름이 뭔가? ");
            string name = Console.ReadLine();
            Console.WriteLine($"내 이름은 {name}이다!");
            //6
            int age = 30;
            name = "이동준";
            Console.WriteLine("내이름은 \""+name+"\"입니다. 나이는 \""+age+"\"대입니다.");
            //7
            Console.Write("당신은 몇살? ");
            int myage = int.Parse(Console.ReadLine());
            Console.WriteLine("당신의 출생연도는 "+(DateTime.Now.Year+1-myage)+"년입니다.");
            //8
            Console.Write("올해는 몇년도입니까 ");
            int nowYear = int.Parse(Console.ReadLine());
            Console.Write("당신의 태어난 연도는? ");
            int bornYear = int.Parse(Console.ReadLine());
            Console.WriteLine("당신의 한국식 나이는 "+(nowYear-bornYear+1)+"살입니다.");
            //9
            Console.Write("글자를 입력하세요 ");
            string line = Console.ReadLine();
            Console.WriteLine(line[0]);
            //10
            Console.Write("정사각형의 변길이 입력 ");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("정사각형의 넓이는 "+(w*w));

            //문제2

        }
    }
}
