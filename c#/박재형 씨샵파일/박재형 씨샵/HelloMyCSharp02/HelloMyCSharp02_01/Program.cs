using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp02_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //c에서는 하나의 변수로 여러개의 값을 저장할 수 있는 자료형
            // c - 구조체
            // java -> class
            // c++ , c# -> struct, class

            //c언어에서는 사용자 정의 자료형
            //c++,c#,java 에서는 객체라는 말을 쓴다.
            //사용자 정의 객체 혹은 객체.
            Student s1 = new Student();
            s1.Name = "오세룡";
            s1.Age = 12;
            s1.eye = 0.11;
            Student[] students = new Student[3];
            students[0] = s1;
            students[1] = new Student();
            students[1].Name = "박지호";
            students[1].Age = 25;
            students[1].eye = 0.1;
            Console.WriteLine(s1.Name);
            Console.WriteLine(students[1].Name);

            //문제4
            Student jh = new Student();
            jh.Name = "박재형";
            jh.Age = 26;
            jh.eye = 8.2;
            Student sh = new Student();
            Console.WriteLine("성환이의 정보를 입력하시오");
            Console.WriteLine("학생이름?");
            sh.Name = Console.ReadLine();
            Console.WriteLine("학생나이?");
            sh.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("학생시력?");
            sh.eye = double.Parse(Console.ReadLine());

            Student[] kb = new Student[3];
            for (int i = 0; i < 3; i++)
            {
                kb[i] = new Student();
                Console.WriteLine("학생이름?");
                kb[i].Name = Console.ReadLine();
                Console.WriteLine("학생나이?");
                kb[i].Age= int.Parse(Console.ReadLine());
                Console.WriteLine("학생시력?");
                kb[i].eye = double.Parse(Console.ReadLine());
            }
            Console.WriteLine(jh.Name+"학생, "+jh.Age+"살, 시력 "+jh.eye);
            Console.WriteLine(sh.Name + "학생, " + sh.Age + "살, 시력 " + sh.eye);
            for (int i = 0; i < 3; i++)            
                Console.WriteLine(kb[i].Name + "학생, " + kb[i].Age + "살, 시력 " + kb[i].eye.ToString("0.0"));
            //ToString 반올림
            Console.WriteLine("kb반의 학생수는?");
            int a = int.Parse(Console.ReadLine());
            KBStudent[] kBStudents = new KBStudent[a];
            Console.WriteLine();
            for (int i = 0; i < 2 * a; i++)
            {
                if(i < a)
                {
                    kBStudents[i] = new KBStudent();
                    Console.WriteLine("학생이름?");
                    kBStudents[i].name = Console.ReadLine();
                    Console.WriteLine("학생나이?");
                    kBStudents[i].age = int.Parse(Console.ReadLine());
                    Console.WriteLine("학생시력?");
                    kBStudents[i].eye = double.Parse(Console.ReadLine());
                    Console.WriteLine("학생mbti?");
                    kBStudents[i].mbti = Console.ReadLine();
                }
                if(i >=a)
                {
                    Console.WriteLine(kBStudents[i-a].name + "학생, " + kBStudents[i-a].age + "살, 시력 " + kBStudents[i-a].eye+", mbti : " + kBStudents[i-a].mbti);
                }


            }

                
             KBStudent kb2 =  new KBStudent();
             kb2.name = "김성환";
             kb2.age = 22;
             kb2.eye = 1.1;
             kb2.mbti = "enfj";
             kb2.introduce();





        }
    }
}
