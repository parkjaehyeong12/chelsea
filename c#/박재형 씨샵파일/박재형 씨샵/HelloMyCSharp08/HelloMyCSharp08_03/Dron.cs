using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_03
{
    public class Dron : IFight
    {
        public void attackTarget()
        {
            System.Windows.Forms.MessageBox.Show("드론이 타겟을 공격");
        }

        public void killTarget()
        {
            System.Windows.Forms.MessageBox.Show("드론이 타겟을 죽인다.");
        }

        public void protectMaster(string name)
        {
            System.Windows.Forms.MessageBox.Show($"드론이 마스터 { name } 을/를 보호한다.");
        }
    }
}
