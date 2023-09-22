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

        //đối tượng để thao tác với CSDL
        DbEntities db;

        private void uGiaovien_Load(object sender, EventArgs e)
        {
            db = new DbEntities();
            //lấy dữ liệu từ bảng giáo viên đổ lên dataGridView
            giaoVienBindingSource.DataSource = db.GiaoViens.ToList();
            //lấy dữ liệu từ bảng môn học đổ vào cbxMonHoc
            monHocBindingSource.DataSource = db.MonHocs.ToList();

        }

        //sự kiện khi click mtThem
        private async void mtThem_Click(object sender, EventArgs e)
        {
            using (fGiaovien frm = new fGiaovien(new GiaoVien()))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //thêm dữ liệu vào dataGrid
                        giaoVienBindingSource.Add(frm.Capnhatgiaovien);
                        //lưu trữ vào cơ sở dữ liệu
                        db.GiaoViens.Add(frm.Capnhatgiaovien);
                        //lưu các thay đổi vào csdl
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
            //lấy ra giáo viên được click trên grid
            GiaoVien obj = giaoVienBindingSource.Current as GiaoVien;
            //nếu lấy được
            if (obj != null)
            {
                using (fGiaovien frm = new fGiaovien(obj))
                {
                    //khi người dùng ấn lưu
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            //kết thúc việc chỉnh sửa dữ liệu và lưu các thay đổi vào nguồn dữ liệu
                            giaoVienBindingSource.EndEdit();
                            //lưu thay đổi vào csdl
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

        //sự kiện khi ấn Xóa
        private void mtXoa_Click(object sender, EventArgs e)
        {
            //nếu người dùng ấn yes
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //lấy ra số hàng của dataGridView
                int rows = dataGV.RowCount;
                for (int i = rows - 1; i >= 0; i--)
                {
                    //kiểm tra xem có phải hàng người dùng chọn ko
                    if (dataGV.Rows[i].Selected)
                    {
                        db.GiaoViens.Remove(dataGV.Rows[i].DataBoundItem as GiaoVien);
                        // xóa dòng hiển thị trên dataGridView và cập nhật lại danh sách gv trong giaoVienBindingSource
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
                    //kết thúc việc chỉnh sửa dữ liệu và lưu các thay đổi vào nguồn dữ liệu
                    giaoVienBindingSource.EndEdit();
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //đặt lại dữ liệu hiển thị trên form về các giá trị ban đầu từ cơ sở dữ liệu
        private void mtHuy_Click(object sender, EventArgs e)
        {
            //khi ấn hủy con trỏ chuột sẽ trở thành hình quay quay
            Cursor.Current = Cursors.WaitCursor;
            //hiển thị lại danh sách giáo viên và môn học
            giaoVienBindingSource.DataSource = db.GiaoViens.ToList();
            monHocBindingSource.DataSource = db.MonHocs.ToList();
            //con trỏ chuột trở về bình thường
            Cursor.Current = Cursors.Default;
        }

        //vẽ dữ liệu trên từng dòng cột stt
        private void dataGV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //stt
            for (int i = 0; i < dataGV.RowCount; i++)
                dataGV.Rows[i].Cells[0].Value = i + 1;
        }

    }
}
