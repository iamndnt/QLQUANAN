using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLQUANAN.BLL
{
    internal class bllQLNV
    {
        dAL.dalQLNV dal_QLNV;
        frm_NhanVien frmNhanVien;

        public bllQLNV(frm_NhanVien frm_NhanVien)
        {
            dal_QLNV = new dAL.dalQLNV();
            this.frmNhanVien = frm_NhanVien;
        }

        public DataTable LoaddataGrid()
        {
            return dal_QLNV.LoaddataGrid();
        }
        public DataTable LoadCombo()
        {
            return dal_QLNV.LoadCombo();
        }

        public void bblThem()
        {
            

            dal_QLNV.daThem(frmNhanVien.txt_MSNV.Text, frmNhanVien.txt_HoTen.Text, frmNhanVien.cb_ChucVu.SelectedValue.ToString(), frmNhanVien.dt_NgaySinh.Value.Date, frmNhanVien.txt_DiaChi.Text);

        }

        public void bblSua()
        {
            dal_QLNV.daSua(frmNhanVien.txt_MSNV.Text, frmNhanVien.txt_HoTen.Text, frmNhanVien.cb_ChucVu.SelectedValue.ToString(), frmNhanVien.dt_NgaySinh.Value, frmNhanVien.txt_DiaChi.Text);


        }
        public void bllXoa()
        {
            dal_QLNV.daXoa(frmNhanVien.txt_MSNV.Text);
        }
    }
}
