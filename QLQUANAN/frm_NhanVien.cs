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
    public partial class frm_NhanVien : Form
    {
        BLL.bllQLNV bll_QLNV;
        public frm_NhanVien()
        {
            InitializeComponent();
            bll_QLNV = new BLL.bllQLNV(this);
            loadCombo();
            loadNV();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            bll_QLNV.bblThem();
            loadNV();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            bll_QLNV.bblSua();
            loadNV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            bll_QLNV.bllXoa();
            loadNV();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSNV.Text = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            cb_ChucVu.SelectedValue = dataGridView1.CurrentRow.Cells["MaCV"].Value.ToString();
            dt_NgaySinh.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
        }

        void loadNV()
        {

            dataGridView1.DataSource = bll_QLNV.LoaddataGrid();
            dataGridView1.Columns[0].HeaderText = "Mã Nhân Viên";
            dataGridView1.Columns[1].HeaderText = "Tên Nhân Viên";
            dataGridView1.Columns[2].HeaderText = "Mã Chúc Vụ";
            dataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            dataGridView1.Columns[4].HeaderText = "Địa Chỉ";

        }

        public void loadCombo()
        {
            cb_ChucVu.DataSource = bll_QLNV.LoadCombo();
            cb_ChucVu.DisplayMember = "ChucVu";
            cb_ChucVu.ValueMember = "MaCV";

        }

     

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_MSNV.Text = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString();
            cb_ChucVu.SelectedValue = dataGridView1.CurrentRow.Cells["MaCV"].Value.ToString();
            dt_NgaySinh.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_DiaChi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
        }

        
    }
}
