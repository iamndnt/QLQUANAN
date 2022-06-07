using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLQUANAN.dAL
{
    internal class dalQLNV
    {
        LopDungChung ldc;

        public dalQLNV()
        {
            ldc = new LopDungChung();
        }

        public DataTable LoaddataGrid()
        {
            string sql = "select * from NhanVien";
            return ldc.LoadData(sql);
        }

        public DataTable LoadCombo()
        {
            string sql = "select * from QLChucvu";
            return ldc.LoadData(sql);
        }


        public void daThem(string MaNhanVien, string HoTen, string MaCV, DateTime NgaySinh, string DiaChi)
        {
            string sql = "insert into NhanVien values('" + MaNhanVien + "', N'" + HoTen + "','" + MaCV + "', Convert(Datetime,'" + NgaySinh + "',103),N'" + DiaChi + "')";
          
            ldc.NonQuery(sql);
        }

        public void daSua(string MaNhanVien, string HoTen, string MaCV, DateTime NgaySinh, string DiaChi)
        {
            string sql = "update NhanVien set HoTen =N'" + HoTen + "', MaCV ='" + MaCV + "',NgaySinh = Convert(Datetime,'" + NgaySinh + "', 103), DiaChi =N'" + DiaChi + "' where MaNhanVien='" + MaNhanVien + "'";
            ldc.NonQuery(sql);
        }

        public void daXoa(string MaNhanVien)
        {
            string sql = "delete NhanVien where MaNhanVien='" + MaNhanVien + "'";
            ldc.NonQuery(sql);

        }
    }
}
