using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 집안
{
    public class Child : MyParent
    { 
        public void study()
        {
            Console.WriteLine("공부해요");
        }
        public void playgame()
        {
            Console.WriteLine("게임할래요");
        }
        public void buyBitCoin(int m)
        {
            money += m;
        }
        public Child()
        {
            money--;
        }
    }
}
