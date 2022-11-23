using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 집안
{
    public class MyParent
    {
        public static int money = 10000;
        public string name { get; set; }
        public int age { get; set; }
        public void eat()
        {
            Console.WriteLine(this.name+", 밥을 먹읍시다.");
        }
        public void sleep()
        {
            Console.WriteLine(this.name+", 잠을 주무세요");
        }
        public static void openDoor()
        {
            //Console.WriteLine(this.name+"문이 열렸습니다.");

            Console.WriteLine("문이 열렸습니다.");
            //Console.WriteLine(this.money);
        }
        
       
    }
}
