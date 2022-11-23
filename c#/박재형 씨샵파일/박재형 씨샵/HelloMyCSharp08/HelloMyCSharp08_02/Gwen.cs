using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_02
{
    public class Gwen : LoLCharacter
    {
        public override void sayHello()
        {
            //base.sayHello();
            System.Windows.Forms.MessageBox.Show("등 뒤의 바람결이 정말 좋아. 절대 놓치지 않을 거야. 절대로!");
        }
    }
}
