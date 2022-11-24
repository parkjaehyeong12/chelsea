using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 학생
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /* dataGridView1.Columns.Add("name", "이름");
            dataGridView1.Columns.Add("number", "번호");
            dataGridView1.Columns.Add("gender", "성별");*/







        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studentbindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        List<Student> students = new List<Student>();
        private void button1_Click(object sender, EventArgs e)
        {
            students.Add(new Student() { name = textBox1.Text, number = textBox2.Text, gender = textBox3.Text });
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete_dataGridView(dataGridView1);
            Console.WriteLine(dataGridView1.SelectedRows.Count);
            MessageBox.Show(dataGridView1.SelectedRows.Count.ToString());
            
        
        }
        }
    }

