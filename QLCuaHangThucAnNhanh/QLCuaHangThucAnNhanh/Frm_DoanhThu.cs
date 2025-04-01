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
    public partial class Frm_DoanhThu : Form
    {
        public Frm_DoanhThu()
        {
            InitializeComponent();
        }
        HDNhapAccess hdn = new HDNhapAccess();
        HDBanHangAccess hdb = new HDBanHangAccess();

        private void Frm_DoanhThu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            if(dtpngaycuoi.Checked!=false && dtp_ngaydau.Checked != false)
            {
                if (hdb.KTNgay(dtp_ngaydau.Value.ToString("yyyy-MM-dd"), dtpngaycuoi.Value.ToString("yyyy-MM-dd")).Rows.Count > 0)
                    txt_doanhthu.Text = hdb.GetDoanhThu(dtp_ngaydau.Value.ToString("yyyy-MM-dd"), dtpngaycuoi.Value.ToString("yyyy-MM-dd")).ToString();
                else
                {
                    txt_doanhthu.Text = "0";
                    lb_doanhthu.Text = "Không có dữ liệu từ ngày '" + dtp_ngaydau.Value.ToString("yyyy-MM-dd") + "' đến ngày '" + dtpngaycuoi.Value.ToString() + "' để thống kê!";
                }

                if (hdn.KTNgay(dtp_ngaydau.Value.ToString("yyyy-MM-dd"), dtpngaycuoi.Value.ToString("yyyy-MM-dd")).Rows.Count > 0)
                    txt_nguyenlieu.Text = hdn.GetPhiNL(dtp_ngaydau.Value.ToString("yyyy-MM-dd"), dtpngaycuoi.Value.ToString("yyyy-MM-dd")).ToString();
                else
                {
                    lb_doanhthu.Text = "Không có dữ liệu từ ngày '" + dtp_ngaydau.Value.ToString("yyyy-MM-dd") + "' đến ngày '" + dtpngaycuoi.Value.ToString() + "' để thống kê!";
                    txt_nguyenlieu.Text = "0";
                }
                decimal loinhuan = decimal.Parse(txt_doanhthu.Text) - decimal.Parse(txt_nguyenlieu.Text);
                txt_loinhuan.Text = loinhuan.ToString();
            }
            else
            {
                if (dtp_ngaydau.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn ngày đầu!!!");
                    dtp_ngaydau.Focus();
                }
                if (dtpngaycuoi.Checked == false)
                {
                    MessageBox.Show("Vui lòng chọn ngày cuối!!!");
                    dtpngaycuoi.Focus();
                }
            }
            Btn_inhd.Enabled = true;
        }

        private void Frm_DoanhThu_Load(object sender, EventArgs e)
        {
            lb_doanhthu.Text = "";
            lb_nguyenlieu.Text = "";
            Btn_inhd.Enabled = false;
        }

        private void Btn_inhd_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            //string sql;
            //int hang = 0, cot = 0;
            //DataTable tblThongtinHD, tblThongtinHang;
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
            exRange.Range["C2:E2"].Value = "Bảng thống kê";
            // Biểu diễn thông tin chung của hóa đơn bán
            //sql = "Select * from HDBanHang,KhachHang,NhanVien where HDBanHang.MaNV=NhanVien.MaNV and HDBanHang.MaKH=KhachHang.MaKH and MaHDBanHang='" + Cbx_timorder.SelectedValue.ToString() + "'";
            //tblThongtinHD = db.Execute(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Ngày thống kê:";
            exRange.Range["C6:G6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C6:G6"].MergeCells = true;
            exRange.Range["C6:G6"].Value = "Từ ngày "+dtp_ngaydau.Value.ToString("dd-MM-yyyy")+" đến ngày "+dtpngaycuoi.Value.ToString("dd-MM-yyyy");
            exRange.Range["B7:B7"].Value = "Doanh thu:";
            exRange.Range["C7:E7"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = txt_doanhthu.Text;
            exRange.Range["B8:B8"].Value = "Phí nguyên liệu:";
            exRange.Range["C8:E8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = txt_nguyenlieu.Text;
            exRange.Range["B9:B9"].Value = "Lợi nhuận:";
            exRange.Range["C9:E9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = txt_loinhuan.Text;
            DateTime d = DateTime.Today;
            exRange.Range["D10"].Value = "Cần Thơ, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exSheet.Name = "Thống kê";
            exApp.Visible = true;
        }
    }
}
