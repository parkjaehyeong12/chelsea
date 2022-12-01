using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_POS
{
    public class DBHelper
    {
        //DB연결 부분
        private static SqlConnection conn = new SqlConnection();

        //DB에 있는 데이터를 가져 오는 부분들
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;
        //db 열고 -> crud 수행 -> db 닫아줌

        private static void ConnectDB()
        {
            string dataSource = "192.168.0.106";
            string db = "MarketPos";
            string security = "SSPI";
            conn.ConnectionString = string.Format
                ("Data Source=({0}); initial Catalog={1}; " +
                "integrated Security = {2};" +
                "Timeout=3", dataSource, db, security);
            conn = new SqlConnection(conn.ConnectionString);
            conn.Open();
        }
    }
}
