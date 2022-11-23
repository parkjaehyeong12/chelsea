using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_02
{
    public class LoLCharacter : GameCharacter, IRpgCharacter, IRts
    {
        public int level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public virtual void Qkey() { Console.WriteLine("q키누름"); }
        public virtual void Wkey() { Console.WriteLine("w키누름"); }
        public virtual void Ekey() { Console.WriteLine("e키누름"); }
        public virtual void Rkey() { Console.WriteLine("r키누름"); }


        public void Attack()
        {
            Qkey();
           // throw new NotImplementedException();
        }

        public void MoveDown()
        {
            Console.WriteLine("아래로 간다.");
           // throw new NotImplementedException();
        }

        public void MoveLeft()
        {
            Console.WriteLine("왼쪽으로 간다.");
            // throw new NotImplementedException();
        }

        public void MoveRight()
        {
            Console.WriteLine("오른쪽으로 간다.");
            // throw new NotImplementedException();
        }

        public void MoveUp()
        {
            Console.WriteLine("위로 간다.");
            // throw new NotImplementedException();
        }

        public override void sayHello()
        {
           // throw new NotImplementedException();
        }
    }
}
