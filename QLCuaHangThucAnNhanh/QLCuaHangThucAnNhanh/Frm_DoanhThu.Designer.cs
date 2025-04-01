
namespace QLCuaHangThucAnNhanh
{
    partial class Frm_DoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.dtpngaycuoi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ngaydau = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_doanhthu = new System.Windows.Forms.Label();
            this.lb_nguyenlieu = new System.Windows.Forms.Label();
            this.txt_tbdoangthu = new System.Windows.Forms.Label();
            this.txt_loinhuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nguyenlieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_doanhthu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_inhd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(338, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Thống kê doanh thu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thongke);
            this.groupBox1.Controls.Add(this.dtpngaycuoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_ngaydau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 133);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thống kê";
            // 
            // btn_thongke
            // 
            this.btn_thongke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_thongke.Location = new System.Drawing.Point(386, 81);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(94, 35);
            this.btn_thongke.TabIndex = 37;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // dtpngaycuoi
            // 
            this.dtpngaycuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaycuoi.Location = new System.Drawing.Point(494, 42);
            this.dtpngaycuoi.Name = "dtpngaycuoi";
            this.dtpngaycuoi.Size = new System.Drawing.Size(236, 23);
            this.dtpngaycuoi.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(419, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(383, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Thống kê từ";
            // 
            // dtp_ngaydau
            // 
            this.dtp_ngaydau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngaydau.Location = new System.Drawing.Point(135, 42);
            this.dtp_ngaydau.Name = "dtp_ngaydau";
            this.dtp_ngaydau.Size = new System.Drawing.Size(236, 23);
            this.dtp_ngaydau.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_doanhthu);
            this.groupBox2.Controls.Add(this.lb_nguyenlieu);
            this.groupBox2.Controls.Add(this.txt_tbdoangthu);
            this.groupBox2.Controls.Add(this.txt_loinhuan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_nguyenlieu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_doanhthu);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(13, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 105);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng thống kê";
            // 
            // lb_doanhthu
            // 
            this.lb_doanhthu.AutoSize = true;
            this.lb_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doanhthu.Location = new System.Drawing.Point(92, 85);
            this.lb_doanhthu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_doanhthu.Name = "lb_doanhthu";
            this.lb_doanhthu.Size = new System.Drawing.Size(41, 13);
            this.lb_doanhthu.TabIndex = 43;
            this.lb_doanhthu.Text = "label8";
            // 
            // lb_nguyenlieu
            // 
            this.lb_nguyenlieu.AutoSize = true;
            this.lb_nguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nguyenlieu.Location = new System.Drawing.Point(412, 86);
            this.lb_nguyenlieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nguyenlieu.Name = "lb_nguyenlieu";
            this.lb_nguyenlieu.Size = new System.Drawing.Size(41, 13);
            this.lb_nguyenlieu.TabIndex = 42;
            this.lb_nguyenlieu.Text = "label8";
            // 
            // txt_tbdoangthu
            // 
            this.txt_tbdoangthu.AutoSize = true;
            this.txt_tbdoangthu.Location = new System.Drawing.Point(92, 85);
            this.txt_tbdoangthu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_tbdoangthu.Name = "txt_tbdoangthu";
            this.txt_tbdoangthu.Size = new System.Drawing.Size(0, 17);
            this.txt_tbdoangthu.TabIndex = 41;
            // 
            // txt_loinhuan
            // 
            this.txt_loinhuan.ForeColor = System.Drawing.Color.Red;
            this.txt_loinhuan.Location = new System.Drawing.Point(685, 47);
            this.txt_loinhuan.Name = "txt_loinhuan";
            this.txt_loinhuan.ReadOnly = true;
            this.txt_loinhuan.Size = new System.Drawing.Size(179, 23);
            this.txt_loinhuan.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(599, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Lợi nhuận";
            // 
            // txt_nguyenlieu
            // 
            this.txt_nguyenlieu.ForeColor = System.Drawing.Color.Red;
            this.txt_nguyenlieu.Location = new System.Drawing.Point(406, 47);
            this.txt_nguyenlieu.Name = "txt_nguyenlieu";
            this.txt_nguyenlieu.ReadOnly = true;
            this.txt_nguyenlieu.Size = new System.Drawing.Size(179, 23);
            this.txt_nguyenlieu.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(280, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Phí nguyên liệu";
            // 
            // txt_doanhthu
            // 
            this.txt_doanhthu.ForeColor = System.Drawing.Color.Red;
            this.txt_doanhthu.Location = new System.Drawing.Point(95, 47);
            this.txt_doanhthu.Name = "txt_doanhthu";
            this.txt_doanhthu.ReadOnly = true;
            this.txt_doanhthu.Size = new System.Drawing.Size(179, 23);
            this.txt_doanhthu.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Doanh thu";
            // 
            // Btn_inhd
            // 
            this.Btn_inhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_inhd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Btn_inhd.Location = new System.Drawing.Point(385, 340);
            this.Btn_inhd.Name = "Btn_inhd";
            this.Btn_inhd.Size = new System.Drawing.Size(121, 34);
            this.Btn_inhd.TabIndex = 48;
            this.Btn_inhd.Text = "In Thống kê";
            this.Btn_inhd.UseVisualStyleBackColor = true;
            this.Btn_inhd.Click += new System.EventHandler(this.Btn_inhd_Click);
            // 
            // Frm_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 417);
            this.Controls.Add(this.Btn_inhd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_DoanhThu_FormClosing);
            this.Load += new System.EventHandler(this.Frm_DoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpngaycuoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngaydau;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_doanhthu;
        private System.Windows.Forms.TextBox txt_nguyenlieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_loinhuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_nguyenlieu;
        private System.Windows.Forms.Label txt_tbdoangthu;
        private System.Windows.Forms.Label lb_doanhthu;
        private System.Windows.Forms.Button Btn_inhd;
    }
}