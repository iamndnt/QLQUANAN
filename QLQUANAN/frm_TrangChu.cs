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
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private void quanlynhanvien_Click(object sender, EventArgs e)
        {
            frm_NhanVien frm_NhanVien = new frm_NhanVien();
            frm_NhanVien.Show();
        }

        private void danhmucmon_Click(object sender, EventArgs e)
        {
            frm_DanhMucMon frm_DanhMucMon = new frm_DanhMucMon();
            frm_DanhMucMon.Show();
        }

        private void monan_Click(object sender, EventArgs e)
        {
            frm_MonAn frm_MonAn = new frm_MonAn();
            frm_MonAn.Show();
        }

        private void gioithieu_Click(object sender, EventArgs e)
        {
            frm_GioiThieu frm_GioiThieu = new frm_GioiThieu();
            frm_GioiThieu.Show();
        }

        private void dangxuat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
