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
    public partial class fGiaovien : MetroFramework.Forms.MetroForm
    {
        public fGiaovien(GiaoVien obj)
        {
            InitializeComponent();
            //binding dữ liệu
            bindingSourceGiaovien.DataSource = obj;
            //nếu dduowcjj check thì hiện là Nam
            if (ckbNam.CheckState == CheckState.Checked)
                ckbNam.Text = "Nam";
            else if (ckbNam.CheckState == CheckState.Unchecked)
                ckbNam.Text = "Nữ";
            else
                ckbNam.Text = "???";
        }

        public GiaoVien Capnhatgiaovien { get { return bindingSourceGiaovien.Current as GiaoVien; } }

        //gọi khi form được load lên
        private void fGiaovien_Load(object sender, EventArgs e)
        {
            //thiết lập giá trị truyền vào các thuộc tính cỉa cbx
            cbxChuyenmon.DisplayMember = "Ten";
            cbxChuyenmon.ValueMember = "IDMon";
            using (DbEntities db = new DbEntities())
            {
                //đổ dữ liệu tên các môn học ra combobox
                cbxChuyenmon.DataSource = db.MonHocs.ToList();

            }
        }

        //sự kienj khi click vào button Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {

            //Kiểm tra thông tin nhập
            if (txtHoten.Text.Trim() == "" || txtNgaysinh.Text.Trim() == "" || txtDT.Text.Trim() == "" || txtDC.Text.Trim() == "" || txtTiettuan.Text.Trim() == "" || cbxChuyenmon.SelectedIndex == -1 || cbKhoi.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin cho giáo viên!!!!");
                return;
            }
            //kết thúc việc chỉnh sửa dữ liệu và lưu các thay đổi vào nguồn dữ liệu
            bindingSourceGiaovien.EndEdit();
            //kết thúc việc chỉnh sửa và đóng form lại
            DialogResult = DialogResult.OK;
            MessageBox.Show("Bạn đã cập nhật giáo viên " + txtHoten.Text + " thành công");
        }

        //kích hoạt khi trạng thái cỉa checkBox thay đổi.
        private void ckbNam_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbNam.CheckState == CheckState.Checked)
                ckbNam.Text = "Nam";
            else if (ckbNam.CheckState == CheckState.Unchecked)
                ckbNam.Text = "Nữ";
            else
                ckbNam.Text = "???";
        }

    }
}
