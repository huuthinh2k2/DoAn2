
namespace QLCuaHangThucAnNhanh
{
    partial class Frm_HDBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_xoamonandachon = new System.Windows.Forms.Button();
            this.btn_capnhatmonan = new System.Windows.Forms.Button();
            this.Btn_chonmon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_slmonandachon = new System.Windows.Forms.NumericUpDown();
            this.Cbx_Monan = new System.Windows.Forms.ComboBox();
            this.dgvThucan = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_luuhd = new System.Windows.Forms.Button();
            this.Cbx_timorder = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_inhd = new System.Windows.Forms.Button();
            this.Btn_xoahd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_timhd = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_sdtKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_dcKH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_ngaytao = new System.Windows.Forms.DateTimePicker();
            this.Cbx_ngnhanorder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_thanhtien = new System.Windows.Forms.TextBox();
            this.Cbx_ban = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_slmonandachon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_xoamonandachon
            // 
            this.btn_xoamonandachon.ForeColor = System.Drawing.Color.Red;
            this.btn_xoamonandachon.Location = new System.Drawing.Point(792, 20);
            this.btn_xoamonandachon.Name = "btn_xoamonandachon";
            this.btn_xoamonandachon.Size = new System.Drawing.Size(86, 26);
            this.btn_xoamonandachon.TabIndex = 11;
            this.btn_xoamonandachon.Text = "Xóa";
            this.btn_xoamonandachon.UseVisualStyleBackColor = true;
            this.btn_xoamonandachon.Click += new System.EventHandler(this.btn_xoamonandachon_Click);
            // 
            // btn_capnhatmonan
            // 
            this.btn_capnhatmonan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_capnhatmonan.Location = new System.Drawing.Point(693, 20);
            this.btn_capnhatmonan.Name = "btn_capnhatmonan";
            this.btn_capnhatmonan.Size = new System.Drawing.Size(93, 26);
            this.btn_capnhatmonan.TabIndex = 10;
            this.btn_capnhatmonan.Text = "Cập nhật";
            this.btn_capnhatmonan.UseVisualStyleBackColor = true;
            this.btn_capnhatmonan.Click += new System.EventHandler(this.btn_capnhatmonan_Click);
            // 
            // Btn_chonmon
            // 
            this.Btn_chonmon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_chonmon.Location = new System.Drawing.Point(598, 20);
            this.Btn_chonmon.Name = "Btn_chonmon";
            this.Btn_chonmon.Size = new System.Drawing.Size(89, 26);
            this.Btn_chonmon.TabIndex = 9;
            this.Btn_chonmon.Text = "Thêm";
            this.Btn_chonmon.UseVisualStyleBackColor = true;
            this.Btn_chonmon.Click += new System.EventHandler(this.Btn_chonmon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(399, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng";
            // 
            // nud_slmonandachon
            // 
            this.nud_slmonandachon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_slmonandachon.Location = new System.Drawing.Point(477, 25);
            this.nud_slmonandachon.Name = "nud_slmonandachon";
            this.nud_slmonandachon.Size = new System.Drawing.Size(46, 23);
            this.nud_slmonandachon.TabIndex = 7;
            this.nud_slmonandachon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cbx_Monan
            // 
            this.Cbx_Monan.FormattingEnabled = true;
            this.Cbx_Monan.Location = new System.Drawing.Point(112, 22);
            this.Cbx_Monan.Name = "Cbx_Monan";
            this.Cbx_Monan.Size = new System.Drawing.Size(216, 24);
            this.Cbx_Monan.TabIndex = 6;
            // 
            // dgvThucan
            // 
            this.dgvThucan.AllowUserToAddRows = false;
            this.dgvThucan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaMon,
            this.TenMon,
            this.SLMon,
            this.GiaMon});
            this.dgvThucan.Location = new System.Drawing.Point(6, 20);
            this.dgvThucan.Name = "dgvThucan";
            this.dgvThucan.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvThucan.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThucan.Size = new System.Drawing.Size(912, 150);
            this.dgvThucan.TabIndex = 0;
            this.dgvThucan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucan_CellClick);
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Visible = false;
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã món";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            this.MaMon.Visible = false;
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            // 
            // SLMon
            // 
            this.SLMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SLMon.DataPropertyName = "SLMon";
            this.SLMon.HeaderText = "Số lượng";
            this.SLMon.MinimumWidth = 6;
            this.SLMon.Name = "SLMon";
            this.SLMon.ReadOnly = true;
            // 
            // GiaMon
            // 
            this.GiaMon.DataPropertyName = "GiaMon";
            this.GiaMon.HeaderText = "Đơn giá";
            this.GiaMon.MinimumWidth = 6;
            this.GiaMon.Name = "GiaMon";
            this.GiaMon.ReadOnly = true;
            this.GiaMon.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(35, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên món";
            // 
            // Btn_luuhd
            // 
            this.Btn_luuhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_luuhd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_luuhd.Location = new System.Drawing.Point(12, 448);
            this.Btn_luuhd.Name = "Btn_luuhd";
            this.Btn_luuhd.Size = new System.Drawing.Size(89, 41);
            this.Btn_luuhd.TabIndex = 44;
            this.Btn_luuhd.Text = "Lưu HĐ";
            this.Btn_luuhd.UseVisualStyleBackColor = true;
            this.Btn_luuhd.Click += new System.EventHandler(this.Btn_luuhd_Click);
            // 
            // Cbx_timorder
            // 
            this.Cbx_timorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_timorder.FormattingEnabled = true;
            this.Cbx_timorder.Location = new System.Drawing.Point(96, 517);
            this.Cbx_timorder.Name = "Cbx_timorder";
            this.Cbx_timorder.Size = new System.Drawing.Size(173, 24);
            this.Cbx_timorder.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(18, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Tìm kiếm";
            // 
            // Btn_inhd
            // 
            this.Btn_inhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inhd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_inhd.Location = new System.Drawing.Point(572, 448);
            this.Btn_inhd.Name = "Btn_inhd";
            this.Btn_inhd.Size = new System.Drawing.Size(90, 41);
            this.Btn_inhd.TabIndex = 47;
            this.Btn_inhd.Text = "In HD";
            this.Btn_inhd.UseVisualStyleBackColor = true;
            this.Btn_inhd.Click += new System.EventHandler(this.Btn_inhd_Click);
            // 
            // Btn_xoahd
            // 
            this.Btn_xoahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoahd.ForeColor = System.Drawing.Color.Red;
            this.Btn_xoahd.Location = new System.Drawing.Point(292, 448);
            this.Btn_xoahd.Name = "Btn_xoahd";
            this.Btn_xoahd.Size = new System.Drawing.Size(90, 41);
            this.Btn_xoahd.TabIndex = 46;
            this.Btn_xoahd.Text = "Xóa HĐ";
            this.Btn_xoahd.UseVisualStyleBackColor = true;
            this.Btn_xoahd.Click += new System.EventHandler(this.Btn_xoahd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_xoamonandachon);
            this.groupBox2.Controls.Add(this.btn_capnhatmonan);
            this.groupBox2.Controls.Add(this.Btn_chonmon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nud_slmonandachon);
            this.groupBox2.Controls.Add(this.Cbx_Monan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(924, 58);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng chọn món ăn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvThucan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 176);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thức ăn đã chọn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(283, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 31);
            this.label1.TabIndex = 35;
            this.label1.Text = "Danh mục hóa đơn bán hàng";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_reset.Location = new System.Drawing.Point(429, 448);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(90, 41);
            this.btn_reset.TabIndex = 53;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_thoat.Location = new System.Drawing.Point(710, 448);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(90, 41);
            this.btn_thoat.TabIndex = 54;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_timhd
            // 
            this.btn_timhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timhd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_timhd.Location = new System.Drawing.Point(280, 517);
            this.btn_timhd.Name = "btn_timhd";
            this.btn_timhd.Size = new System.Drawing.Size(82, 24);
            this.btn_timhd.TabIndex = 55;
            this.btn_timhd.Text = "Tìm kiếm";
            this.btn_timhd.UseVisualStyleBackColor = true;
            this.btn_timhd.Click += new System.EventHandler(this.btn_timhd_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.ForeColor = System.Drawing.Color.Red;
            this.btn_huy.Location = new System.Drawing.Point(846, 448);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(90, 41);
            this.btn_huy.TabIndex = 56;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_sdtKH);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_dcKH);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_tenKH);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txt_giamgia);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtp_ngaytao);
            this.groupBox3.Controls.Add(this.Cbx_ngnhanorder);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.Txt_thanhtien);
            this.groupBox3.Controls.Add(this.Cbx_ban);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(12, 327);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(924, 100);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hóa đơn";
            // 
            // txt_sdtKH
            // 
            this.txt_sdtKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdtKH.ForeColor = System.Drawing.Color.Black;
            this.txt_sdtKH.Location = new System.Drawing.Point(776, 66);
            this.txt_sdtKH.MaxLength = 10;
            this.txt_sdtKH.Name = "txt_sdtKH";
            this.txt_sdtKH.Size = new System.Drawing.Size(143, 23);
            this.txt_sdtKH.TabIndex = 76;
            this.txt_sdtKH.TextChanged += new System.EventHandler(this.txt_sdtKH_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(695, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Tổng tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(695, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 75;
            this.label12.Text = "SĐT";
            // 
            // txt_dcKH
            // 
            this.txt_dcKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dcKH.ForeColor = System.Drawing.Color.Black;
            this.txt_dcKH.Location = new System.Drawing.Point(549, 66);
            this.txt_dcKH.Name = "txt_dcKH";
            this.txt_dcKH.Size = new System.Drawing.Size(139, 23);
            this.txt_dcKH.TabIndex = 74;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(474, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 73;
            this.label11.Text = "Địa chỉ";
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.ForeColor = System.Drawing.Color.Black;
            this.txt_tenKH.Location = new System.Drawing.Point(337, 66);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(128, 23);
            this.txt_tenKH.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(242, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 71;
            this.label10.Text = " Tên khách";
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giamgia.ForeColor = System.Drawing.Color.Red;
            this.txt_giamgia.Location = new System.Drawing.Point(550, 24);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(138, 23);
            this.txt_giamgia.TabIndex = 70;
            this.txt_giamgia.TextChanged += new System.EventHandler(this.txt_giamgia_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(474, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 69;
            this.label5.Text = "Giảm giá";
            // 
            // dtp_ngaytao
            // 
            this.dtp_ngaytao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaytao.Location = new System.Drawing.Point(337, 24);
            this.dtp_ngaytao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_ngaytao.Name = "dtp_ngaytao";
            this.dtp_ngaytao.Size = new System.Drawing.Size(128, 23);
            this.dtp_ngaytao.TabIndex = 68;
            // 
            // Cbx_ngnhanorder
            // 
            this.Cbx_ngnhanorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_ngnhanorder.FormattingEnabled = true;
            this.Cbx_ngnhanorder.Location = new System.Drawing.Point(84, 66);
            this.Cbx_ngnhanorder.Name = "Cbx_ngnhanorder";
            this.Cbx_ngnhanorder.Size = new System.Drawing.Size(144, 24);
            this.Cbx_ngnhanorder.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(242, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Ngày tạo";
            // 
            // Txt_thanhtien
            // 
            this.Txt_thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_thanhtien.ForeColor = System.Drawing.Color.Red;
            this.Txt_thanhtien.Location = new System.Drawing.Point(776, 24);
            this.Txt_thanhtien.Name = "Txt_thanhtien";
            this.Txt_thanhtien.ReadOnly = true;
            this.Txt_thanhtien.Size = new System.Drawing.Size(143, 23);
            this.Txt_thanhtien.TabIndex = 64;
            this.Txt_thanhtien.TextChanged += new System.EventHandler(this.Txt_thanhtien_TextChanged);
            // 
            // Cbx_ban
            // 
            this.Cbx_ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbx_ban.FormattingEnabled = true;
            this.Cbx_ban.Location = new System.Drawing.Point(84, 24);
            this.Cbx_ban.Name = "Cbx_ban";
            this.Cbx_ban.Size = new System.Drawing.Size(144, 24);
            this.Cbx_ban.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 61;
            this.label6.Text = "Bàn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(3, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 65;
            this.label9.Text = "Người tạo";
            // 
            // Btn_edit
            // 
            this.Btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_edit.Location = new System.Drawing.Point(151, 448);
            this.Btn_edit.Name = "Btn_edit";
            this.Btn_edit.Size = new System.Drawing.Size(89, 41);
            this.Btn_edit.TabIndex = 62;
            this.Btn_edit.Text = "Chỉnh sửa";
            this.Btn_edit.UseVisualStyleBackColor = true;
            this.Btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // Frm_HDBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 569);
            this.Controls.Add(this.Btn_edit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_timhd);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.Btn_luuhd);
            this.Controls.Add(this.Cbx_timorder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btn_inhd);
            this.Controls.Add(this.Btn_xoahd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_HDBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DatMon_FormClosing);
            this.Load += new System.EventHandler(this.Frm_HDBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_slmonandachon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_xoamonandachon;
        private System.Windows.Forms.Button btn_capnhatmonan;
        private System.Windows.Forms.Button Btn_chonmon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_slmonandachon;
        private System.Windows.Forms.ComboBox Cbx_Monan;
        private System.Windows.Forms.DataGridView dgvThucan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_luuhd;
        private System.Windows.Forms.ComboBox Cbx_timorder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_inhd;
        private System.Windows.Forms.Button Btn_xoahd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_timhd;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_ngaytao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cbx_ngnhanorder;
        private System.Windows.Forms.TextBox Txt_thanhtien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Cbx_ban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_sdtKH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_dcKH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMon;
    }
}