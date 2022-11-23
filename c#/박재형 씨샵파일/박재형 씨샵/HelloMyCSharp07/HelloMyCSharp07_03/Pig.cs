using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp07_03
{
    internal class Pig : Animal
    {
        public override void eat()
        {
            System.Windows.Forms.MessageBox.Show("꿀꿀꿀");
           // throw new NotImplementedException();
        }
    }
}
