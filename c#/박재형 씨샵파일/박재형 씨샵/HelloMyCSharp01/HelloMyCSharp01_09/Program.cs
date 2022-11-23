using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp01_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            int[] numbers2 = new int[3];
            numbers2[0] = 1;
            numbers2[1] = 2;
            numbers2[2] = 3;

            int[,] numbers_2 = new int[2, 3];
            numbers_2[0, 0] = 1;
            numbers_2[0, 1] = 2;
            numbers_2[0, 2] = 3;
            numbers_2[1, 0] = 4;
            numbers_2[1, 1] = 5;
            numbers_2[1, 2] = 6;

            //for, while, for each문 다 된다.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                
                foreach (var item in numbers)
                {//var는 in 뒤에 있는 것은 타입에 따라 타입 결정
                    Console.WriteLine(item);
                }//여기선 int

                //자바스크립트의 var랑은 다르다.
                //자바스크립트의 var는 데이터타입이 유동적이지만
                //c#은 한번 정해지면 안 바뀐다.
                
            }
            //2차원 배열 반복문
            Console.WriteLine("------------------");
            for (int i = 0; i < numbers_2.GetLength(0); i++)
            {
                for(int j =0; j < numbers_2.GetLength(1); j++)
                {
                    Console.WriteLine($"[{i},{j}]={numbers_2[i,j]}");
                }
            }



        }
    }
}
