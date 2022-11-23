using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox_input.Text+"를 입력하셨습니다");
        }

        private void button1_customized_Click(object sender, EventArgs e)
        {
            SubForm s = new SubForm(textBox_input.Text);
            s.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_show_Click(object sender, EventArgs e)
        {   //기본 생성자를 이용해서 만든것
            SubForm s = new SubForm();
            s.Show();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
