using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp07_03
{
    internal class Lion : Animal
    {
        public override void eat()
        {
            System.Windows.Forms.MessageBox.Show
                ($"{name}는 사자이고 {age}살답게 잘먹는다. 우왕");

            //throw new NotImplementedException();
        }
    }
}
