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
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }
        KhachHangAccess kh = new KhachHangAccess();

        private void Frm_KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadKH();
            SetNull();
        }
        private void LoadKH()
        {
            dgvKhachHang.DataSource = kh.GetData();
        }

        private void SetNull()
        {
            Btn_xoakhach.Enabled = false;
            Btn_capnhatkhach.Enabled = false;
            Txt_tenkhach.Text = "";
            Txt_sdtkhach.Text = "";
            Txt_diachikhach.Text = "";
        }
        private bool KTThongTin()
        {
            bool kt = true;
            if (Txt_tenkhach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!!!");
                kt = false;
                Txt_tenkhach.Focus();
            }
            if (Txt_diachikhach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng!!!");
                kt = false;
                Txt_diachikhach.Focus();
            }
            if (Txt_sdtkhach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!!!");
                Txt_sdtkhach.Focus();
                kt = false;
            }
            return kt;
        }
        private void Btn_khach_Click(object sender, EventArgs e)
        {
            if(KTThongTin()==true)
            {
                kh.InsertKH(Txt_tenkhach.Text.Trim(), Txt_sdtkhach.Text.Trim(), Txt_diachikhach.Text.Trim());
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetNull();
                LoadKH();
                dgvKhachHang.Focus();
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                Btn_xoakhach.Enabled = true;
                Btn_capnhatkhach.Enabled = true;
                Txt_tenkhach.Text = dgvKhachHang.CurrentRow.Cells["TenKH"].Value.ToString();
                Txt_diachikhach.Text = dgvKhachHang.CurrentRow.Cells["DiaChiKH"].Value.ToString();
                Txt_sdtkhach.Text = dgvKhachHang.CurrentRow.Cells["DienThoaiKH"].Value.ToString();
        }

        private void Btn_capnhatkhach_Click(object sender, EventArgs e)
        {
            if(KTThongTin()){
                kh.UpdateKH(Txt_tenkhach.Text.Trim(), Txt_diachikhach.Text.Trim(), Txt_sdtkhach.Text.Trim(),int.Parse(dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString()));
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetNull();
                LoadKH();
                dgvKhachHang.Focus();
            }
        }
        private void Btn_xoakhach_Click(object sender, EventArgs e)
        {
            DialogResult choices = MessageBox.Show("Bạn có chắc chắn xóa khách hàng '"+dgvKhachHang.CurrentRow.Cells["TenKH"].Value+"' ?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(choices == DialogResult.Yes)
            {
                kh.DeleteKH(int.Parse(dgvKhachHang.CurrentRow.Cells["MaKH"].Value.ToString()));
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetNull();
                LoadKH();
                dgvKhachHang.Focus();
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            SetNull();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "")
            {
                if (kh.TimKiem(txt_timkiem.Text.Trim()).Rows.Count > 0)
                {
                    dgvKhachHang.DataSource = kh.TimKiem(txt_timkiem.Text.Trim());
                }
                else
                    MessageBox.Show("Không tìm thấy!!!");
            }
            else
                MessageBox.Show("Vui lòng nhập tên khách hàng cần tìm");
        }

        private void Txt_sdtkhach_TextChanged(object sender, EventArgs e)
        {
            if (Txt_sdtkhach.Text != "")
            {
                int num = 0;
                if (int.TryParse(Txt_sdtkhach.Text.Trim(),out num))
                {
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!!");
                    Txt_sdtkhach.Text = "";
                }
            }
        }
    }
}
