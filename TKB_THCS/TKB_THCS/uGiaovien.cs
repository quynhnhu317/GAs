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
    public partial class uGiaovien : MetroFramework.Controls.MetroUserControl
    {
        public uGiaovien()
        {
            InitializeComponent();
        }

        DbEntities db;

        private void uGiaovien_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
            giaoVienBindingSource.DataSource = db.GiaoViens.ToList();
            monHocBindingSource.DataSource = db.MonHocs.ToList();
            
        }

        private async void mtThem_Click(object sender, EventArgs e)
        {
            using (fGiaovien frm = new fGiaovien(new GiaoVien()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        giaoVienBindingSource.Add(frm.Capnhatgiaovien);
                        db.GiaoViens.Add(frm.Capnhatgiaovien);
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
            GiaoVien obj = giaoVienBindingSource.Current as GiaoVien;
            if (obj != null)
            {
                using (fGiaovien frm = new fGiaovien(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            giaoVienBindingSource.EndEdit();
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
                int rows = dataGV.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataGV.Rows[i].Selected)
                    {
                        db.GiaoViens.Remove(dataGV.Rows[i].DataBoundItem as GiaoVien);
                        giaoVienBindingSource.RemoveAt(dataGV.Rows[i].Index);
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
                    giaoVienBindingSource.EndEdit();
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
            monHocBindingSource.DataSource = db.MonHocs.ToList();
            Cursor.Current = Cursors.Default;
        }

        private void dataGV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataGV.RowCount; i++)
                dataGV.Rows[i].Cells[0].Value = i + 1;
        }
    }
}
