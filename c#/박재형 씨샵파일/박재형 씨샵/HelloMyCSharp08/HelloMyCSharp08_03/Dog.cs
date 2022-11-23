using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_03
{
    public class Dog : ICharming
    {
        public string name { get; set; }
        public string age { get; set; }
        public void actCute()
        {
            System.Windows.Forms.MessageBox.Show("주인을 핥는다.");
            //throw new NotImplementedException();
        }

        public void smile()
        {
            System.Windows.Forms.MessageBox.Show("주인에게 웃는다.");
            //throw new NotImplementedException();
        }

        public void welCome()
        {
            System.Windows.Forms.MessageBox.Show("주인을 반긴다.");
            //throw new NotImplementedException();
        }
    }
}
