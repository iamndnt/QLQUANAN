using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace QLQUANAN
{
    class LopDungChung
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Learning\QLQUANAN\QLQUANAN\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public DataTable LoadData(string sqlData)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlData, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void NonQuery(string sqlNonQuery)
        {
            SqlCommand comm = new SqlCommand(sqlNonQuery, conn);
            conn.Open();
            int ketqua = comm.ExecuteNonQuery();
            conn.Close();
            if (ketqua >= 1)
            {
                MessageBox.Show("thành công");
            }
            else
            {
                MessageBox.Show("thất bại");
            }
        }
        public int Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
    }
}
