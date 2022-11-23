using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp08_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            d.actCute();
            d.smile();
            d.welCome();
            //인터페이스도 다형성이 적용됨
            ICharming pet1 = new Dog();
            ICharming pet2 = new RobotPet();
           
            pet1.actCute();
            pet2.actCute();

        }

        void cute_smile_wel(ICharming c)
        {
            c.actCute();
            c.smile();
            c.welCome();
        }
        void fightForMe(IFight f, string m)
        {
            f.attackTarget();
            f.killTarget();
            f.protectMaster(m);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            cute_smile_wel(new Dog());
            cute_smile_wel(new RobotPet());
            fightForMe(new Dron(), "박재형");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<IFight> fighters = new List<IFight>();
            fighters.Add(new RobotPet());
            fighters.Add(new Dron());
            foreach (IFight item in fighters)
            {
                fightForMe(item, textBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Android a = new Android();
            IMyRobot i = new Android(); //클래스(인터페이스) 인스턴스 = new 생성자
            IFight f = new Android();
            ICharming c = new Android();
            a.pringMessage("헬로월드");
            a.actCute();
            a.smile();
            a.attackTarget();
            a.killTarget();
            a.protectMaster("주인");

            i.pringMessage("안녕 세상");
            i.actCute();
            i.smile();
            i.attackTarget();
            i.killTarget();
            i.protectMaster("마스터");

            //c.pringMessage("헬로월드");
            c.actCute();
            c.smile();
            c.welCome();
            //c.attackTarget();
            //c.killTarget();
            //c.protectMaster("주인");

            //f.pringMessage("헬로월드");
            //f.actCute();
            //f.smile();
            f.attackTarget();
            f.killTarget();
            f.protectMaster("주인");

        }
    }
}
