using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 집안
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //mp.openDoor();
            Console.WriteLine(MyParent.money);
            MyParent.openDoor();
            MyParent mom = new MyParent();
            MyParent dad = new MyParent();

            mom.name = "엄마";
            mom.age = 52;
            dad.name = "아빠";
            dad.age = 53;
            
            Child boy = new Child();
            boy.name = "재형";
            boy.age = 26;
            Console.WriteLine(MyParent.money);
            Console.WriteLine(Child.money);
            Child.openDoor();
            mom.eat();
            mom.sleep();
            boy.eat();
            boy.sleep();
            boy.study();
            boy.playgame();
            boy.buyBitCoin(1000);
            Console.WriteLine( MyParent.money );
            Console.WriteLine( Child.money);

            List<MyParent> myParents = new List<MyParent>()
            { mom, dad, boy};
            foreach (var item in myParents)
            {
                item.eat();
                item.sleep();
            }
           

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void introduce(MyParent p)
        {
            p.eat();
            p.sleep();
            if(p is Child)
            {
                (p as Child).sleep();
                (p as Child).study();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Child c = new Child();
            introduce(c);
        }
    }
}
