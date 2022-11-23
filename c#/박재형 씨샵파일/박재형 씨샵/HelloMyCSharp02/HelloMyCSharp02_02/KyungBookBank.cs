using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp02_02
{   
    //KBBank를 상속받음
    internal class KyungBookBank : KBBank
    {
        public KyungBookBank(String Name)
        {
            this.Name = Name;
        }
        public void Withdrawal(int money)
        {
            this.Balance -= money;
        }
        public void Saving(int money)
        {
            this.Balance += money;
        }
    }
}
