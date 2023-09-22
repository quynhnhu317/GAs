using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKB_THCS
{
    public partial class uPhong : MetroFramework.Controls.MetroUserControl
    {
        public uPhong()
        {
            InitializeComponent();
        }

        DbEntities db;
        private void uPhong_Load(object sender, EventArgs e)
        {
            
            db = new DbEntities();
            phongHocBindingSource.DataSource = db.PhongHocs.ToList();
            dataPhong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataPhong.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataPhong.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataPhong.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataPhong.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataPhong.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dataPhong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataPhong.RowCount; i++)
                dataPhong.Rows[i].Cells[0].Value = i + 1;
        }

        private async void mtThem_Click(object sender, EventArgs e)
        {
            using (fPhong frm = new fPhong(new PhongHoc()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        phongHocBindingSource.Add(frm.Capnhatphonghoc);
                        db.PhongHocs.Add(frm.Capnhatphonghoc);
                        await db.SaveChangesAsync();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private async void mtSua_Click(object sender, EventArgs e)
        {
            PhongHoc obj = phongHocBindingSource.Current as PhongHoc;
            if (obj != null)
            {
                using (fPhong frm = new fPhong(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            phongHocBindingSource.EndEdit();
                            await db.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void mtXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int rows = dataPhong.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataPhong.Rows[i].Selected)
                    {
                        db.PhongHocs.Remove(dataPhong.Rows[i].DataBoundItem as PhongHoc);
                        phongHocBindingSource.RemoveAt(dataPhong.Rows[i].Index);
                    }
                }
            }
        }

        private async void mtLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    phongHocBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mtHuy_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            phongHocBindingSource.DataSource = db.PhongHocs.ToList();
            Cursor.Current = Cursors.Default;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void dataPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
