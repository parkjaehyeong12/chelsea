using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 학생관리
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Student> students = new List<Student>();
            students.Add(new Student() { name="박재형", grade=1});
            students.Add(new Student() { name="김성환", grade=2});
            students.Add(new Student() { name="노민영", grade=3});
            students.Add(new Student() { name="도광현", grade=4});
            students.Add(new Student() { name="안서준", grade=1});
            students.Add(new Student() { name="장혜정", grade=2});

            for (int i = 0; i < students.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name} 학생";
                label.AutoSize = true;
                label.Location = new Point(13,13+26*i);
                Controls.Add(label);
            }
            for (int i = students.Count-1; i >=0; i--)
            {
                if (students[i].grade > 1)
                    students.RemoveAt(i);
            }
            for (int i = 0; i < students.Count; i++)
            {
                Label label = new Label();
                label.Text = $"{students[i].grade}학년 {students[i].name} 학생";
                label.AutoSize = true;
                label.Location = new Point(130, 13 + 26 * i);
                Controls.Add(label);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
