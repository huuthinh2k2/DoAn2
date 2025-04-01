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
    public partial class Frm_MonAn : Form
    {
        public Frm_MonAn()
        {
            InitializeComponent();
        }
        MonAnAccess ma = new MonAnAccess();
        private void Frm_MonAn_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void LoadMA()
        {
            dgvMonan.DataSource = ma.GetData();
        }
        private void setNull()
        {
            Btn_Capnhatmonan.Enabled = false;
            Btn_xoamonan.Enabled = false;
            txt_giamonan.Text = "";
            Txt_tenmonan.Text = "";
            nud_tonkhonmonan.Value = 0;
            btn_reset.Enabled = false;
        }
        private void Frm_MonAn_Load(object sender, EventArgs e)
        {
            LoadMA();
            setNull();
        }
        private bool KTThongTin()
        {
            bool kt = true;
            if (txt_giamonan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá bán của món ăn!!!");
                txt_giamonan.Focus();
                kt = false;
            }
            if (Txt_tenmonan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!!!");
                Txt_tenmonan.Focus();
                kt = false;
            }
            if (nud_tonkhonmonan.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng món ăn!!!");
                nud_tonkhonmonan.Focus();
                kt = false;
            }
            return kt;
        }
        private void Btn_themmonan_Click(object sender, EventArgs e)
        {
            if(KTThongTin()==true)
            {
                ma.InsertMA(Txt_tenmonan.Text.Trim(),int.Parse(nud_tonkhonmonan.Value.ToString()), decimal.Parse(txt_giamonan.Text));
                LoadMA();
                setNull();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvMonan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMonan.CurrentRow.Cells["TenMon"].Value.ToString()!="")
            {
                Btn_Capnhatmonan.Enabled = true;
                Btn_xoamonan.Enabled = true;
                btn_reset.Enabled = true;
                Txt_tenmonan.Text = dgvMonan.CurrentRow.Cells["TenMon"].Value.ToString();
                txt_giamonan.Text = dgvMonan.CurrentRow.Cells["GiaMon"].Value.ToString();
                nud_tonkhonmonan.Value = int.Parse(dgvMonan.CurrentRow.Cells["TonKhoMonAn"].Value.ToString());
            }
        }

        private void Btn_Capnhatmonan_Click(object sender, EventArgs e)
        {
            if (KTThongTin() == true)
            {
                ma.UpdateMA(int.Parse(dgvMonan.CurrentRow.Cells["MaMon"].Value.ToString()),Txt_tenmonan.Text.Trim(), int.Parse(nud_tonkhonmonan.Value.ToString()), decimal.Parse(txt_giamonan.Text));
                LoadMA();
                setNull();
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_xoamonan_Click(object sender, EventArgs e)
        {
           DialogResult choices = MessageBox.Show("Bạn có chắc chắn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choices == DialogResult.Yes)
            {
                ma.DeleteMA(int.Parse(dgvMonan.CurrentRow.Cells["MaMon"].Value.ToString()));
                setNull();
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMA();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            setNull();
            LoadMA();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_timkiem.Text != "")
            {
                if (ma.TimKiem(txt_timkiem.Text.Trim()).Rows.Count > 0)
                {
                    DataTable dt = ma.TimKiem(txt_timkiem.Text.Trim());
                    dgvMonan.DataSource = dt;
                    btn_reset.Enabled = true;
                }
                else
                    MessageBox.Show("Không tìm thấy");
            }
            else
                MessageBox.Show("Vui lòng nhập món ăn cần tìm");
        }
    }
}
