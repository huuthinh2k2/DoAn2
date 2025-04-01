using QLCuaHangThucAnNhanh.DuLieu;
using System;
using System.Data;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace QLCuaHangThucAnNhanh
{
    public partial class Frm_HDBanHang : Form
    {
        public Frm_HDBanHang()
        {
            InitializeComponent();
        }

        BanAccess ban = new BanAccess();
        NhanVienAccess nv = new NhanVienAccess();
        MonAnAccess ma = new MonAnAccess();
        HDBanHangAccess hd = new HDBanHangAccess();
        Database db = new Database();
        bool kt=false;
        bool check = false;
        bool qt = false;
        DataTable temp;
        private void Frm_DatMon_FormClosing(object sender, FormClosingEventArgs e)
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
        private void LoadHD()
        {
            Cbx_timorder.DataSource= hd.GetAllHD();
            Cbx_timorder.DisplayMember = "MaHDBanHang";
            Cbx_timorder.ValueMember = "MaHDBanHang";
        }
        private void LoadCombobox()
        {
            Cbx_ban.DataSource = ban.GetData();
            Cbx_ban.DisplayMember = "TenBan";
            Cbx_ban.ValueMember = "MaBan";

            Cbx_ngnhanorder.DataSource = nv.getData();
            Cbx_ngnhanorder.DisplayMember = "TenNV";
            Cbx_ngnhanorder.ValueMember = "MaNV";

            Cbx_Monan.DataSource = ma.GetData();
            Cbx_Monan.DisplayMember = "TenMon";
            Cbx_Monan.ValueMember = "MaMon";

            Cbx_timorder.DataSource = hd.GetAllHD();
            Cbx_timorder.DisplayMember = "MaHDBanHang";
            Cbx_timorder.ValueMember = "MaHDBanHang";

        }
        private void setNull()
        {
            Cbx_Monan.Text = "";
            nud_slmonandachon.Value = 0;
            btn_capnhatmonan.Enabled = false;
            btn_xoamonandachon.Enabled = false;
            btn_reset.Enabled = false;
        }
        private void SetNullAll()
        {
            Btn_luuhd.Enabled = false;
            btn_capnhatmonan.Enabled = false;
            Btn_xoahd.Enabled = false;
            btn_reset.Enabled = false;
            btn_xoamonandachon.Enabled = false;
            Cbx_Monan.Text = "";
            Cbx_ngnhanorder.Text = "";
            Cbx_ban.Text = "";
            Btn_inhd.Enabled = false;
            txt_tenKH.Text = "";
            txt_dcKH.Text = "";
            txt_sdtKH.Text = "";
            Txt_thanhtien.Text = "0";
            nud_slmonandachon.Value = 0;
            btn_huy.Enabled = false;
            dtp_ngaytao.Text = "";
            txt_giamgia.Text = "0";
            Cbx_timorder.Text = "";
            Btn_edit.Enabled = false;
        }
        private void Frm_HDBanHang_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            SetNullAll();
        }

        private void Btn_chonmon_Click(object sender, EventArgs e)
        {
            Btn_luuhd.Enabled = true;
            btn_huy.Enabled = true;
            kt = true;
            bool ktsl = false;
            if(Cbx_Monan.Text!="" && nud_slmonandachon.Value != 0)
            {
                if (ma.GetSL(int.Parse(Cbx_Monan.SelectedValue.ToString())) >= int.Parse(nud_slmonandachon.Value.ToString()))
                {
                    if (check==false)
                    {
                        if (qt == false)
                        {
                            hd.CreateHD(hd.AutoID());
                            hd.InsertHDItem(hd.GetMaHD(), int.Parse(Cbx_Monan.SelectedValue.ToString()), int.Parse(nud_slmonandachon.Value.ToString()));
                            qt = true;
                        }
                        else
                        {
                            if (KTMonAn(int.Parse(Cbx_Monan.SelectedValue.ToString()), hd.GetMaHD()) == false)
                            {
                                hd.InsertHDItem(hd.GetMaHD(), int.Parse(Cbx_Monan.SelectedValue.ToString()), int.Parse(nud_slmonandachon.Value.ToString()));
                            }
                        }
                        LoadHDItem();
                        Txt_thanhtien.Text = hd.GetTongtien(hd.GetMaHD()).ToString();
                    }
                    else
                    {
                        if(KTMonAn(int.Parse(Cbx_Monan.SelectedValue.ToString()),Cbx_timorder.SelectedValue.ToString()) == false)
                        {
                            hd.InsertHDItem(Cbx_timorder.SelectedValue.ToString(), int.Parse(Cbx_Monan.SelectedValue.ToString()), int.Parse(nud_slmonandachon.Value.ToString()));
                        }
                        dgvThucan.DataSource = hd.getItem(Cbx_timorder.SelectedValue.ToString());
                        Txt_thanhtien.Text = hd.GetTongtien(Cbx_timorder.SelectedValue.ToString()).ToString();
                    }
                    
                }
                else
                {
                    setNull();
                    btn_huy.Enabled = false;
                    MessageBox.Show("Số lượng món ăn không đủ !!!");
                    kt = false;
                    ktsl = true;
                }
                if (ktsl == false)
                {
                    int sl = ma.GetSL(int.Parse(Cbx_Monan.SelectedValue.ToString())) - int.Parse(nud_slmonandachon.Value.ToString());
                    ma.UpdateSL(sl, int.Parse(Cbx_Monan.SelectedValue.ToString()));
                    setNull();
                }
            }
            else
            {
                if (Cbx_Monan.Text == "")
                    MessageBox.Show("Vui lòng chọn món ăn");
                if (nud_slmonandachon.Value == 0)
                    MessageBox.Show("Vui lòng nhập số lượng món");
            }
        }
        private void LoadHDItem()
        {
            dgvThucan.DataSource = hd.getItem(hd.GetMaHD());
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (check==false)
            {
                DataTable dt = hd.getItem(hd.GetMaHD());
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    int sl = ma.GetSL(int.Parse(dt.Rows[i]["MaMon"].ToString())) + int.Parse(dt.Rows[i]["SLMon"].ToString());
                    ma.UpdateSL(sl, int.Parse(dt.Rows[i]["MaMon"].ToString()));
                }
                hd.DeleteHD(hd.GetMaHD());
            }
            else
            {
                DataTable dt = hd.getItem(Cbx_timorder.SelectedValue.ToString());
                int n;
                if (dt.Rows.Count > temp.Rows.Count)
                    n = dt.Rows.Count;
                else
                    n = temp.Rows.Count;
                    for (int j = 0; j < n; j++)
                    {
                        if (int.Parse(dt.Rows[j]["MaMon"].ToString()) != int.Parse(temp.Rows[j]["MaMon"].ToString()))
                        {
                            int sl = ma.GetSL(int.Parse(dt.Rows[j]["MaMon"].ToString())) + int.Parse(dt.Rows[j]["SLMon"].ToString());
                            ma.UpdateSL(sl, int.Parse(dt.Rows[j]["MaMon"].ToString()));
                            hd.deleteItem(int.Parse(dt.Rows[j]["MaMon"].ToString()),Cbx_timorder.SelectedValue.ToString());
                        }
                        else
                        {
                            if (int.Parse(dt.Rows[j]["SLMon"].ToString()) != int.Parse(temp.Rows[j]["SLMon"].ToString()))
                            {
                                if(int.Parse(dt.Rows[j]["SLMon"].ToString()) > int.Parse(temp.Rows[j]["SLMon"].ToString()))
                                {
                                    int sl = ma.GetSL(int.Parse(dt.Rows[j]["MaMon"].ToString())) + (int.Parse(dt.Rows[j]["SLMon"].ToString()) - int.Parse(temp.Rows[j]["SLMon"].ToString()));
                                    ma.UpdateSL(sl, int.Parse(dt.Rows[j]["MaMon"].ToString()));
                                }
                                else
                                {
                                    int sl = ma.GetSL(int.Parse(dt.Rows[j]["MaMon"].ToString())) - (int.Parse(temp.Rows[j]["SLMon"].ToString()) - int.Parse(dt.Rows[j]["SLMon"].ToString()));
                                    ma.UpdateSL(sl, int.Parse(dt.Rows[j]["MaMon"].ToString()));
                                }
                                hd.UpdateItem(int.Parse(temp.Rows[j]["SLMon"].ToString()), int.Parse(dt.Rows[j]["MaMon"].ToString()), Cbx_timorder.SelectedValue.ToString());
                            }
                            
                        }
                    }
            }
            SetNullAll();
            dgvThucan.DataSource = hd.getItem("-1");
            kt = false;
        }

        private void DisableEdit()
        {
            Cbx_ban.Enabled = false;
            dtp_ngaytao.Enabled = false;
            txt_giamgia.Enabled = false;
            txt_tenKH.Enabled = false;
            txt_dcKH.Enabled = false;
            txt_sdtKH.Enabled = false;
            Cbx_ngnhanorder.Enabled = false;
            Btn_chonmon.Enabled = false;
            dgvThucan.Enabled = false;
            Txt_thanhtien.Enabled = false;
        }
        private void EnableEdit()
        {
            Cbx_ban.Enabled = true;
            dtp_ngaytao.Enabled = true;
            txt_giamgia.Enabled = true;
            txt_tenKH.Enabled = true;
            txt_dcKH.Enabled = true;
            txt_sdtKH.Enabled = true;
            Cbx_ngnhanorder.Enabled = true;
            Btn_chonmon.Enabled = true;
            Btn_luuhd.Enabled = true;
            Btn_xoahd.Enabled = true;
            dgvThucan.Enabled = true;
        }
        private void btn_timhd_Click(object sender, EventArgs e)
        {
            DisableEdit();
            Btn_edit.Enabled = true;
            btn_huy.Enabled = false;
            Btn_inhd.Enabled = true;
            if (Cbx_timorder.Text != "")
            {
                if (hd.GetItemByID(Cbx_timorder.SelectedValue.ToString()).Rows.Count > 0)
                {
                    check = true;
                    temp = hd.getItem(Cbx_timorder.SelectedValue.ToString());
                    Btn_xoahd.Enabled = true;
                    btn_huy.Enabled = true;
                    DataTable dt = hd.GetHDbyID(Cbx_timorder.SelectedValue.ToString());
                    Cbx_ngnhanorder.Text = dt.Rows[0]["TenNV"].ToString();
                    Cbx_ban.Text = dt.Rows[0]["TenBan"].ToString();
                    Txt_thanhtien.Text = dt.Rows[0]["ThanhTien"].ToString();
                    dtp_ngaytao.Text = dt.Rows[0]["NgayTao"].ToString();
                    txt_tenKH.Text = dt.Rows[0]["TenKH"].ToString();
                    txt_dcKH.Text = dt.Rows[0]["DiaChiKH"].ToString();
                    txt_sdtKH.Text = dt.Rows[0]["DienThoaiKH"].ToString();
                    txt_giamgia.Text = dt.Rows[0]["GiamGia"].ToString();
                    dgvThucan.DataSource = hd.getItem(Cbx_timorder.SelectedValue.ToString());
                }
                else
                {
                    MessageBox.Show("Hóa đơn này chưa có thông tin!!!");
                    Cbx_timorder.Text = "";
                    EnableEdit();
                    Btn_luuhd.Enabled = false;
                    Btn_xoahd.Enabled = false;
                    Btn_edit.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn muốn tìm!!!");
            }
        }
        private void btn_capnhatmonan_Click(object sender, EventArgs e)
        {
            if (Cbx_Monan.Text != "" && nud_slmonandachon.Value != 0)
            {
                int sl = ma.GetSL(int.Parse(dgvThucan.CurrentRow.Cells["MaMon"].Value.ToString())) + int.Parse(dgvThucan.CurrentRow.Cells["SLMon"].Value.ToString());
                ma.UpdateSL(sl, int.Parse(dgvThucan.CurrentRow.Cells["MaMon"].Value.ToString()));
                hd.UpdateItem(int.Parse(nud_slmonandachon.Value.ToString()), int.Parse(Cbx_Monan.SelectedValue.ToString()), dgvThucan.CurrentRow.Cells["MaHD"].Value.ToString());
                sl = ma.GetSL(int.Parse(Cbx_Monan.SelectedValue.ToString())) - int.Parse(nud_slmonandachon.Value.ToString());
                ma.UpdateSL(sl, int.Parse(Cbx_Monan.SelectedValue.ToString()));
                MessageBox.Show("Sửa thành công");
                setNull();
                if (check == false)
                {
                    LoadHDItem();
                    Txt_thanhtien.Text = hd.GetTongtien(hd.GetMaHD()).ToString();
                }
                else
                {
                    dgvThucan.DataSource = hd.getItem(Cbx_timorder.SelectedValue.ToString());
                    Txt_thanhtien.Text = hd.GetTongtien(Cbx_timorder.SelectedValue.ToString()).ToString();
                }
            }
            else
            {
                MessageBox.Show("Không thể nhập số lượng bằng 0");
                nud_slmonandachon.Focus();
            }
        }

        private void btn_xoamonandachon_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc chắn xóa món '" + dgvThucan.CurrentRow.Cells["TenMon"].Value.ToString()+"' khỏi hóa đơn ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                int tonkho = ma.GetSL(int.Parse(dgvThucan.CurrentRow.Cells["MaMon"].Value.ToString())) + int.Parse(nud_slmonandachon.Value.ToString());
                ma.UpdateSL(tonkho,int.Parse(dgvThucan.CurrentRow.Cells["MaMon"].Value.ToString()));
                hd.deleteItem(int.Parse(dgvThucan.CurrentRow.Cells["MaMon"].Value.ToString()), dgvThucan.CurrentRow.Cells["MaHD"].Value.ToString());
                MessageBox.Show("Xóa thành công");
                setNull();
                if (check == false)
                    LoadHDItem();
                else
                    dgvThucan.DataSource = hd.getItem(Cbx_timorder.SelectedValue.ToString());

                if (check == false)
                {
                    if (hd.getItem(hd.GetMaHD()).Rows.Count > 0)
                    {
                        Txt_thanhtien.Text=hd.GetTongtien(hd.GetMaHD()).ToString();
                    }
                    else
                        Txt_thanhtien.Text = "0";
                }
                else
                {
                    if (hd.getItem(Cbx_timorder.SelectedValue.ToString()).Rows.Count > 0)
                    {
                        Txt_thanhtien.Text = hd.GetTongtien(Cbx_timorder.SelectedValue.ToString()).ToString();
                    }
                    else
                        Txt_thanhtien.Text = "0";
                }
            
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            setNull();
        }

        private bool KTThongTin()
        {
            bool check=true;
            if (Cbx_ban.Text=="")
            {
                MessageBox.Show("Vui lòng chọn bàn!!!");
                Cbx_ban.Focus();
                check=false;
            }
            if (Txt_thanhtien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tổng tiền!!!");
                Txt_thanhtien.Focus();
                check = false;
            }
            if (dtp_ngaytao.Checked==false)
            {
                MessageBox.Show("Vui lòng chọn ngày tạo!!!");
                dtp_ngaytao.Focus();
                check = false;
            }
            if (txt_giamgia.Text=="")
            {
                MessageBox.Show("Vui lòng nhập số tiền giảm giá!!!");
                txt_giamgia.Focus();
                check = false;
            }
            if (Cbx_ngnhanorder.Text == "")
            {
                MessageBox.Show("Vui lòng chọn người tạo hóa đơn!!!");
                Cbx_ngnhanorder.Focus();
                check = false;
            }
            if (txt_tenKH.Text=="")
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!!!");
                txt_tenKH.Focus();
                check = false;
            }
            if (txt_dcKH.Text=="")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng!!!");
                txt_dcKH.Focus();
                check = false;
            }
            if (txt_sdtKH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng!!!");
                txt_sdtKH.Focus();
                check = false;
            }
            return check;
        }
        private int KTKhachHang(string tenkh,string dckh,string sdtkh)
        {
            KhachHangAccess kh = new KhachHangAccess();
            DataTable dt = kh.GetData();
            int makh = 0;
            bool check = false;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["TenKH"].ToString() == tenkh && dt.Rows[i]["DiaChiKH"].ToString()==dckh && dt.Rows[i]["DienThoaiKH"].ToString()==sdtkh)
                {
                    check = true;
                    makh = int.Parse(dt.Rows[i]["MaKH"].ToString());
                }
            }
            if (check == false)
            {
                kh.InsertKH(tenkh, sdtkh, dckh);
                makh = kh.GetMaKH();
            }
            return makh;
        }
        private void Btn_luuhd_Click(object sender, EventArgs e)
        {
            bool qt = true;
            if (KTThongTin()==true)
            {
                if (check == false)
                {
                    if (hd.getItem(hd.GetMaHD()).Rows.Count > 0)
                    {
                            hd.SaveHD(hd.GetMaHD(), dtp_ngaytao.Value.ToString("yyyy-MM-dd"), hd.GetTongtien(hd.GetMaHD()), int.Parse(Cbx_ngnhanorder.SelectedValue.ToString()), KTKhachHang(txt_tenKH.Text.Trim(), txt_dcKH.Text.Trim(), txt_sdtKH.Text.Trim()), int.Parse(Cbx_ban.SelectedValue.ToString()), decimal.Parse(txt_giamgia.Text.Trim()));
                    }
                    else
                    {
                        MessageBox.Show("Không thể lưu khi chưa có món ăn nào được thêm!!!");
                        qt = false;
                    }
                }
                else
                {
                    if (hd.getItem(Cbx_timorder.SelectedValue.ToString()).Rows.Count > 0)
                    {
                        hd.SaveHD(Cbx_timorder.SelectedValue.ToString(), dtp_ngaytao.Value.ToString("yyyy-MM-dd"), hd.GetTongtien(hd.GetMaHD()), int.Parse(Cbx_ngnhanorder.SelectedValue.ToString()), KTKhachHang(txt_tenKH.Text.Trim(), txt_dcKH.Text.Trim(), txt_sdtKH.Text.Trim()), int.Parse(Cbx_ban.SelectedValue.ToString()), decimal.Parse(txt_giamgia.Text.Trim()));
                    }
                    else
                    {
                        MessageBox.Show("Không thể lưu khi chưa có món ăn nào được thêm!!!");
                        qt = false;
                    }
                }
                if (qt == true)
                {
                    kt = false;
                    MessageBox.Show("Lưu hóa đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetNullAll();
                    dgvThucan.DataSource = hd.getItem("-1");
                    LoadHD();
                }
               
            }
        }

        private void Btn_xoahd_Click(object sender, EventArgs e)
        {
            DialogResult chon= MessageBox.Show("Bạn có chắc chắn xóa hóa đơn '" + Cbx_timorder.Text + "' ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon==DialogResult.Yes)
            {
                try
                {
                    hd.DeleteHD(Cbx_timorder.SelectedValue.ToString());
                }
                catch(Exception loi)
                {
                    MessageBox.Show(loi.ToString());
                }
                
                MessageBox.Show("Xoá thành công");
                SetNullAll();
                dgvThucan.DataSource = hd.getItem("-1");
                LoadHD();
            }
        }

        private void dgvThucan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                btn_capnhatmonan.Enabled = true;
                btn_xoamonandachon.Enabled = true;
                btn_reset.Enabled = true;
                Cbx_Monan.Text = dgvThucan.CurrentRow.Cells["TenMon"].Value.ToString();
                nud_slmonandachon.Value = int.Parse(dgvThucan.CurrentRow.Cells["SLMon"].Value.ToString());
        }

        private void txt_giamgia_TextChanged(object sender, EventArgs e)
        {
            if (txt_giamgia.Text != "0" && txt_giamgia.Text!="")
            {
                if (check == false)
                {
                    if (hd.GetTongtien(hd.GetMaHD()) >0)
                    {
                        if (hd.GetTongtien(hd.GetMaHD()) - decimal.Parse(txt_giamgia.Text.Trim()) < 0)
                        {
                            MessageBox.Show("Số tiền giảm giá vượt quá tổng tiền hóa đơn!!!! vui lòng nhập lại");
                            txt_giamgia.Focus();
                            txt_giamgia.Text = "0";
                        }
                    }
                }

                else
                {
                    if (hd.GetTongtien(Cbx_timorder.SelectedValue.ToString()) > 0)
                    {
                        if (hd.GetTongtien(Cbx_timorder.SelectedValue.ToString()) - decimal.Parse(txt_giamgia.Text.Trim()) < 0)
                        {
                            MessageBox.Show("Số tiền giảm giá vượt quá tổng tiền hóa đơn!!!! vui lòng nhập lại");
                            txt_giamgia.Focus();
                            txt_giamgia.Text = "0";
                        }
                    }
                }
            }
            else
                txt_giamgia.Text = "0";
        }

        private void Txt_thanhtien_TextChanged(object sender, EventArgs e)
        {
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            kt = true;
            EnableEdit();
            dtp_ngaytao.Checked = true;
        }

        private void txt_sdtKH_TextChanged(object sender, EventArgs e)
        {
            if (txt_sdtKH.Text != "")
            {
                int t = 0;
                if(int.TryParse(txt_sdtKH.Text.Trim(),out t))
                {

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số!!!");
                    txt_sdtKH.Text = "";
                }
            }
        }
        private bool KTMonAn(int mamon,string mahd)
        {
            kt = false;
            DataTable dt = hd.getItem(mahd);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (int.Parse(dt.Rows[i]["MaMon"].ToString()) == mamon)
                {
                    MessageBox.Show("Món ăn đã được thêm!!!");
                    kt = true;
                }
                else
                    continue;
            }
            return kt;
        }

        private void Btn_inhd_Click(object sender, EventArgs e)
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
            exRange.Range["C2:E2"].Value = "HĐ BÁN HÀNG";
            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "Select * from HDBanHang,KhachHang,NhanVien where HDBanHang.MaNV=NhanVien.MaNV and HDBanHang.MaKH=KhachHang.MaKH and MaHDBanHang='"+Cbx_timorder.SelectedValue.ToString()+"'";
            tblThongtinHD = db.Execute(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0]["MaHDBanHang"].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0]["TenKH"].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0]["DiaChiKH"].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value =" "+tblThongtinHD.Rows[0]["DienThoaiKH"].ToString();
            //Lấy thông tin các mặt hàng
            sql = "SELECT b.TenMon,a.SLMon,b.GiaMon FROM HDBanHang as c,ChiTietHDBanHang as a,MonAn as b WHERE c.MaHDBanHang=a.MaHD and a.MaMon = b.MaMon and c.MaHDBanHang='" + Cbx_timorder.SelectedValue.ToString() + "'";
            tblThongtinHang = db.Execute(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên món ăn";
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
            exRange = exSheet.Cells[cot][hang + 13];
            exRange.Font.Bold = true;
            exRange.Value2 = "Thành tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 13];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0]["ThanhTien"].ToString();
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Giảm giá:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0]["GiamGia"].ToString();
            exRange = exSheet.Cells[cot][hang + 15];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 15];
            exRange.Font.Bold = true;
            exRange.Value2 = (decimal.Parse(tblThongtinHD.Rows[0]["ThanhTien"].ToString())-decimal.Parse(tblThongtinHD.Rows[0]["GiamGia"].ToString())).ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0]["NgayTao"]);
            exRange.Range["A1:C1"].Value = "Cần Thơ, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A3:C3"].MergeCells = true;
            exRange.Range["A3:C3"].Font.Italic = true;
            exRange.Range["A3:C3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:C3"].Value = tblThongtinHD.Rows[0]["TenNV"];
            exSheet.Name = "Hóa đơn bán hàng";
            exApp.Visible = true;
        }
    }
}
