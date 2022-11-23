using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습
{
    public class Children : IParent
    {
        public void talk()
        {
            Console.WriteLine("나는 배가 고픕니다.");
        }
        public void eat()
        {
            Console.WriteLine("배가 고프면 밥을 먹어야 합니다.");
        }
        public void rest()
        {
            Console.WriteLine("월드컵 봐야지");
        }
    }
}
