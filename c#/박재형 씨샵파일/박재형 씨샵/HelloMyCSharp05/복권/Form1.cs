using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 복권
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public List<string> list = new List<string>();
        public string [] bb = new string[6];
        Label label01 = new Label();
        Label label02 = new Label();
        public Form1()
        {
            InitializeComponent();
        }

        //예상번호
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count<6)
            {
            string aaa=   random.Next(1,46).ToString();
            /* list.Add(aaa);
             foreach (var item in list)
             {

             }*/
            int a = 1;

                /*    for (int i = 0; i < bb.Length; i++)
                {
                    if (aaa.Equals(bb[i]))
                        a = 0;
                    if (a != 0)
                    {
                 //       bb[bb.Length] = aaa;
                    list.Add(aaa);
                     count++;
                    }
                }
                 */
                foreach (var item in list)
                {
                    if (item.Equals(aaa))
                    {
                        a = 0;
                    }
                }
                if (a == 1)
                {
                    list.Add(aaa);
                    count++;
                }

            }
            


            /*
              for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (int.Parse(bb[i]) < int.Parse(bb[j]))
                    {
                        string temp = bb[i];
                        bb[i] = bb[j];
                        bb[j] = temp;
                    }
                }
            }*/

            /*
             *  for (int i = 0; i < 6; i++)
            {
                label01.Text = bb[i] + " ";
            }
            Controls.Add(label01);
             */


            foreach (var item in list)
             {
                    label01.Text+=item + " ";
             }
                Controls.Add(label01);
        }

        //내 번호
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
