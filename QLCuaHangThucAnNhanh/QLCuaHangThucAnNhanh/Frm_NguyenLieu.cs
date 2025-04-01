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
    public partial class Frm_NguyenLieu : Form
    {
        public Frm_NguyenLieu()
        {
            InitializeComponent();
        }
        NguyenLieuAccess nl = new NguyenLieuAccess();
        DonViTinhAccess dv = new DonViTinhAccess();
        private void Frm_NguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void LoadNL()
        {
            dgvNguyenlieu.DataSource = nl.GetDataTable();
        }
        private void LoadDVT()
        {
            cbx_donvi.DataSource = dv.GetData();
            cbx_donvi.DisplayMember = "DonVi";
            cbx_donvi.ValueMember = "MaDV";
        }
        private bool KTThongTin()
        {
            bool kt = true;
            if (Txt_tennguyenlieu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nguyên liệu!!!");
                Txt_tennguyenlieu.Focus();
                kt = false;
            }
            if (nud_tonkhonl.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng nguyên liệu!!!");
                nud_tonkhonl.Focus();
                kt = false;
            }
            if (cbx_donvi.Text=="")
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính của nguyên liệu!!!");
                cbx_donvi.Focus();
                kt = false;
            }
            return kt;

        }
        private void setNull()
        {
            Btn_Capnhatnguyenlieu.Enabled = false;
            Btn_xoanguyenlieu.Enabled = false;
            btn_boqua.Enabled = false;
            Txt_tennguyenlieu.Text = "";
            nud_tonkhonl.Value = 0;
            cbx_donvi.Text = "";
        }
        private void Btn_themnguyenlieu_Click(object sender, EventArgs e)
        {
            if (KTThongTin()==true)
            {
                nl.InsertNL(Txt_tennguyenlieu.Text,int.Parse(nud_tonkhonl.Value.ToString()),int.Parse(cbx_donvi.SelectedValue.ToString()));
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setNull();
                LoadNL();
            }
        }

        private void Frm_NguyenLieu_Load(object sender, EventArgs e)
        {
            LoadNL();
            LoadDVT();
            setNull();
        }

        private void dgvNguyenlieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                Btn_Capnhatnguyenlieu.Enabled = true;
                Btn_xoanguyenlieu.Enabled = true;
                btn_boqua.Enabled = true;
                Txt_tennguyenlieu.Text = dgvNguyenlieu.CurrentRow.Cells["TenNL"].Value.ToString();
                nud_tonkhonl.Value = int.Parse(dgvNguyenlieu.CurrentRow.Cells["TonKhoNL"].Value.ToString());
                cbx_donvi.SelectedIndex = cbx_donvi.FindString(dgvNguyenlieu.CurrentRow.Cells["DonVi"].Value.ToString());
        }

        private void Btn_Capnhatnguyenlieu_Click(object sender, EventArgs e)
        {
            if (KTThongTin()==true)
            {
                nl.UpdateNL(Txt_tennguyenlieu.Text,int.Parse(nud_tonkhonl.Value.ToString()),int.Parse(cbx_donvi.SelectedValue.ToString()),int.Parse(dgvNguyenlieu.CurrentRow.Cells["MaNL"].Value.ToString()));
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setNull();
                LoadNL();
            }
        }

        private void Btn_xoanguyenlieu_Click(object sender, EventArgs e)
        {
            DialogResult choices = MessageBox.Show("Bạn có chắc chắn xóa nguyên liệu '"+dgvNguyenlieu.CurrentRow.Cells["TenNL"].Value.ToString()+"'", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (choices == DialogResult.Yes)
            {
                nl.DeleteNL(int.Parse(dgvNguyenlieu.CurrentRow.Cells["MaNL"].Value.ToString()));
                LoadNL();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setNull();
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            setNull();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "")
            {
                if (nl.TimKiem(txt_timkiem.Text.Trim()).Rows.Count > 0)
                {
                    dgvNguyenlieu.DataSource = nl.TimKiem(txt_timkiem.Text.Trim());
                }
                else
                    MessageBox.Show("Không tìm thấy!!!");
            }
            else
                MessageBox.Show("Vui lòng nhập tên nguyên liệu cần tìm!!!");
        }
    }
}
