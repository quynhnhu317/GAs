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
            //lấy dữ liệu từ csdl sau đó đổ lên bindingSource tương ứng
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
                        //add dtGV
                        lopHocBindingSource.Add(frm.Capnhatlophoc);
                        //add csdl
                        db.LopHocs.Add(frm.Capnhatlophoc);
                        //lưu các thay đổi
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
                //lấy ra số hàng hiện có của dtGridView
                int rows = dataLophoc.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    //kiểm tra hàng người dùng chọn
                    if (dataLophoc.Rows[i].Selected)
                    {
                        db.LopHocs.Remove(dataLophoc.Rows[i].DataBoundItem as LopHoc);
                        //xóa trên giao diện và cập nhật lại danh sách
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

        //KHi ấn hủy thì sẽ load lại dữ liệu khi người dùng sửa đổi nhưng chưa lưu vào csdl
        private void mtHuy_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            giaoVienBindingSource.DataSource = db.GiaoViens.ToList();
            lopHocBindingSource.DataSource = db.LopHocs.ToList();
            phongHocBindingSource.DataSource = db.PhongHocs.ToList();
            Cursor.Current = Cursors.Default;
        }

        //đánh số cho cột STT
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
