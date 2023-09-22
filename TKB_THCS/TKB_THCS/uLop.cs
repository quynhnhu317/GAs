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
    public partial class uLop : MetroFramework.Controls.MetroUserControl
    {
        public uLop()
        {
            InitializeComponent();
        }

        DbEntities db;
        private void uLop_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
            giaoVienBindingSource.DataSource = db.GiaoViens.ToList();
            lopHocBindingSource.DataSource = db.LopHocs.ToList();
            phongHocBindingSource.DataSource = db.PhongHocs.ToList();
        }

        private async void mtThem_Click(object sender, EventArgs e)
        {
            using (fLop frm = new fLop(new LopHoc()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        lopHocBindingSource.Add(frm.Capnhatlophoc);
                        db.LopHocs.Add(frm.Capnhatlophoc);
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
            LopHoc obj = lopHocBindingSource.Current as LopHoc;
            if (obj != null)
            {
                using (fLop frm = new fLop(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            lopHocBindingSource.EndEdit();
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
                int rows = dataLophoc.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataLophoc.Rows[i].Selected)
                    {
                        db.LopHocs.Remove(dataLophoc.Rows[i].DataBoundItem as LopHoc);
                        lopHocBindingSource.RemoveAt(dataLophoc.Rows[i].Index);
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
                    lopHocBindingSource.EndEdit();
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
            giaoVienBindingSource.DataSource = db.GiaoViens.ToList();
            lopHocBindingSource.DataSource = db.LopHocs.ToList();
            phongHocBindingSource.DataSource = db.PhongHocs.ToList();
            Cursor.Current = Cursors.Default;
        }

        private void dataLophoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataLophoc.RowCount; i++)
                dataLophoc.Rows[i].Cells[0].Value = i + 1;
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void dataLophoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
