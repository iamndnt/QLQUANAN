namespace QLQUANAN
{
    partial class frm_NhanVien
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
            this.dt_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cb_ChucVu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MSNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_NgaySinh
            // 
            this.dt_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dt_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dt_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_NgaySinh.Location = new System.Drawing.Point(339, 272);
            this.dt_NgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_NgaySinh.Name = "dt_NgaySinh";
            this.dt_NgaySinh.Size = new System.Drawing.Size(405, 30);
            this.dt_NgaySinh.TabIndex = 31;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.White;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btn_Thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.Teal;
            this.btn_Thoat.Location = new System.Drawing.Point(704, 406);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(107, 46);
            this.btn_Thoat.TabIndex = 29;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.White;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btn_Xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.Teal;
            this.btn_Xoa.Location = new System.Drawing.Point(532, 406);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(107, 46);
            this.btn_Xoa.TabIndex = 28;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.White;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btn_Sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.ForeColor = System.Drawing.Color.Teal;
            this.btn_Sua.Location = new System.Drawing.Point(339, 406);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(107, 46);
            this.btn_Sua.TabIndex = 27;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.White;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btn_Them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.ForeColor = System.Drawing.Color.Teal;
            this.btn_Them.Location = new System.Drawing.Point(169, 406);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(107, 46);
            this.btn_Them.TabIndex = 26;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cb_ChucVu
            // 
            this.cb_ChucVu.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cb_ChucVu.FormattingEnabled = true;
            this.cb_ChucVu.Location = new System.Drawing.Point(336, 346);
            this.cb_ChucVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_ChucVu.Name = "cb_ChucVu";
            this.cb_ChucVu.Size = new System.Drawing.Size(405, 32);
            this.cb_ChucVu.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(191, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(177, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày sinh";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DiaChi.Location = new System.Drawing.Point(339, 207);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(405, 32);
            this.txt_DiaChi.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(204, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "Địa chỉ";
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HoTen.Location = new System.Drawing.Point(339, 138);
            this.txt_HoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(405, 32);
            this.txt_HoTen.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Họ và tên";
            // 
            // txt_MSNV
            // 
            this.txt_MSNV.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MSNV.Location = new System.Drawing.Point(339, 69);
            this.txt_MSNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MSNV.Name = "txt_MSNV";
            this.txt_MSNV.Size = new System.Drawing.Size(405, 32);
            this.txt_MSNV.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(124, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã số nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(328, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 462);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(891, 185);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(975, 661);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dt_NgaySinh);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.cb_ChucVu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_MSNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dt_NgaySinh;
        public System.Windows.Forms.Button btn_Thoat;
        public System.Windows.Forms.Button btn_Xoa;
        public System.Windows.Forms.Button btn_Sua;
        public System.Windows.Forms.Button btn_Them;
        public System.Windows.Forms.ComboBox cb_ChucVu;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_DiaChi;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_HoTen;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_MSNV;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}