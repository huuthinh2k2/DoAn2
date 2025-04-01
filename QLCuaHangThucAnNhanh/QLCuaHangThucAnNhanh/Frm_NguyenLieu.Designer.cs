
namespace QLCuaHangThucAnNhanh
{
    partial class Frm_NguyenLieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNguyenlieu = new System.Windows.Forms.DataGridView();
            this.MaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonKhoNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_xoanguyenlieu = new System.Windows.Forms.Button();
            this.Btn_Capnhatnguyenlieu = new System.Windows.Forms.Button();
            this.Btn_themnguyenlieu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_tennguyenlieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_donvi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_tonkhonl = new System.Windows.Forms.NumericUpDown();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenlieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tonkhonl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(255, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 39);
            this.label1.TabIndex = 45;
            this.label1.Text = "Danh mục nguyên liệu";
            // 
            // dgvNguyenlieu
            // 
            this.dgvNguyenlieu.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvNguyenlieu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNguyenlieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenlieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNL,
            this.TenNL,
            this.TonKhoNL,
            this.DonVi});
            this.dgvNguyenlieu.Location = new System.Drawing.Point(6, 23);
            this.dgvNguyenlieu.Name = "dgvNguyenlieu";
            this.dgvNguyenlieu.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvNguyenlieu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNguyenlieu.Size = new System.Drawing.Size(845, 233);
            this.dgvNguyenlieu.TabIndex = 0;
            this.dgvNguyenlieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguyenlieu_CellClick);
            // 
            // MaNL
            // 
            this.MaNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNL.DataPropertyName = "MaNL";
            this.MaNL.HeaderText = "Mã nguyên liệu";
            this.MaNL.MinimumWidth = 6;
            this.MaNL.Name = "MaNL";
            this.MaNL.ReadOnly = true;
            this.MaNL.Visible = false;
            // 
            // TenNL
            // 
            this.TenNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNL.DataPropertyName = "TenNL";
            this.TenNL.HeaderText = "Tên nguyên liệu";
            this.TenNL.MinimumWidth = 6;
            this.TenNL.Name = "TenNL";
            this.TenNL.ReadOnly = true;
            // 
            // TonKhoNL
            // 
            this.TonKhoNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TonKhoNL.DataPropertyName = "TonKhoNL";
            this.TonKhoNL.HeaderText = "Tồn kho";
            this.TonKhoNL.MinimumWidth = 6;
            this.TonKhoNL.Name = "TonKhoNL";
            this.TonKhoNL.ReadOnly = true;
            // 
            // DonVi
            // 
            this.DonVi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonVi.DataPropertyName = "DonVi";
            this.DonVi.HeaderText = "Đơn vị tính";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // Btn_xoanguyenlieu
            // 
            this.Btn_xoanguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_xoanguyenlieu.ForeColor = System.Drawing.Color.Red;
            this.Btn_xoanguyenlieu.Location = new System.Drawing.Point(391, 426);
            this.Btn_xoanguyenlieu.Name = "Btn_xoanguyenlieu";
            this.Btn_xoanguyenlieu.Size = new System.Drawing.Size(90, 34);
            this.Btn_xoanguyenlieu.TabIndex = 49;
            this.Btn_xoanguyenlieu.Text = "Xóa";
            this.Btn_xoanguyenlieu.UseVisualStyleBackColor = true;
            this.Btn_xoanguyenlieu.Click += new System.EventHandler(this.Btn_xoanguyenlieu_Click);
            // 
            // Btn_Capnhatnguyenlieu
            // 
            this.Btn_Capnhatnguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Capnhatnguyenlieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_Capnhatnguyenlieu.Location = new System.Drawing.Point(236, 426);
            this.Btn_Capnhatnguyenlieu.Name = "Btn_Capnhatnguyenlieu";
            this.Btn_Capnhatnguyenlieu.Size = new System.Drawing.Size(97, 34);
            this.Btn_Capnhatnguyenlieu.TabIndex = 48;
            this.Btn_Capnhatnguyenlieu.Text = "Cập nhật";
            this.Btn_Capnhatnguyenlieu.UseVisualStyleBackColor = true;
            this.Btn_Capnhatnguyenlieu.Click += new System.EventHandler(this.Btn_Capnhatnguyenlieu_Click);
            // 
            // Btn_themnguyenlieu
            // 
            this.Btn_themnguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_themnguyenlieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_themnguyenlieu.Location = new System.Drawing.Point(87, 426);
            this.Btn_themnguyenlieu.Name = "Btn_themnguyenlieu";
            this.Btn_themnguyenlieu.Size = new System.Drawing.Size(90, 34);
            this.Btn_themnguyenlieu.TabIndex = 47;
            this.Btn_themnguyenlieu.Text = "Thêm";
            this.Btn_themnguyenlieu.UseVisualStyleBackColor = true;
            this.Btn_themnguyenlieu.Click += new System.EventHandler(this.Btn_themnguyenlieu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNguyenlieu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 262);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nguyên liệu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(50, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tên nguyên liệu";
            // 
            // Txt_tennguyenlieu
            // 
            this.Txt_tennguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_tennguyenlieu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Txt_tennguyenlieu.Location = new System.Drawing.Point(197, 29);
            this.Txt_tennguyenlieu.Name = "Txt_tennguyenlieu";
            this.Txt_tennguyenlieu.Size = new System.Drawing.Size(184, 26);
            this.Txt_tennguyenlieu.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(325, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(405, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Tồn kho";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_donvi);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nud_tonkhonl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Txt_tennguyenlieu);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 71);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nguyên liệu";
            // 
            // cbx_donvi
            // 
            this.cbx_donvi.FormattingEnabled = true;
            this.cbx_donvi.Location = new System.Drawing.Point(684, 27);
            this.cbx_donvi.Name = "cbx_donvi";
            this.cbx_donvi.Size = new System.Drawing.Size(121, 28);
            this.cbx_donvi.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(579, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Đơn vị tính";
            // 
            // nud_tonkhonl
            // 
            this.nud_tonkhonl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_tonkhonl.Location = new System.Drawing.Point(486, 29);
            this.nud_tonkhonl.Name = "nud_tonkhonl";
            this.nud_tonkhonl.Size = new System.Drawing.Size(65, 26);
            this.nud_tonkhonl.TabIndex = 28;
            this.nud_tonkhonl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_boqua
            // 
            this.btn_boqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_boqua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_boqua.Location = new System.Drawing.Point(541, 426);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(90, 34);
            this.btn_boqua.TabIndex = 51;
            this.btn_boqua.Text = "Reset";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_dong.Location = new System.Drawing.Point(691, 426);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(90, 34);
            this.btn_dong.TabIndex = 52;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(250, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 55;
            this.button2.Text = "Tìm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(9, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(87, 489);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(147, 26);
            this.txt_timkiem.TabIndex = 53;
            // 
            // Frm_NguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_boqua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_xoanguyenlieu);
            this.Controls.Add(this.Btn_Capnhatnguyenlieu);
            this.Controls.Add(this.Btn_themnguyenlieu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_NguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nguyên liệu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_NguyenLieu_FormClosing);
            this.Load += new System.EventHandler(this.Frm_NguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenlieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tonkhonl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNguyenlieu;
        private System.Windows.Forms.Button Btn_xoanguyenlieu;
        private System.Windows.Forms.Button Btn_Capnhatnguyenlieu;
        private System.Windows.Forms.Button Btn_themnguyenlieu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_tennguyenlieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nud_tonkhonl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.ComboBox cbx_donvi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonKhoNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonVi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_timkiem;
    }
}