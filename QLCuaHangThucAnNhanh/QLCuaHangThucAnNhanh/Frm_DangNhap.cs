using QLCuaHangThucAnNhanh.DuLieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangThucAnNhanh
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        void LoadForm(string text)
        {
            Frm_Chinh frmmain = new Frm_Chinh(text);
            this.Hide();
            frmmain.ShowDialog();
            Application.Exit();
        }
        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (Txt_taikhoan.Text.Trim() == "admin" && Txt_matkhau.Text.Trim() == "0000")
            {
                LoadForm("quanli");
            }
            if(Txt_taikhoan.Text.Trim()=="thungan"&& Txt_matkhau.Text.Trim() == "1111")
            {
                LoadForm("thungan");
            }
            if (Txt_taikhoan.Text.Trim() == "bep" && Txt_matkhau.Text.Trim() == "2222")
            {
                LoadForm("bep");
            }
            MessageBox.Show("Sai tài khoản hoặc mật khẩu!!!");
        }

        private void Frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult choices = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (choices == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
