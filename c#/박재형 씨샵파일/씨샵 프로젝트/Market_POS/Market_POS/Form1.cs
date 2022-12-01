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
    public partial class Form1 : Form
    {
        private static SqlConnection conn = new SqlConnection();
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        DataTable table = new DataTable();
        public static void ConnectDB()
        {//접속해주는 함수
            try
            {
                string connect = string.Format("Data Source={0};" +
                "Initial Catalog = {1};" +
                "Persist Security Info = True;" +
                "User ID=us;Password=1234",
                "192.168.0.106,1433", "MarketPos");
                conn = new SqlConnection(connect);
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("connect Fail");
            }
        }

        public static void selectQuery()
        {
            try
            {
                ConnectDB(); //db 연결

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
        }


        public Form1()
        {
            InitializeComponent();
            //행 생성
            selectQuery();

            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Count", typeof(string));
            table.Columns.Add("Total", typeof(string));

            dataGridView1.DataSource = table;
            numericUpDown1.Value = 1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        //string sqlcon = "Data Source = 192.168.0.106; Initial Catalog= DataBase; User "
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void 판매내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void 재고현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void 물가조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //행 지우기
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            //합계창에 수정된 값 넣기
            decimal all = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                all += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            }

            textBox3.Text = all.ToString();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("항목을 정확히 입력해주세요");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                //합계를 구하기 위해 품목명과 가격을 정의하고 total로 합침
                decimal price = decimal.Parse(textBox2.Text);
                decimal count = numericUpDown1.Value;
                decimal total = price * count;

                //text박스내의 정보를 표에 삽입
                table.Rows.Add(textBox1.Text, textBox2.Text, numericUpDown1.Value, total);
                dataGridView1.DataSource = table;

                //text박스의 정보 초기화
                textBox1.Clear();
                textBox2.Clear();
                numericUpDown1.Value = 1;

                //합계
                decimal all = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                     {
                    all += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }
                textBox3.Text = all.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
       {
         
                //각 행의 정보를 반복문으로 불러온다
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    String Name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    String Price = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    String Count = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    String Total = dataGridView1.Rows[i].Cells[3].Value.ToString();

                    //INSERT INTO 쿼리문으로 받아온 정보를 DB에 전송한다. 
                    string sql = string.Format("INSERT INTO sales_tb(name,price,count,total,c_num) VALUES  ('{0}',{1},{2},{3},{4})", @Name, @Price, @Count, @Total, @i+1);

          
                //DB전송을 진행하고 실패시 에러메세지 출력
                try
                    {
                    ConnectDB();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                finally
                {
                    conn.Close(); //db 연결 해제
                }
                MessageBox.Show($"{sql}");
            }           

            MessageBox.Show("계산되었습니다.");

            //데이터 그리드뷰 초기화
            int rowCount = dataGridView1.Rows.Count;
            for (int n = 0; n < rowCount; n++)
            {
                if (dataGridView1.Rows[0].IsNewRow == false)
                    dataGridView1.Rows.RemoveAt(0);
            }

            //합계창 초기화
            textBox3.Text = "0";
        }
        
    }
}
