using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKB_THCS
{
    public partial class fLop : MetroFramework.Forms.MetroForm
    {
        public fLop(LopHoc obj)
        {
            InitializeComponent();
            bindingSourceLop.DataSource = obj;
        }


        public LopHoc Capnhatlophoc { get { return bindingSourceLop.Current as LopHoc; } }
        private void fLop_Load(object sender, EventArgs e)
        {
            //thiết lập giá trị cho các combobox
            cbxGvcn.DisplayMember = "TenGV";
            cbxGvcn.ValueMember = "IDGV";
            cbxPhong.DisplayMember = "TenPH";
            cbxPhong.ValueMember = "IDPH";
            using (DbEntities db = new DbEntities())
            {
                //đổ dữu liệu từ dataSource ra cbx GV và MonHoc
                cbxGvcn.DataSource = db.GiaoViens.ToList();
                cbxPhong.DataSource = db.PhongHocs.ToList();
            }
        }

        //kiểm tra thông tin nhập và lưu dữ liệu vào bindingSource
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra thông tin nhập
            if (txtTenlop.Text.Trim() == "" || cbxGvcn.SelectedIndex == -1 || cbxKhoihoc.SelectedIndex == -1 || txtSiso.Text.Trim() == "" || cbxPhong.SelectedIndex == -1 || cbxBuoi.SelectedIndex == -1 || txtNamhoc.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin cho lớp học!!!!");
                return;
            }
            bindingSourceLop.EndEdit();
            DialogResult = DialogResult.OK;
            MessageBox.Show("Bạn đã cập nhật lớp " + txtTenlop.Text + " thành công");
        }
    }
}
