using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market_POS
{
    public partial class Form2 : Form
    {
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        DataTable table = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            string connect = string.Format("Data Source={0};" +
              "Initial Catalog = {1};" +
              "Persist Security Info = True;" +
              "User ID=us;Password=1234",
              "192.168.0.106,1433", "MarketPos");
            conn = new SqlConnection(connect);

            try
            {
                conn.Open(); //db 연결

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn; //어디에 커맨드 보낼지 지정
                cmd.CommandText = "select * from sales_tb;";
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "sales_tb");
                // da.Fill(ds, "[인천광역시 서구_물가정보_20210907]");
                dt = ds.Tables[0];
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "select");
                System.Windows.Forms.MessageBox.Show(e.StackTrace + "select");
                //DataManager.printLog("select" + e.StackTrace);
                return;
            }
            finally
            {
                conn.Close(); //db 연결 해제
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
