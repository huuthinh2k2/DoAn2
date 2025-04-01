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
    public partial class Frm_Chinh : Form
    {
        public Frm_Chinh()
        {
            InitializeComponent();
        }
        string cv;
        public Frm_Chinh(string chucvu):this()
        {
            cv = chucvu;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult choices = MessageBox.Show("Bạn chắc chắn muốn đăng xuất ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choices == DialogResult.Yes)
            {
                this.Hide();
                Frm_DangNhap frmdangnhap = new Frm_DangNhap();
                frmdangnhap.ShowDialog();
            }
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MonAn monan = new Frm_MonAn();
            monan.ShowDialog();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NguyenLieu nguyenlieu = new Frm_NguyenLieu();
            nguyenlieu.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NhanVien frmnv = new Frm_NhanVien();
            frmnv.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang khach = new Frm_KhachHang();
            khach.ShowDialog();
        }
        private void hDNhậpNLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HDNhapNguyenLieu nhapnl = new Frm_HDNhapNguyenLieu();
            nhapnl.ShowDialog();
        }

        private void hDBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HDBanHang od = new Frm_HDBanHang();
            od.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DoanhThu doanhThu = new Frm_DoanhThu();
            doanhThu.ShowDialog();
        }

        private void Frm_Chinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choices = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choices == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Frm_Chinh_Load(object sender, EventArgs e)
        {
            if (cv=="thungan")
            {
                danhMụcToolStripMenuItem.Enabled = false;
                hDNhậpNLToolStripMenuItem.Enabled = false;
            }
            if (cv == "bep")
            {
                nhânViênToolStripMenuItem.Enabled = false;
                kháchHàngToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                hDBánHàngToolStripMenuItem.Enabled = false;
            }
        }
    }
}
