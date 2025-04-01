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
using COMExcel = Microsoft.Office.Interop.Excel;


namespace QLCuaHangThucAnNhanh
{
    public partial class Frm_HDNhapNguyenLieu : Form
    {
        public Frm_HDNhapNguyenLieu()
        {
            InitializeComponent();
        }
        NhanVienAccess nv = new NhanVienAccess();
        DonViTinhAccess dvt = new DonViTinhAccess();
        HDNhapAccess hd = new HDNhapAccess();
        NguyenLieuAccess nl = new NguyenLieuAccess();
        Database db = new Database();
        bool kt=false;
        bool check = false;
        bool qt = false;
        DataTable temp;
        private void Frm_HDNhapNguyenLieu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (kt == true)
            {
                DialogResult chon = MessageBox.Show("Bạn đang thao tác với hóa đơn nếu thoát bây giờ mọi thao tác sẽ bị hủy, bạn có chắc chắn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (chon == DialogResult.Yes)
                {
                    this.btn_huy_Click(sender, e);
                }
                else
                    e.Cancel = true;
            }
        }

        private void LoadNguoiLap()
        {
            cbx_nguoilaphd.DataSource = nv.getData();
            cbx_nguoilaphd.DisplayMember = "TenNV";
            cbx_nguoilaphd.ValueMember = "MaNV";
        }
        private void LoadDVT()
        {
            cbx_dvt.DataSource = dvt.GetData();
            cbx_dvt.DisplayMember = "DonVi";
            cbx_dvt.ValueMember = "MaDV";
        }

        private void Frm_HDNhapNguyenLieu_Load(object sender, EventArgs e)
        {
            LoadDVT();
            LoadNguoiLap();
            LoadNL();
            LoadHDNhap();
            setNullAll();
        }
        private void setNull()
        {
            cbx_nguyenlieu.Text = "";
            Txt_gianhapnl.Text = "";
            nud_slnhap.Value = 0;
            btn_boqua.Enabled = false;
            btn_xoanl.Enabled = false;
            btn_suanl.Enabled = false;
            cbx_nguyenlieu.Enabled = true;
        }
        private void setNullAll()
        {
            cbx_nguyenlieu.Text = "";
            Txt_gianhapnl.Text = "";
            nud_slnhap.Value = 0;
            btn_boqua.Enabled = false;
            btn_xoanl.Enabled = false;
            btn_suanl.Enabled = false;
            Btn_xoahd.Enabled = false;
            txt_tongtien.Text = "";
            dtp_ngaynhapnl.Text = "";
            btn_huy.Enabled = false;
            cbx_nguoilaphd.Text = "";
            cbx_dvt.Text = "";
            btn_chinhsua.Enabled = false;
            Btn_luuhd.Enabled = false;
            btn_inhd.Enabled = false;
        }

        private void LoadNL()
        {
            cbx_nguyenlieu.DataSource = nl.GetData();
            cbx_nguyenlieu.DisplayMember = "TenNL";
            cbx_nguyenlieu.ValueMember = "MaNL";
        }
        private void LoadItemHD()
        {
            dgvhdnhap.DataSource = hd.getItem(hd.GetMaHD());
        }
        private void LoadHDNhap()
        {
            Cbx_Timhoadonnhap.DataSource = hd.GetAllHD();
            Cbx_Timhoadonnhap.DisplayMember ="MaHDNhap";
            Cbx_Timhoadonnhap.ValueMember = "MaHDNhap";
        }
        private bool KTNL(int manl, string mahd)
        {
            kt = false;
            DataTable dt = hd.getItem(mahd);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (int.Parse(dt.Rows[i]["MaNL"].ToString()) == manl)
                {
                    MessageBox.Show("Nguyên liệu đã được thêm vào hóa đơn!!!");
                    kt = true;
                }
                else
                    continue;
            }
            return kt;
        }
        private void btn_themnl_Click(object sender, EventArgs e)
        {
            Btn_luuhd.Enabled = true;
            btn_huy.Enabled = true;
            kt = true;
            if (cbx_nguyenlieu.SelectedItem.ToString() != "" && Txt_gianhapnl.Text != "" && nud_slnhap.Value != 0 && cbx_dvt.SelectedItem != null)
            {
                if (check == false)
                {
                    if (qt == false)
                    {
                        hd.CreateHD(hd.AutoID());
                        hd.InsertHDItem(hd.GetMaHD(), int.Parse(cbx_nguyenlieu.SelectedValue.ToString()), int.Parse(nud_slnhap.Value.ToString()), int.Parse(cbx_dvt.SelectedValue.ToString()), decimal.Parse(Txt_gianhapnl.Text.Trim()));
                        qt = true;
                    }
                    else
                    {
                        if (KTNL(int.Parse(cbx_nguyenlieu.SelectedValue.ToString()), hd.GetMaHD()) == false)
                        {
                            hd.InsertHDItem(hd.GetMaHD(), int.Parse(cbx_nguyenlieu.SelectedValue.ToString()), int.Parse(nud_slnhap.Value.ToString()), int.Parse(cbx_dvt.SelectedValue.ToString()), decimal.Parse(Txt_gianhapnl.Text.Trim()));
                        }
                    }
                    decimal tongtien = hd.GetTongtien(hd.GetMaHD());
                    txt_tongtien.Text = tongtien.ToString();
                    LoadItemHD();
                }
                else
                {
                    if (KTNL(int.Parse(cbx_nguyenlieu.SelectedValue.ToString()),Cbx_Timhoadonnhap.SelectedValue.ToString()) == false)
                    {
                        hd.InsertHDItem(Cbx_Timhoadonnhap.SelectedValue.ToString(), int.Parse(cbx_nguyenlieu.SelectedValue.ToString()), int.Parse(nud_slnhap.Value.ToString()), int.Parse(cbx_dvt.SelectedValue.ToString()), decimal.Parse(Txt_gianhapnl.Text.Trim()));
                    }
                    decimal tongtien = hd.GetTongtien(Cbx_Timhoadonnhap.SelectedValue.ToString());
                    txt_tongtien.Text = tongtien.ToString();
                    dgvhdnhap.DataSource = hd.getItem(Cbx_Timhoadonnhap.SelectedValue.ToString());
                }
                int sl = nl.GetTonKho(int.Parse(cbx_nguyenlieu.SelectedValue.ToString())) - int.Parse(nud_slnhap.Value.ToString());
                nl.UpdateTonKho(sl, int.Parse(cbx_nguyenlieu.SelectedValue.ToString()));
                setNull();
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            setNull();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvhdnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                btn_xoanl.Enabled = true;
                btn_suanl.Enabled = true;
                btn_boqua.Enabled = true;
                cbx_nguyenlieu.Text = dgvhdnhap.CurrentRow.Cells["TenNL"].Value.ToString();
                nud_slnhap.Value = int.Parse(dgvhdnhap.CurrentRow.Cells["SLNhap"].Value.ToString());
                Txt_gianhapnl.Text = dgvhdnhap.CurrentRow.Cells["GiaNhap"].Value.ToString();
                cbx_dvt.Text = dgvhdnhap.CurrentRow.Cells["DonVi"].Value.ToString();
                cbx_nguyenlieu.Enabled = false;
            
        }

        private void btn_xoanl_Click(object sender, EventArgs e)
        {
            DialogResult chon= MessageBox.Show("Bạn có chắc chắn xóa nguyên liệu '"+dgvhdnhap.CurrentRow.Cells["TenNL"].Value.ToString()+"' khỏi hóa đơn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                int tonkho = nl.GetTonKho(int.Parse(cbx_nguyenlieu.SelectedValue.ToString())) - int.Parse(nud_slnhap.Value.ToString());
                nl.UpdateTonKho(tonkho, int.Parse(cbx_nguyenlieu.SelectedValue.ToString()));
                hd.deleteItem(int.Parse(cbx_nguyenlieu.SelectedValue.ToString()),dgvhdnhap.CurrentRow.Cells["MaHD"].Value.ToString());
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setNull();
                if (check == false)
                    LoadItemHD();
                else
                    dgvhdnhap.DataSource = hd.getItem(Cbx_Timhoadonnhap.SelectedValue.ToString());
                if(check == false)
                {
                    if (hd.getItem(hd.GetMaHD()).Rows.Count > 0)
                    {
                        decimal tongtien = hd.GetTongtien(Cbx_Timhoadonnhap.SelectedValue.ToString());
                        txt_tongtien.Text = tongtien.ToString();
                    }
                    else
                        txt_tongtien.Text = "0";
                }
                else
                {
                    if (hd.getItem(Cbx_Timhoadonnhap.SelectedValue.ToString()).Rows.Count > 0)
                    {
                        decimal tongtien = hd.GetTongtien(Cbx_Timhoadonnhap.SelectedValue.ToString());
                        txt_tongtien.Text = tongtien.ToString();
                    }
                    else
                        txt_tongtien.Text = "0";
                }
            }
  
        }

        private void btn_suanl_Click(object sender, EventArgs e)
        {
            if (KTNguyenLieu())
            {
                int tonkho = nl.GetTonKho(int.Parse(dgvhdnhap.CurrentRow.Cells["MaNL"].Value.ToString())) - int.Parse(dgvhdnhap.CurrentRow.Cells["SLNhap"].Value.ToString());
                nl.UpdateTonKho(tonkho, int.Parse(dgvhdnhap.CurrentRow.Cells["MaNL"].Value.ToString()));
                hd.UpdateItem(int.Parse(nud_slnhap.Value.ToString()), decimal.Parse(Txt_gianhapnl.Text), int.Parse(cbx_dvt.SelectedValue.ToString()), int.Parse(cbx_nguyenlieu.SelectedValue.ToString()), dgvhdnhap.CurrentRow.Cells["MaHD"].Value.ToString());
                tonkho = nl.GetTonKho(int.Parse(cbx_nguyenlieu.SelectedValue.ToString())) + int.Parse(nud_slnhap.Value.ToString());
                nl.UpdateTonKho(tonkho, int.Parse(cbx_nguyenlieu.SelectedValue.ToString()));
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (check == false)
                    LoadItemHD();
                else
                    dgvhdnhap.DataSource = hd.getItem(Cbx_Timhoadonnhap.SelectedValue.ToString());
                setNull();
                kt = false;
            }
            else
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool KTThongtin()
        {
            bool kt = true;
            if (cbx_nguoilaphd.Text == "")
            {
                MessageBox.Show("Vui lòng chọn người lập hóa đơn!!!");
                cbx_nguoilaphd.Focus();
                kt = false;

            }
            if (dtp_ngaynhapnl.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn ngày nhập nguyên liệu!!!");
                dtp_ngaynhapnl.Focus();
                kt = false;
            }
            return kt;
        }
        private bool KTNguyenLieu()
        {
            bool kt = true;
            if (cbx_nguyenlieu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu cần thêm!!!");
                cbx_nguyenlieu.Focus();
                kt = false;
            }
            if (Txt_gianhapnl.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá nhập của nguyên liệu!!!");
                Txt_gianhapnl.Focus();
                kt = false;
            }
            if (nud_slnhap.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng nguyên liệu nhập vào!!!");
                nud_slnhap.Focus();
                kt = false;
            }
            if (cbx_dvt.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính của nguyên liệu!!!");
                cbx_dvt.Focus();
                kt = false;
            }
            return kt;
        }
        private void Btn_luuhd_Click(object sender, EventArgs e)
        {
            bool qt = true;
            if(KTThongtin()==true)
            {
                if(check==false)
                {
                    if (hd.getItem(hd.GetMaHD()).Rows.Count > 0)
                    {
                        hd.SaveHD(hd.GetMaHD(), dtp_ngaynhapnl.Value.ToString("yyyy-MM-dd"), decimal.Parse(txt_tongtien.Text), int.Parse(cbx_nguoilaphd.SelectedValue.ToString()));
                    }
                    else
                    {
                        qt = false;
                        MessageBox.Show("Không thể lưu hóa đơn khi không nguyên liệu nào được thêm!!!");
                    }
                }
                else
                {
                    if (hd.getItem(Cbx_Timhoadonnhap.SelectedValue.ToString()).Rows.Count > 0)
                    {
                        hd.SaveHD(Cbx_Timhoadonnhap.SelectedValue.ToString(), dtp_ngaynhapnl.Value.ToString("yyyy-MM-dd"), decimal.Parse(txt_tongtien.Text), int.Parse(cbx_nguoilaphd.SelectedValue.ToString()));
                    }
                    else
                    {
                        MessageBox.Show("Không thể lưu hóa đơn khi không nguyên liệu nào được thêm!!!");
                        qt = false;
                    }
                }
                if (qt == true)
                {
                    MessageBox.Show("Lưu hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setNullAll();
                    dgvhdnhap.DataSource = hd.getItem("-1");
                    kt = false;
                    LoadHDNhap();
                }    
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (Cbx_Timhoadonnhap.Text != "")
            {
                btn_chinhsua.Enabled = true;
                btn_inhd.Enabled = true;
                DisableEdit();
                temp = hd.getItem(Cbx_Timhoadonnhap.SelectedValue.ToString());
                check = true;
                DataTable dt = hd.GetHDbyID(Cbx_Timhoadonnhap.SelectedValue.ToString());
                cbx_nguoilaphd.Text = dt.Rows[0]["TenNV"].ToString();
                dtp_ngaynhapnl.Text = dt.Rows[0]["NgayNhap"].ToString();
                txt_tongtien.Text = dt.Rows[0]["TongTienNhap"].ToString();
                dgvhdnhap.DataSource = hd.getItem(Cbx_Timhoadonnhap.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần tìm!!!");
                Cbx_Timhoadonnhap.Focus();
            }
        }
        private void DisableEdit()
        {
            cbx_nguyenlieu.Enabled = false;
            Txt_gianhapnl.Enabled = false;
            nud_slnhap.Enabled = false;
            cbx_dvt.Enabled = false;
            cbx_nguoilaphd.Enabled = false;
            dtp_ngaynhapnl.Enabled = false;
            btn_themnl.Enabled = false;
            btn_huy.Enabled = false;
            Btn_luuhd.Enabled = false;
            dgvhdnhap.Enabled = false;
        }
        private void EnableEdit()
        {
            cbx_nguyenlieu.Enabled = true;
            Txt_gianhapnl.Enabled = true;
            nud_slnhap.Enabled = true;
            cbx_dvt.Enabled = true;
            cbx_nguoilaphd.Enabled = true;
            dtp_ngaynhapnl.Enabled = true;
            btn_themnl.Enabled = true;
            btn_huy.Enabled = true;
            Btn_luuhd.Enabled = true;
            Btn_xoahd.Enabled = true;
            dgvhdnhap.Enabled = true;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
                if (check==false)
                {
                    DataTable dt = hd.getItem(hd.GetMaHD());
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int sl = nl.GetTonKho(int.Parse(dt.Rows[i]["MaNL"].ToString())) + int.Parse(dt.Rows[i]["SLNhap"].ToString());
                        nl.UpdateTonKho(sl, int.Parse(dt.Rows[i]["MaNL"].ToString()));
                    }
                    hd.DeleteHD(hd.GetMaHD());
                }
                else
                {
                    DataTable dt = hd.getItem(Cbx_Timhoadonnhap.SelectedValue.ToString());
                    int n;
                    if (dt.Rows.Count > temp.Rows.Count)
                        n = dt.Rows.Count;
                    else
                        n = temp.Rows.Count;
                for (int j = 0; j < n; j++)
                        {
                            if (int.Parse(dt.Rows[j]["MaNL"].ToString()) != int.Parse(temp.Rows[j]["MaNL"].ToString()))
                            {
                                int sl = nl.GetTonKho(int.Parse(dt.Rows[j]["MaNL"].ToString())) + int.Parse(dt.Rows[j]["SLNhap"].ToString());
                                nl.UpdateTonKho(sl, int.Parse(dt.Rows[j]["MaNL"].ToString()));
                                hd.deleteItem(int.Parse(dt.Rows[j]["MaNL"].ToString()),Cbx_Timhoadonnhap.SelectedValue.ToString());
                            }
                            else
                            {
                                if (int.Parse(dt.Rows[j]["SLNhap"].ToString()) != int.Parse(temp.Rows[j]["SLNhap"].ToString()))
                                {
                                    if (int.Parse(dt.Rows[j]["SLNhap"].ToString()) > int.Parse(temp.Rows[j]["SLNhap"].ToString()))
                                    {
                                    int sl = nl.GetTonKho(int.Parse(dt.Rows[j]["MaNL"].ToString())) - (int.Parse(dt.Rows[j]["SLNhap"].ToString()) - int.Parse(temp.Rows[j]["SLNhap"].ToString()));
                                        nl.UpdateTonKho(sl, int.Parse(dt.Rows[j]["MaNL"].ToString()));
                                    }
                                    else
                                    {
                                        int sl = nl.GetTonKho(int.Parse(dt.Rows[j]["MaNL"].ToString())) + (int.Parse(temp.Rows[j]["SLNhap"].ToString()) - int.Parse(dt.Rows[j]["SLNhap"].ToString()));
                                        nl.UpdateTonKho(sl, int.Parse(dt.Rows[j]["MaNL"].ToString()));
                                    }
                                    hd.UpdateQuantity(int.Parse(temp.Rows[j]["SLNhap"].ToString()), int.Parse(dt.Rows[j]["MaNL"].ToString()),Cbx_Timhoadonnhap.SelectedValue.ToString());
                                }
                               
                            }
                        }
                }
            setNullAll();
            dgvhdnhap.DataSource = hd.getItem("-1");
            kt = false;
        }

        private void Btn_xoahd_Click(object sender, EventArgs e)
        {
            if (Cbx_Timhoadonnhap.Text != "")
            {
                hd.DeleteHD(Cbx_Timhoadonnhap.SelectedValue.ToString());
                MessageBox.Show("Xoá hóa đơn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setNullAll();
                LoadHDNhap();
            }
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            if (Cbx_Timhoadonnhap.Text!="")
            {
                dtp_ngaynhapnl.Checked = true;
                kt = true;
                EnableEdit();

            }
        }

        private void Txt_gianhapnl_TextChanged(object sender, EventArgs e)
        {
            if (Txt_gianhapnl.Text != "" && Txt_gianhapnl.Text != "0")
            {
                int t = 0;
                if(int.TryParse(Txt_gianhapnl.Text.Trim(),out t))
                {

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!!");
                    Txt_gianhapnl.Text = "";
                }
            }
        }

        private void btn_inhd_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
            exRange.Range["A1:B3"].Font.Size = 12;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Fast Foods";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Nam Can Tho University";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HĐ NHẬP NGUYÊN LIỆU";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "Select * from HDNhap,NhanVien where HDNhap.NguoiLap=NhanVien.MaNV and MaHDNhap='" + Cbx_Timhoadonnhap.SelectedValue.ToString() + "'";
            tblThongtinHD = db.Execute(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0]["MaHDNhap"].ToString();
            //exRange.Range["B7:B7"].Value = "Khách hàng:";
            //exRange.Range["C7:E7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["C7:E7"].MergeCells = true;
            //exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0]["TenKH"].ToString();
            //exRange.Range["B8:B8"].Value = "Địa chỉ:";
            //exRange.Range["C8:E8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["C8:E8"].MergeCells = true;
            //exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0]["DiaChiKH"].ToString();
            //exRange.Range["B9:B9"].Value = "Điện thoại:";
            //exRange.Range["C9:E9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            //exRange.Range["C9:E9"].MergeCells = true;
            //exRange.Range["C9:E9"].Value = "" + tblThongtinHD.Rows[0]["DienThoaiKH"].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenNL,a.SLNhap,a.GiaNhap FROM HDNhap as c,ChiTietHDNhap as a,NguyenLieu as b WHERE c.MaHDNhap=a.MaHD and a.MaNL = b.MaNL and c.MaHDNhap='" + Cbx_Timhoadonnhap.SelectedValue.ToString() + "'";
            tblThongtinHang = db.Execute(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên nguyên liệu";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0]["TongTienNhap"].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0]["NgayNhap"]);
            exRange.Range["A1:C1"].Value = "Cần Thơ, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên nhập nguyên liệu";
            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].Font.Italic = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = tblThongtinHD.Rows[0]["TenNV"];
            exSheet.Name = "Hóa đơn nhập nguyên liệu";
            exApp.Visible = true;
        }
    }
}
