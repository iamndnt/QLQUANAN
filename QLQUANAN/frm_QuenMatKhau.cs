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
    public partial class frm_QuenMatKhau : Form
    {
        BLL.bllDangNhap bllDangNhap;
        public frm_QuenMatKhau()
        {
            InitializeComponent();
            bllDangNhap = new BLL.bllDangNhap(this);
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (bllDangNhap.bllCheckTaiKhoan() > 0)
                bllDangNhap.bllUpdate();
            else
                MessageBox.Show("Không có tài khoản nào như trên!");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
