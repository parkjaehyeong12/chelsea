using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMyCSharp02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {   //b1, b2는 동명이인. 따라서 잔액이 다르다.
            BKBank b1=new BKBank();
            b1.Name = "박재형";
            b1.Balance = 10000000;
            BKBank b2 = b1;
            b2.Balance = 0;
            b1.info();
            b2.info();
            KBBank kb1 = new KBBank();
            kb1.Name = "박지호";
            kb1.Balance = 50000000;
           
            KBBank kb2 = kb1;
            kb2.Balance = 0;

            kb1.info();//0
            kb2.info();//0
            //방법
            //1.일일이 복사
            KBBank k3 = new KBBank();
            k3.Name = kb1.Name;
            k3.Balance = 0;

            //조영탁이라는 이름만 복사한 계좌가 생기고
            //kbb1과 kbb2는 서로 잔액이 다르다.
            KyungBookBank kbb1 = new KyungBookBank("조영탁");
            kbb1.Balance = 5000;
            KyungBookBank kbb2 = new KyungBookBank(kbb1.Name);
            kbb2.Balance = 0;
            kbb1.info();
            kbb2.info();
            kbb1.Saving(10000);
            kbb1.info();
            kbb2.Withdrawal(5000);
            kbb2.info();
        }
    }
}
