using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp05
{
    public partial class abcd : Form
    {
        public abcd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(char i='가'; i<='힇';i++)
            {
                Console.Write(i);
            }
            Label label = new Label();
            label.AutoSize = true;
            label.Location = new Point(0, 100);
            for (char i = '가'; i <= '힇'; i++)
            {
                label.Text += i;
                if (i % 100 == 0)
                    label.Text += Environment.NewLine;// \n과 같다.
                //Enviroment.NewLine 환경에 맞게 한줄 띄는것
            }
            label.Name = "mylabel";//디자인창에서의 변수이름
            Controls.Add(label);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {//컨트롤스의 길이만큼 동작
                //item은 conrtols에 있는 다양한 타입들의 구성요소

                if(item is Label)
                {
                    //is = 타입 체크
                    //var 자체는 타입이 없는 데,
                    //대입되는 값에 따라서 타입 정해짐
                    //Controls 안에 있는 버튼, Label등이 다 item인데
                    //그 중에서 Label 타입인 것을 만나면 이 조건문으로
                    //들어옴
                    Label temp = item as Label; //temp와 item이 같은 곳을 가리킨다는 의미
                    //item과 temp라는 변수는 똑같은 곳을 가리킨다.
                    if(temp.Name=="mylabel")
                    {
                        Controls.Remove(temp); //해당 위치가 가리키는 곳을 삭제
                        break;
                    }
                }
            }
        }

        private void abcd_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
