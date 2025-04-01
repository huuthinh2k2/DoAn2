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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }
        NhanVienAccess nv = new NhanVienAccess();
        ChucVuAccess cv = new ChucVuAccess();
        private void Frm_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {

            LoadNV();
            LoadCV();
            Btn_capnhatNV.Enabled = false;
            Btn_xoaNV.Enabled = false;
            setNull();
        }
        private void LoadNV()
        {
            dgvNhanVien.DataSource = nv.getData();
        }
        private void LoadCV()
        {
            cbx_chucvu.DataSource = cv.GetData();
            cbx_chucvu.DisplayMember = "TenCV";
            cbx_chucvu.ValueMember = "MaCV";
        }
        private bool KTThongTin()
        {
            bool kt = true;
            if (Txt_hoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên !!!");
                Txt_hoten.Focus();
                kt = false;
            }
            if (Txt_DienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên!!!");
                Txt_hoten.Focus();
                kt = false;
            }
            if (Txt_DiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhân viên!!!");
                kt = false;
                Txt_DiaChi.Focus();
            }
            if (dtp_NgaySinh.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn ngày sinh nhân viên!!!");
                dtp_NgaySinh.Focus();
                kt = false;
            }
            if(rab_nam.Checked==false && rab_nu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính nhân viên!!!");
                rab_nam.Focus();
                kt = false;
            }
            if (cbx_chucvu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chức vụ của nhân viên!!!");
                cbx_chucvu.Focus();
                kt = false;
            }
            return kt;
        }
        private void setNull()
        {
            Txt_hoten.Text = "";
            Txt_DiaChi.Text = "";
            Txt_DienThoai.Text = "";
            cbx_chucvu.Text= "";
            dtp_NgaySinh.Text="";
            Btn_capnhatNV.Enabled = false;
            Btn_xoaNV.Enabled = false;
            btn_boqua.Enabled = false;
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                Btn_capnhatNV.Enabled = true;
                Btn_xoaNV.Enabled = true;
                btn_boqua.Enabled = true;
                Txt_hoten.Text = dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
                Txt_DienThoai.Text = dgvNhanVien.CurrentRow.Cells["DienThoaiNV"].Value.ToString();
                Txt_DiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChiNV"].Value.ToString();
                cbx_chucvu.SelectedIndex = cbx_chucvu.FindString(dgvNhanVien.CurrentRow.Cells["TenCV"].Value.ToString());
                dtp_NgaySinh.Text = dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
                if (dgvNhanVien.CurrentRow.Cells["GioiTinhNV"].Value.ToString() == "Nam")
                    rab_nam.Checked = true;
                else
                    rab_nu.Checked = true;
        }

        private void Btn_themNV_Click(object sender, EventArgs e)
        {
            if (KTThongTin()==true)
            {
                string gt;
                if (rab_nam.Checked == true)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nữ";
                }
                nv.InsertNV(Txt_hoten.Text.Trim(),Txt_DienThoai.Text.Trim(),Txt_DiaChi.Text.Trim(),dtp_NgaySinh.Value.ToString("yyyy-MM-dd"),gt,int.Parse(cbx_chucvu.SelectedValue.ToString()));
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setNull();
                LoadNV();
            }
          
        }

        private void Btn_xoaNV_Click(object sender, EventArgs e)
        {
                DialogResult choices=MessageBox.Show("Bạn có chắc chắn xóa nhân viên " + dgvNhanVien.CurrentRow.Cells["TenNV"].Value.ToString(),"Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (choices == DialogResult.Yes)
                {
                    nv.DeleteNV(int.Parse(dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString()));
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    setNull();
                    LoadNV();
                }
        }

        private void Btn_capnhatNV_Click(object sender, EventArgs e)
        {
            if (KTThongTin()==true)
            {
                string gt;
                if (rab_nam.Checked == true)
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nữ";
                }
                nv.UpdateNV(Txt_hoten.Text, Txt_DienThoai.Text, Txt_DiaChi.Text, dtp_NgaySinh.Value.ToString("yyyy-MM-dd"),gt,int.Parse(cbx_chucvu.SelectedValue.ToString()), int.Parse(dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString()));
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setNull();
                LoadNV();
            }
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            setNull();
            LoadNV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "")
            {
                if (nv.TimKiem(txt_timkiem.Text.Trim()).Rows.Count > 0)
                {
                    dgvNhanVien.DataSource = nv.TimKiem(txt_timkiem.Text.Trim());
                }
                else
                    MessageBox.Show("Không tìm thấy!!!");
            }
            else
                MessageBox.Show("Vui lòng nhập tên nhân viên cần tìm!!!");
        }

        private void Txt_DienThoai_TextChanged(object sender, EventArgs e)
        {
            if (Txt_DienThoai.Text != "")
            {
                int t = 0;
                if(int.TryParse(Txt_DienThoai.Text.Trim(),out t))
                {

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!!");
                    Txt_DienThoai.Text = "";
                }
            }
        }
    }
}
