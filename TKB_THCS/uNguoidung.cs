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
    public partial class uNguoidung : MetroFramework.Controls.MetroUserControl
    {
        public uNguoidung()
        {
            InitializeComponent();
        }

        DbUserEntities db;
        private void uNguoidung_Load(object sender, EventArgs e)
        {
            db = new DbUserEntities();
            quyenTruyCapBindingSource.DataSource = db.QuyenTruyCaps.ToList();
        }

        private void dataNguoidung_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dataNguoidung.RowCount; i++)
                dataNguoidung.Rows[i].Cells[0].Value = i + 1;
        }

        private async void mtThem_Click(object sender, EventArgs e)
        {
            using (fNguoidung frm = new fNguoidung(new QuyenTruyCap()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        quyenTruyCapBindingSource.Add(frm.Capnhatnguoidung);
                        db.QuyenTruyCaps.Add(frm.Capnhatnguoidung);
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
            QuyenTruyCap obj = quyenTruyCapBindingSource.Current as QuyenTruyCap;
            if (obj != null)
            {
                using (fNguoidung frm = new fNguoidung(obj))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            quyenTruyCapBindingSource.EndEdit();
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
                int rows = dataNguoidung.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    if (dataNguoidung.Rows[i].Selected)
                    {
                        db.QuyenTruyCaps.Remove(dataNguoidung.Rows[i].DataBoundItem as QuyenTruyCap);
                        quyenTruyCapBindingSource.RemoveAt(dataNguoidung.Rows[i].Index);
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
                    quyenTruyCapBindingSource.EndEdit();
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
            quyenTruyCapBindingSource.DataSource = db.QuyenTruyCaps.ToList();
            Cursor.Current = Cursors.Default;
        }
    }
}
