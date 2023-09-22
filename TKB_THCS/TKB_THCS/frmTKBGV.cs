using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TKB_THCS.AppCode;
using Excel = Microsoft.Office.Interop.Excel;

namespace TKB_THCS
{
    public partial class frmTKBGV : MetroFramework.Forms.MetroForm
    {

        private TKB_THCS.AppCode.NhiemSacThe nst;
        private DataTable dtGV;
        private bool Loading = false;
        public TKB_THCS.AppCode.NhiemSacThe NST
        {
            get { return nst; }
            set
            {
                nst = value;
                BuildBlankTKB();

                dtGV = new DataTable();
                dtGV.Columns.Add("IDGV", System.Type.GetType("System.Int32"));
                dtGV.Columns.Add("GiaoVien", System.Type.GetType("System.String"));
                dtGV.Columns.Add("MonHoc", System.Type.GetType("System.String"));
                gridGV.DataSource = dtGV;

                gridGV.Columns["IDGV"].HeaderText = "ID";
                gridGV.Columns["GiaoVien"].HeaderText = "Giáo viên";
                gridGV.Columns["MonHoc"].HeaderText = "Môn dạy";
                gridGV.Columns["IDGV"].Width = 40;
                gridGV.Columns["GiaoVien"].Width = 140;
                gridGV.Columns["MonHoc"].Width = 70;
                gridGV.Columns["IDGV"].Visible = false;

                foreach (TKB_THCS.AppCode.GiaoVien gv in nst.DSGiaoVien.GetDanhSach())
                {
                    DataRow row = dtGV.NewRow();
                    row["IDGV"] = gv.IDGV;
                    row["GiaoVien"] = gv.TenGV;
                    row["MonHoc"] = gv.TenMon;
                    dtGV.Rows.Add(row);
                }
            }
        }

        public frmTKBGV(TKB_THCS.AppCode.NhiemSacThe n)
    {
      InitializeComponent();
      NST = n;
    }
        public frmTKBGV()
        {
            InitializeComponent();
        }

        private void uLichGV_Load(object sender, EventArgs e)
        {
            BuildBlankTKB();
            btnXuat.Enabled = false;
        }

        private void BuildBlankTKB()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();

            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();
            listBox11.Items.Clear();
            listBox12.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add("---");
                listBox2.Items.Add("---");
                listBox3.Items.Add("---");
                listBox4.Items.Add("---");
                listBox5.Items.Add("---");
                listBox6.Items.Add("---");

                listBox7.Items.Add("---");
                listBox8.Items.Add("---");
                listBox9.Items.Add("---");
                listBox10.Items.Add("---");
                listBox11.Items.Add("---");
                listBox12.Items.Add("---");
            }
        }

        private void LoadData(int rowIndex)
        {
            if (Loading)
            {
                MessageBox.Show("Đang tải dữ liệu, vui lòng thử lại trong vài giây");
            }
            else if (rowIndex >= 0)
            {
                Loading = true;
                DataGridViewCell cell = (DataGridViewCell)gridGV.Rows[rowIndex].Cells[0];
                AppConstant c = new TKB_THCS.AppCode.AppConstant();
                int IDGV = 0;
                string text;
                if (int.TryParse(cell.Value.ToString(), out IDGV))
                {
                    BuildBlankTKB();
                    foreach (TKB_THCS.AppCode.LopHoc lop in nst.DSLop.GetDanhSach())
                        foreach (Thu thu in lop.Thu)
                            foreach (Tiet tiet in thu.Tiet)
                                if (tiet.IDGV == IDGV)
                                    if (lop.BuoiHoc == c.BuoiSang)
                                    {
                                        text = lop.TenLop;
                                        if (thu.Index == c.Thu2) listBox1.Items[tiet.Index] = text;
                                        if (thu.Index == c.Thu3) listBox2.Items[tiet.Index] = text;
                                        if (thu.Index == c.Thu4) listBox3.Items[tiet.Index] = text;
                                        if (thu.Index == c.Thu5) listBox4.Items[tiet.Index] = text;
                                        if (thu.Index == c.Thu6) listBox5.Items[tiet.Index] = text;
                                        if (thu.Index == c.Thu7) listBox6.Items[tiet.Index] = text;
                                    }
                                    else
                                    {
                                        text = lop.TenLop;
                                        if (thu.Index == c.Thu2) listBox7.Items[tiet.Index] = text;
                                        if (thu.Index == c.Thu3) listBox8.Items[tiet.Index] = text;
                                        if (thu.Index == c.Thu4) listBox9.Items[tiet.Index] = text;
                                        if (thu.Index == c.Thu5) listBox10.Items[tiet.Index] = text;
                                        if (thu.Index == c.Thu6) listBox11.Items[tiet.Index] = text;
                                        if (thu.Index == c.Thu7) listBox12.Items[tiet.Index] = text;
                                    }
                }
                Loading = false;
            }
        }

        private void gridGV_SelectionChanged(object sender, EventArgs e)
        {
            LoadData(gridGV.CurrentRow.Index);
        }

        private void gridGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridGV_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                LoadData(gridGV.CurrentRow.Index);
            }
            catch { }
        }

        private void btnXuat_Click(object sender, EventArgs e)
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
                    sheet.Name = "Lịch dạy giáo viên";
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 7]].Merge();
                    sheet.Cells[1, 1] = "Lịch dạy giáo viên " + lbGV.Text + ", môn: " + lbMon.Text;
                    sheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[1, 1].Font.Size = 20;
                    sheet.Cells[1, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;


                    //sinh tiêu đề
                    sheet.Cells[8, 1] = "Chiều";
                    sheet.Cells[8, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[8, 1].Font.Size = 14;
                    sheet.Cells[8, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[8, 1].Font.Bold = true;

                    sheet.Cells[8, 2] = "Thứ 2";
                    sheet.Cells[8, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[8, 2].Font.Size = 14;
                    sheet.Cells[8, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[8, 2].Font.Bold = true;

                    sheet.Cells[8, 3] = "Thứ 3";
                    sheet.Cells[8, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[8, 3].Font.Size = 14;
                    sheet.Cells[8, 3].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[8, 3].Font.Bold = true;

                    sheet.Cells[8, 4] = "Thứ 4";
                    sheet.Cells[8, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[8, 4].Font.Size = 14;
                    sheet.Cells[8, 4].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[8, 4].Font.Bold = true;

                    sheet.Cells[8, 5] = "Thứ 5";
                    sheet.Cells[8, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[8, 5].Font.Size = 14;
                    sheet.Cells[8, 5].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[8, 5].Font.Bold = true;

                    sheet.Cells[8, 6] = "Thứ 6";
                    sheet.Cells[8, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[8, 6].Font.Size = 14;
                    sheet.Cells[8, 6].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[8, 6].Font.Bold = true;

                    sheet.Cells[8, 7] = "Thứ 7";
                    sheet.Cells[8, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[8, 7].Font.Size = 14;
                    sheet.Cells[8, 7].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[8, 7].Font.Bold = true;

                    sheet.Cells[2, 1] = "Sáng";
                    sheet.Cells[2, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 1].Font.Size = 14;
                    sheet.Cells[2, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 1].Font.Bold = true;

                    sheet.Cells[2, 2] = "Thứ 2";
                    sheet.Cells[2, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 2].Font.Size = 14;
                    sheet.Cells[2, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 2].Font.Bold = true;

                    sheet.Cells[2, 3] = "Thứ 3";
                    sheet.Cells[2, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 3].Font.Size = 14;
                    sheet.Cells[2, 3].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 3].Font.Bold = true;

                    sheet.Cells[2, 4] = "Thứ 4";
                    sheet.Cells[2, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 4].Font.Size = 14;
                    sheet.Cells[2, 4].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 4].Font.Bold = true;

                    sheet.Cells[2, 5] = "Thứ 5";
                    sheet.Cells[2, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 5].Font.Size = 14;
                    sheet.Cells[2, 5].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 5].Font.Bold = true;

                    sheet.Cells[2, 6] = "Thứ 6";
                    sheet.Cells[2, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 6].Font.Size = 14;
                    sheet.Cells[2, 6].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 6].Font.Bold = true;

                    sheet.Cells[2, 7] = "Thứ 7";
                    sheet.Cells[2, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 7].Font.Size = 14;
                    sheet.Cells[2, 7].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    sheet.Cells[2, 7].Font.Bold = true;

                    //Sinh dữ liệu

                    for (int i = 1; i <= listTiet.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 1] = listTiet.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 1].Font.Size = 14;
                        sheet.Cells[i + 2, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox1.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 2] = listBox1.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 2].Font.Size = 14;
                        sheet.Cells[i + 2, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox2.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 3] = listBox2.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 3].Font.Size = 14;
                        sheet.Cells[i + 2, 3].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox3.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 4] = listBox3.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 4].Font.Size = 14;
                        sheet.Cells[i + 2, 4].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox4.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 5] = listBox4.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 5].Font.Size = 14;
                        sheet.Cells[i + 2, 5].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox5.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 6] = listBox5.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 6].Font.Size = 14;
                        sheet.Cells[i + 2, 6].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox6.Items.Count; i++)
                    {
                        sheet.Cells[i + 2, 7] = listBox6.Items[i - 1].ToString();
                        sheet.Cells[i + 2, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 2, 7].Font.Size = 14;
                        sheet.Cells[i + 2, 7].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    //Chiều

                    for (int i = 1; i <= listTiet.Items.Count; i++)
                    {
                        sheet.Cells[i + 8, 1] = listTiet.Items[i - 1].ToString();
                        sheet.Cells[i + 8, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 8, 1].Font.Size = 14;
                        sheet.Cells[i + 8, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox7.Items.Count; i++)
                    {
                        sheet.Cells[i + 8, 2] = listBox7.Items[i - 1].ToString();
                        sheet.Cells[i + 8, 2].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 8, 2].Font.Size = 14;
                        sheet.Cells[i + 8, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox8.Items.Count; i++)
                    {
                        sheet.Cells[i + 8, 3] = listBox8.Items[i - 1].ToString();
                        sheet.Cells[i + 8, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 8, 3].Font.Size = 14;
                        sheet.Cells[i + 8, 3].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox9.Items.Count; i++)
                    {
                        sheet.Cells[i + 8, 4] = listBox9.Items[i - 1].ToString();
                        sheet.Cells[i + 8, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 8, 4].Font.Size = 14;
                        sheet.Cells[i + 8, 4].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox10.Items.Count; i++)
                    {
                        sheet.Cells[i + 8, 5] = listBox10.Items[i - 1].ToString();
                        sheet.Cells[i + 8, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 8, 5].Font.Size = 14;
                        sheet.Cells[i + 8, 5].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox11.Items.Count; i++)
                    {
                        sheet.Cells[i + 8, 6] = listBox11.Items[i - 1].ToString();
                        sheet.Cells[i + 8, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 8, 6].Font.Size = 14;
                        sheet.Cells[i + 8, 6].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }

                    for (int i = 1; i <= listBox12.Items.Count; i++)
                    {
                        sheet.Cells[i + 8, 7] = listBox12.Items[i - 1].ToString();
                        sheet.Cells[i + 8, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[i + 8, 7].Font.Size = 14;
                        sheet.Cells[i + 8, 7].Borders.Weight = Excel.XlBorderWeight.xlThin;
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
                MessageBox.Show("Đã hủy bỏ xuất dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridGV_MouseClick(object sender, MouseEventArgs e)
        {
            
            
            if(gridGV.Rows.Count > 0)
            {
                try 
                {
                    btnXuat.Text = "Xuất lịch dạy giáo viên: " + gridGV.SelectedRows[0].Cells[1].Value.ToString();
                    lbGV.Text = gridGV.SelectedRows[0].Cells[1].Value.ToString();
                    lbMon.Text = gridGV.SelectedRows[0].Cells[2].Value.ToString();
                    if (lbGV.Text == "")
                    {
                        btnXuat.Enabled = false;
                    }
                    else
                    {
                        btnXuat.Enabled = true;
                    }
                }
                catch (Exception ex) { }
                
            }
            else
            {
                MessageBox.Show("Không có giáo viên để chọn!");
            }

            
            
        }
    }
}
