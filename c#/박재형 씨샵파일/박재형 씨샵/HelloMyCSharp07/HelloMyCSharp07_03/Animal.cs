using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp07_03
{
    //추상클래스라고 한다.
    //인스턴스를 만들수 없다.
    //해당 클래스를 상속받은 클래스는 반드시 기능을 구체화해야 한다.
    abstract public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }
        public void sleep()
        {
            System.Windows.Forms.MessageBox.Show
                ($"{name}은 {age}살이라서 많이 잡니다.");
        }
        //반드시 오버라이드되야 하는 메소드
        public abstract void eat();
    }
}
