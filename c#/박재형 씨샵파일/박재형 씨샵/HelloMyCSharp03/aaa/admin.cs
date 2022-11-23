using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp03_1
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        public admin(string text1, string text2)
        {
            InitializeComponent();
            if (text1 == "admin" && text2 == "1234")
                label1.Text = "관리자님 환영합니다.";
            else
                label1.Text = "누구십니까";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
