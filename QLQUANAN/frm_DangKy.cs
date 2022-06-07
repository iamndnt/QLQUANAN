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
    public partial class frm_DangKy : Form
    {
        BLL.bllDangNhap bllDangNhap;
        public frm_DangKy()
        {
            InitializeComponent();
            bllDangNhap = new BLL.bllDangNhap(this);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
              bllDangNhap.bllThem();

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
