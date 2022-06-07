namespace QLQUANAN
{
    partial class frm_TrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanlynhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.thucdonmon = new System.Windows.Forms.ToolStripMenuItem();
            this.danhmucmon = new System.Windows.Forms.ToolStripMenuItem();
            this.monan = new System.Windows.Forms.ToolStripMenuItem();
            this.hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.gioithieu = new System.Windows.Forms.ToolStripMenuItem();
            this.dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlynhanvien,
            this.thucdonmon,
            this.hethong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanlynhanvien
            // 
            this.quanlynhanvien.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.quanlynhanvien.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.quanlynhanvien.Name = "quanlynhanvien";
            this.quanlynhanvien.Size = new System.Drawing.Size(205, 33);
            this.quanlynhanvien.Text = "Quản lý nhân viên";
            this.quanlynhanvien.Click += new System.EventHandler(this.quanlynhanvien_Click);
            // 
            // thucdonmon
            // 
            this.thucdonmon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhmucmon,
            this.monan});
            this.thucdonmon.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.thucdonmon.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.thucdonmon.Name = "thucdonmon";
            this.thucdonmon.Size = new System.Drawing.Size(164, 33);
            this.thucdonmon.Text = "Thực đơn món";
            // 
            // danhmucmon
            // 
            this.danhmucmon.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.danhmucmon.Name = "danhmucmon";
            this.danhmucmon.Size = new System.Drawing.Size(247, 34);
            this.danhmucmon.Text = "Danh mục món";
            this.danhmucmon.Click += new System.EventHandler(this.danhmucmon_Click);
            // 
            // monan
            // 
            this.monan.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.monan.Name = "monan";
            this.monan.Size = new System.Drawing.Size(247, 34);
            this.monan.Text = "Món ăn";
            this.monan.Click += new System.EventHandler(this.monan_Click);
            // 
            // hethong
            // 
            this.hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gioithieu,
            this.dangxuat});
            this.hethong.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.hethong.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.hethong.Name = "hethong";
            this.hethong.Size = new System.Drawing.Size(116, 33);
            this.hethong.Text = "Hệ thống";
            // 
            // gioithieu
            // 
            this.gioithieu.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.gioithieu.Name = "gioithieu";
            this.gioithieu.Size = new System.Drawing.Size(224, 34);
            this.gioithieu.Text = "Giới thiệu";
            this.gioithieu.Click += new System.EventHandler(this.gioithieu_Click);
            // 
            // dangxuat
            // 
            this.dangxuat.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.dangxuat.Name = "dangxuat";
            this.dangxuat.Size = new System.Drawing.Size(224, 34);
            this.dangxuat.Text = "Đăng xuất";
            this.dangxuat.Click += new System.EventHandler(this.dangxuat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 388);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_TrangChu";
            this.Text = "Trang chủ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanlynhanvien;
        private System.Windows.Forms.ToolStripMenuItem thucdonmon;
        private System.Windows.Forms.ToolStripMenuItem danhmucmon;
        private System.Windows.Forms.ToolStripMenuItem monan;
        private System.Windows.Forms.ToolStripMenuItem hethong;
        private System.Windows.Forms.ToolStripMenuItem gioithieu;
        private System.Windows.Forms.ToolStripMenuItem dangxuat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}