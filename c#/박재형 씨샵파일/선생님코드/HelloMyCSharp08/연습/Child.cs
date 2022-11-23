using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습
{
    public class Child :Parent
    {
        public override void talk()
        {
            Console.WriteLine("나는 자식");
        }
        public void playGame()
        {
            Console.WriteLine("축구게임");
        }

        public void eat()
        {
            Console.WriteLine("자식의 밥먹기");
        }
    }
}
