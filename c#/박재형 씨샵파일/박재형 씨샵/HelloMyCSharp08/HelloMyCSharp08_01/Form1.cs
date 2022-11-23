using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloMyCSharp08_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { id = 1, price=1000, name="감자" });
            products.Add(new Product() { id = 3, price=500, name="파" });
            products.Add(new Product() { id = 2, price=100, name="젤리" });

            //CompareTo가 정의x -> products 정렬 x
            //but 정의딤-> Sort에서는 내부적으로 CompareTo호출

            products.Sort();
            
            foreach (Product p in products)
            {
                MessageBox.Show($"{p.name}");
            }
        }
    }
}
