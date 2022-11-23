using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello11111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("안녕, 내 이름은 박재형이고, 남자이고, 26살이야");
            //2
            int age = 26;
            string name = "박재형";
            string info = "info: 안녕, 내 이름은 "+name+"이고, 나이는 "+age+"살이야";
            Console.WriteLine(info);
            //2-2
            string info2 = string.Format("info2: 안녕, 내 나이는 {0}살이고, 이름은 {1}이야", age, name);
            Console.WriteLine(info2);
            string info3 = $"info3: 안녕, 내 나이는 {age}살이고, 이름은 {name}이야";
            Console.WriteLine(info3);
        }
    }
}
