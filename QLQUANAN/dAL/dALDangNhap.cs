using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace QLQUANAN.dAL
{
    internal class dALDangNhap
    {
        LopDungChung ldc;

        public dALDangNhap()
        {
            ldc = new LopDungChung();
        }

        public DataTable dataLoadGrid()
        {
            string sql = "select * DangNhap";
            return ldc.LoadData(sql);
        }

        public void dalThem(string TenDangNhap,string MatKhau)
        {
            string sql = "insert into DangNhap values('" + TenDangNhap + "','" + MatKhau + "')";
            ldc.NonQuery(sql);
        }

        public void dalDelete(string TenDangNhap)
        {
            string sql = "delete DangNhap where TenDangNhap='" + TenDangNhap + "'";
            ldc.NonQuery(sql);
        }

        public void dalUpdate(string TenDangNhap,string matkhau)
        {
            string sql = "update DangNhap set MatKhau='"+matkhau+"' where TenDangNhap='"+TenDangNhap+"'";
            ldc.NonQuery(sql);
        }

        public int dalScalar(string TenDangNhap, string matkhau)
        {
            string sql = "";
            if (matkhau == "")
                sql = "select count (*) from DangNhap where TenDangNhap='" + TenDangNhap + "'";
            else
                sql = "select count (*) from DangNhap where TenDangNhap='" + TenDangNhap + "' and MatKhau='"+matkhau+"'";
          
            return ldc.Scalar(sql);
        }
    }
}
