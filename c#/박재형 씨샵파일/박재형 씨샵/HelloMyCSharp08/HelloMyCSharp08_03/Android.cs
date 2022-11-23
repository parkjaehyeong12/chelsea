using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_03
{
    internal class Android : IMyRobot
    {
        public void actCute()
        {
            System.Windows.Forms.MessageBox.Show("안드로이드가 애교");
        }

        public void attackTarget()
        {
            System.Windows.Forms.MessageBox.Show("안드로이드가 공격");
        }

        public void killTarget()
        {
            System.Windows.Forms.MessageBox.Show("안드로이드가 살상");
        }

        public void pringMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show("안드로이드 메시지:"+message);
        }

        public void protectMaster(string name)
        {
            System.Windows.Forms.MessageBox.Show("안드로이드가" +name+"주인보호");
        }

        public void smile()
        {
            System.Windows.Forms.MessageBox.Show("안드로이드가 눈웃음");
        }

        public void welCome()
        {
            System.Windows.Forms.MessageBox.Show("안드로이드가 반김");
        }
    }
}
