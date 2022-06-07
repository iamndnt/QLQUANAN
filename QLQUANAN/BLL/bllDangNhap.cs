using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLQUANAN.BLL
{
    internal class bllDangNhap
    {
        dAL.dALDangNhap dALDangNhap;
        frm_DangKy frm_DangKy;
        frm_DangNhap frm_DangNhap;
        frm_QuenMatKhau frm_QuenMatKhau;

        public bllDangNhap(frm_DangKy frm_DangKy)
        {
            dALDangNhap = new dAL.dALDangNhap();
            this.frm_DangKy=frm_DangKy;
        }

        public bllDangNhap(frm_DangNhap frm_DangNhap)
        {
            dALDangNhap = new dAL.dALDangNhap();
            this.frm_DangNhap=frm_DangNhap;
        }

        public bllDangNhap(frm_QuenMatKhau frm_QuenMatKhau)
        {
            dALDangNhap = new dAL.dALDangNhap();
            this.frm_QuenMatKhau = frm_QuenMatKhau;
        }

        public void bllThem()
        {
            dALDangNhap.dalThem(frm_DangKy.txt_TaiKhoan.Text, frm_DangKy.txt_MatKhau.Text);
        }

        public void bllUpdate()
        {
            dALDangNhap.dalUpdate(frm_QuenMatKhau.txt_TaiKhoan.Text, frm_QuenMatKhau.txt_MatKhauMoi.Text);
        }

        public int bllCheckDN()
        {
            return dALDangNhap.dalScalar(frm_DangNhap.txt_TaiKhoan.Text, frm_DangNhap.txt_MatKhau.Text);
            
        }

        public int bllCheckTaiKhoan()
        {
            return dALDangNhap.dalScalar(frm_QuenMatKhau.txt_TaiKhoan.Text, frm_QuenMatKhau.txt_MatKhauMoi.Text);
        }
    }
}
