using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLQUANAN
{
    public partial class frm_DangNhap : Form
    {
        BLL.bllDangNhap bllDangNhap;
        public frm_DangNhap()
        {
            InitializeComponent();
            bllDangNhap = new BLL.bllDangNhap(this);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(bllDangNhap.bllCheckDN()>0)
            {
                frm_TrangChu frm_TrangChu = new frm_TrangChu();
                frm_TrangChu.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!");
            }
        }

        private void ck_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_HienThiMK.Checked == true)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DangKyTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DangKy frm_DangKy = new frm_DangKy();
            frm_DangKy.Show();
        }

        private void quenmatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_QuenMatKhau frm_QuenMatKhau = new frm_QuenMatKhau();
            frm_QuenMatKhau.Show();
        }
    }
}
