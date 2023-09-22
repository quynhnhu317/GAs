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
    public partial class uMon : MetroFramework.Controls.MetroUserControl
    {
        public uMon()
        {
            InitializeComponent();
        }

        DbEntities db;
        private void uMon_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
            monHocBindingSource.DataSource = db.MonHocs.ToList();
            

        }

        private async void mtThem_Click(object sender, EventArgs e)
        {
            using (fMon frm = new fMon(new MonHoc() { Khoi6 = false, Khoi7 = false, Khoi8 = false, Khoi9 = false, Kep = false, Phu = false }))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        monHocBindingSource.Add(frm.Capnhatmonhoc);
                        db.MonHocs.Add(frm.Capnhatmonhoc);
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
            MonHoc obj = monHocBindingSource.Current as MonHoc;
            if (obj != null)
            {
                using (fMon frm = new fMon(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            monHocBindingSource.EndEdit();
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
                int rows = dataMonhoc.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataMonhoc.Rows[i].Selected)
                    {
                        db.MonHocs.Remove(dataMonhoc.Rows[i].DataBoundItem as MonHoc);
                        monHocBindingSource.RemoveAt(dataMonhoc.Rows[i].Index);
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
                    monHocBindingSource.EndEdit();
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
            monHocBindingSource.DataSource = db.MonHocs.ToList();
            Cursor.Current = Cursors.Default;
        }

        private void dataMonhoc_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataMonhoc.RowCount; i++)
                dataMonhoc.Rows[i].Cells[0].Value = i + 1;
        }
    }
}
