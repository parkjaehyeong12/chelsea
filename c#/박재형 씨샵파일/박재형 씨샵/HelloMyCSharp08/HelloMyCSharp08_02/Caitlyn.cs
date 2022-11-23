using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_02
{
    public class Caitlyn:LoLCharacter
    {
        public override void sayHello()
        {
           // base.sayHello();
            System.Windows.Forms.MessageBox.Show("최고의 사냥꾼이 되려면 사냥감의 머릿속이 훤히 들여다보여야 해.");
        }
    }
}
