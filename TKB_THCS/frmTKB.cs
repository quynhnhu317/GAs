using DevComponents.AdvTree;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKB_THCS;
using TKB_THCS.AppCode;
using Excel = Microsoft.Office.Interop.Excel;

namespace TKB_THCS
{
    public partial class frmTKB : MetroFramework.Forms.MetroForm
    {

        private TKB_THCS.AppCode.NhiemSacThe nst;
        DataTable dtGVs, dtGVLop;
        public NhiemSacThe NST
        {
            get { return nst; }
            set
            {
                nst = value;
                comboBox1.Items.Clear();
                foreach (TKB_THCS.AppCode.LopHoc lop in nst.DSLop.GetDanhSach())
                {
                    Item p = new Item("Lớp " + lop.TenLop, lop.IDLop.ToString());
                    comboBox1.Items.Add(p);
                }
                ShowDSGV();
            }
        }

        public frmTKB(TKB_THCS.AppCode.NhiemSacThe n)
        {
            InitializeComponent();
            NST = n;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        private class Item
        {
            public string Name;
            public string Value;
            public Item(string name, string value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        //hiển thị thời khóa biểu vs id tương ứng
        private void LoadTKB(string sIDLop)
        {
            int idLop;
            int.TryParse(sIDLop, out idLop);
            AppConstant c = new TKB_THCS.AppCode.AppConstant();

            //xóa trống lại các listbox
            if (idLop > 0)
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                listBox4.Items.Clear();
                listBox5.Items.Clear();
                listBox6.Items.Clear();
                listErr1.Items.Clear();
                listErr2.Items.Clear();
                listErr3.Items.Clear();
                listErr4.Items.Clear();
                listErr5.Items.Clear();
                listErr6.Items.Clear();

                //duyệt các lớp để tìm ra lớp có id trùng khớp
                foreach (TKB_THCS.AppCode.LopHoc lop in nst.DSLop.GetDanhSach())
                {
                    if (lop.IDLop == idLop)
                    {
                        //set giá trị cho các lable
                        if (lop.BuoiHoc == c.BuoiSang)
                            lblBuoi.Text = "Buổi học: Sáng";
                        else
                            lblBuoi.Text = "Buổi học: Chiều";
                        lblTongTiet.Text = "Tổng tiết: " + lop.TongTiet.ToString();
                        lblTongViPham.Text = "Vi phạm: " + lop.TongTietViPham.ToString();
                        lblTongHopLe.Text = "Hợp lệ: " + lop.TongTietHopLe.ToString();
                        lblGVCN.Text = "GVCN: " + lop.TenGVCN;

                        //thay đổi màu nếu có vi phạm
                        if (lop.TongTietViPham > 0) lblTongViPham.ForeColor = Color.Red;
                        else lblTongViPham.ForeColor = Color.Black;

                        ShowDSGV(lop);

                        ShowThu(lop.Thu[c.Thu2], listBox1, listErr1);
                        ShowThu(lop.Thu[c.Thu3], listBox2, listErr2);
                        ShowThu(lop.Thu[c.Thu4], listBox3, listErr3);
                        ShowThu(lop.Thu[c.Thu5], listBox4, listErr4);
                        ShowThu(lop.Thu[c.Thu6], listBox5, listErr5);
                        ShowThu(lop.Thu[c.Thu7], listBox6, listErr6);
                    }
                }
            }
        }

        //show danh sách giáo viên dạy lớp cụ thể
        private void ShowDSGV(TKB_THCS.AppCode.LopHoc lop)
        {
            dtGVLop = new DataTable();
            dtGVLop.Columns.Add("GiaoVien", System.Type.GetType("System.String"));
            dtGVLop.Columns.Add("MonHoc", System.Type.GetType("System.String"));
            gridGVLop.DataSource = dtGVLop;
            gridGVLop.Columns["GiaoVien"].HeaderText = "Giáo viên";
            gridGVLop.Columns["MonHoc"].HeaderText = "Môn học";
            gridGVLop.Columns["GiaoVien"].Width = 160;
            gridGVLop.Columns["MonHoc"].Width = 100;

            foreach (GVDayMonHoc day in lop.DSDayHoc.GetDanhSach())
            {
                DataRow row = dtGVLop.NewRow();
                row["GiaoVien"] = day.TenGV;
                row["MonHoc"] = day.TenMon;
                dtGVLop.Rows.Add(row);
            }
        }

        //show toàn bộ giáo viên
        private void ShowDSGV()
        {
            dtGVs = new DataTable();
            dtGVs.Columns.Add("GiaoVien", System.Type.GetType("System.String"));
            dtGVs.Columns.Add("MonHoc", System.Type.GetType("System.String"));
            dtGVs.Columns.Add("Lop", System.Type.GetType("System.String"));
            dataGridView1.DataSource = dtGVs;
            dataGridView1.Columns["GiaoVien"].HeaderText = "Giáo viên";
            dataGridView1.Columns["MonHoc"].HeaderText = "Môn học";
            dataGridView1.Columns["Lop"].HeaderText = "Lớp";
            dataGridView1.Columns["GiaoVien"].Width = 160;
            dataGridView1.Columns["MonHoc"].Width = 100;
            dataGridView1.Columns["Lop"].Width = 60;

            foreach (GVDayMonHoc day in nst.DSDayHoc.GetDanhSach())
            {
                DataRow row = dtGVs.NewRow();
                row["GiaoVien"] = day.TenGV;
                row["MonHoc"] = day.TenMon;
                row["Lop"] = day.TenLop;
                dtGVs.Rows.Add(row);
            }
        }

        //hiển thị thời khóa biểu trên từng listbox
        private void ShowThu(Thu thu, ListBox listTKB, ListBox listErr)
        {
            //duyệt từng tiết trong ngày
            foreach (Tiet tiet in thu.Tiet)
            {
                if (tiet.IDMon > 0) listTKB.Items.Add(tiet.TenMon);
                else if (tiet.Loai == LoaiTiet.ChaoCo) listTKB.Items.Add("Chào cờ");
                else if (tiet.Loai == LoaiTiet.SinhHoat) listTKB.Items.Add("Sinh hoạt");
                else listTKB.Items.Add("---");

                if (tiet.LoaiViPham == LoaiViPham.KhongViPham)
                {
                    listErr.Items.Add("");
                }
                else if (tiet.LoaiViPham == LoaiViPham.TrungLichGiaoVien)
                {
                    listErr.Items.Add("G");
                    listErr.ForeColor = Color.Red;
                }
                else if (tiet.LoaiViPham == LoaiViPham.ThieuGiaoVien)
                {
                    listErr.ForeColor = Color.Red;
                    listErr.Items.Add("V");
                }

                else if (tiet.LoaiViPham == LoaiViPham.ThieuSoBuoi || tiet.LoaiViPham == LoaiViPham.QuaSoBuoi)
                {
                    listErr.ForeColor = Color.Red;
                    listErr.Items.Add("B");
                }
                else if (tiet.LoaiViPham == LoaiViPham.QuaSoTiet)
                {
                    listErr.ForeColor = Color.Red;
                    listErr.Items.Add("T");
                }
                else
                {
                    listErr.ForeColor = Color.Red;
                    listErr.Items.Add("X");
                }
            }
        }

        public frmTKB()
        {
            InitializeComponent();
        }

        private void frmTKB_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            btncontinue.Enabled = false;
            lblkytu.Visible = false;
            btnXuatex.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0) ClearSelected(1);
            listErr1.SelectedIndex = listBox1.SelectedIndex;
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0) ClearSelected(2);
            listErr2.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex >= 0) ClearSelected(3);
            listErr3.SelectedIndex = listBox3.SelectedIndex;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex >= 0) ClearSelected(4);
            listErr4.SelectedIndex = listBox4.SelectedIndex;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox5.SelectedIndex >= 0) ClearSelected(5);
            listErr5.SelectedIndex = listBox5.SelectedIndex;
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox6.SelectedIndex >= 0) ClearSelected(6);
            listErr6.SelectedIndex = listBox6.SelectedIndex;
        }

        private void ClearSelected(int Index)
        {
            if (Index != 1) { listBox1.ClearSelected(); listErr1.ClearSelected(); }
            if (Index != 2) { listBox2.ClearSelected(); listErr2.ClearSelected(); }
            if (Index != 3) { listBox3.ClearSelected(); listErr3.ClearSelected(); }
            if (Index != 4) { listBox4.ClearSelected(); listErr4.ClearSelected(); }
            if (Index != 5) { listBox5.ClearSelected(); listErr5.ClearSelected(); }
            if (Index != 6) { listBox6.ClearSelected(); listErr6.ClearSelected(); }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Item itm = (Item)comboBox1.SelectedItem;
            LoadTKB(itm.Value);
            string str = lblTongViPham.Text;
            //lấy ra ký tự cuối 
            char char9 = str[9];
            btnXuatex.Text = "Xuất TKB " + comboBox1.SelectedItem.ToString();
            //int abc = Convert.ToInt32(char9);
            lblkytu.Text = char9.ToString();
            if (lblkytu.Text == "0")
            {
                lblthongbao.ForeColor = Color.Green;
                lblthongbao.Text = "Hết vi phạm có thể xuất dữ liệu";
                btncontinue.Enabled = false;
                btnXuatex.Enabled = true;

            }
            else
            {
                lblthongbao.ForeColor = Color.Red;
                lblthongbao.Text = "Còn vi phạm tiếp tục tiến hóa";
                btncontinue.Enabled = true;
                btnXuatex.Enabled = false;
            }
        }

        //khi ấn nút tiết hóa thì sẽ quay lại trang phân lịch
        private void btncontinue_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmMain fMain = (frmMain)this.MdiParent;
            if (fMain != null)
                fMain.ShowTienhoa();
        }

        //xuất tkb của lớp đang được hiển thị ra excel
        private void btnXuatex_Click(object sender, EventArgs e)
        {
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xls";
            fsave.ShowDialog();

            //Xử lý
            if (fsave.FileName != "")
            {
                //tạo excel app
                Excel.Application app = new Excel.Application();
                //tạo 1 workbook
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                //tạo sheet
                Excel._Worksheet sheet = null;
                try
                {
                    //Xuất dữ liệu
                    sheet = wb.ActiveSheet;
                    //đặt tên trang sheet
                    sheet.Name = "Thời khóa biểu " + comboBox1.Text + " xuất ra";

                    //tiêu đề chung
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 7]].Merge();
                    sheet.Cells[1, 1] = "Thời Khóa Biểu " + comboBox1.Text + ", " + lblBuoi.Text;
                    sheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[1, 1].Font.Name = "Times New Roman";
                    sheet.Cells[1, 1].Font.Size = 20;
                    sheet.Cells[1, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;

                    //định dạng tiêu đề bảng
                    sheet.Cells[2, 1] = "Tiết";
                    sheet.Cells[2, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 1].Font.Name = "Times New Roman";
                    sheet.Cells[2, 1].Font.Size = 14;
                    sheet.Cells[2, 1].ColumnWidth = 14;
                    sheet.Cells[2, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 1].Font.Bold = true;

                    sheet.Cells[2, 2] = "Thứ 2";
                    sheet.Cells[2, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 2].Font.Name = "Times New Roman";
                    sheet.Cells[2, 2].Font.Size = 14;
                    sheet.Cells[2, 2].ColumnWidth = 14;
                    sheet.Cells[2, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 2].Font.Bold = true;

                    sheet.Cells[2, 3] = "Thứ 3";
                    sheet.Cells[2, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 3].Font.Name = "Times New Roman";
                    sheet.Cells[2, 3].Font.Size = 14;
                    sheet.Cells[2, 3].ColumnWidth = 14;
                    sheet.Cells[2, 3].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 3].Font.Bold = true;

                    sheet.Cells[2, 4] = "Thứ 4";
                    sheet.Cells[2, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 4].Font.Name = "Times New Roman";
                    sheet.Cells[2, 4].Font.Size = 14;
                    sheet.Cells[2, 4].ColumnWidth = 14;
                    sheet.Cells[2, 4].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 4].Font.Bold = true;

                    sheet.Cells[2, 5] = "Thứ 5";
                    sheet.Cells[2, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 5].Font.Name = "Times New Roman";
                    sheet.Cells[2, 5].Font.Size = 14;
                    sheet.Cells[2, 5].ColumnWidth = 14;
                    sheet.Cells[2, 5].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 5].Font.Bold = true;

                    sheet.Cells[2, 6] = "Thứ 6";
                    sheet.Cells[2, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 6].Font.Name = "Times New Roman";
                    sheet.Cells[2, 6].Font.Size = 14;
                    sheet.Cells[2, 5].ColumnWidth = 14;
                    sheet.Cells[2, 6].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 6].Font.Bold = true;

                    sheet.Cells[2, 7] = "Thứ 7";
                    sheet.Cells[2, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 7].Font.Name = "Times New Roman";
                    sheet.Cells[2, 7].Font.Size = 14;
                    sheet.Cells[2, 7].ColumnWidth = 14;
                    sheet.Cells[2, 7].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 7].Font.Bold = true;

                    //Sinh dữ liệu thứ tự tiết học
                    for (int i = 1; i <= listTiet.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 1] = listTiet.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 1].Font.Name = "Times New Roman";
                        sheet.Cells[i + 2, 1].Font.Size = 14;
                        sheet.Cells[i + 2, 1].ColumnWidth = 14;
                        sheet.Cells[i + 2, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    //sinh dữ liệu của thứ 2
                    for (int i = 1; i <= listBox1.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 2] = listBox1.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 2].Font.Name = "Times New Roman";
                        sheet.Cells[i + 2, 2].Font.Size = 14;
                        sheet.Cells[i + 2, 2].ColumnWidth = 14;
                        sheet.Cells[i + 2, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox2.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 3] = listBox2.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 3].Font.Name = "Times New Roman";
                        sheet.Cells[i + 2, 3].Font.Size = 14;
                        sheet.Cells[i + 2, 3].ColumnWidth = 14;
                        sheet.Cells[i + 2, 3].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox3.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 4] = listBox3.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 4].Font.Name = "Times New Roman";
                        sheet.Cells[i + 2, 4].Font.Size = 14;
                        sheet.Cells[i + 2, 4].ColumnWidth = 14;
                        sheet.Cells[i + 2, 4].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox4.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 5] = listBox4.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 5].Font.Name = "Times New Roman";
                        sheet.Cells[i + 2, 5].Font.Size = 14;
                        sheet.Cells[i + 2, 5].ColumnWidth = 14;
                        sheet.Cells[i + 2, 5].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox5.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 6] = listBox5.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 6].Font.Name = "Times New Roman";
                        sheet.Cells[i + 2, 6].Font.Size = 14;
                        sheet.Cells[i + 2, 6].ColumnWidth = 14;
                        sheet.Cells[i + 2, 6].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox6.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 7] = listBox6.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 7].Font.Name = "Times New Roman";
                        sheet.Cells[i + 2, 7].Font.Size = 14;
                        sheet.Cells[i + 2, 7].ColumnWidth = 14;
                        sheet.Cells[i + 2, 7].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }


                    wb.SaveAs(fsave.FileName);
                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    app.Quit();
                    wb = null;
                }
            }

            else
            {
                MessageBox.Show("Hủy bỏ xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
