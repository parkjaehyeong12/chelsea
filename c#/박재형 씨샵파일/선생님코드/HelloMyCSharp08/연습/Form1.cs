using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 연습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Parent p = new Parent();
            p.talk();
            //(p as Child).playGame(); //err
            Parent c = new Child();
            c.talk(); //왼쪽 클래스에 있는 메소드는 그냥 호출됨
            //c.eat();
            (c as Child).playGame(); //Child에만 있는 거는 형변환 필요

            IParent p2 = new Children();
            p2.talk();//왼쪽 인터페이스에 있는 메소드는 그냥 호출됨
            (p2 as Children).eat();  //이거는 형변환 필요.
            (p2 as Children).rest(); //이거는 안된다.



            Parent pp = new Child();
            //Child cc = new Parent();

            Child cc = new Child();
            cc.eat();
            (cc as Parent).talk();
            (cc as Parent).talk();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
