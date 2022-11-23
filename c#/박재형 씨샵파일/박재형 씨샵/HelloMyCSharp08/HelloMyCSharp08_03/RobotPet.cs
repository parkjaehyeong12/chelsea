using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp08_03
{
    public class RobotPet : IFight, ICharming
    {
        public void actCute()
        {
            System.Windows.Forms.MessageBox.Show("로봇펫이 애교");
        }

        public void attackTarget()
        {
            System.Windows.Forms.MessageBox.Show("로봇펫이 타겟공격");
        }

        public void killTarget()
        {
            System.Windows.Forms.MessageBox.Show("로봇펫이 타겟죽임");
        }

        public void protectMaster(string name)
        {
            System.Windows.Forms.MessageBox.Show($"로봇펫이 {name} 주인지킴");
        }

        public void smile()
        {
            System.Windows.Forms.MessageBox.Show("로봇펫이 웃음");
        }

        public void welCome()
        {
            System.Windows.Forms.MessageBox.Show("로봇펫이 반김");
        }
    }
}
