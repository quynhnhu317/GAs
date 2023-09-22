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
    public partial class fNguoidung : MetroFramework.Forms.MetroForm
    {
        public fNguoidung(QuyenTruyCap obj)
        {
            InitializeComponent();
            bindingSourceNguoidung.DataSource = obj;
        }

        public QuyenTruyCap Capnhatnguoidung { get { return bindingSourceNguoidung.Current as QuyenTruyCap; } }

        private void fNguoidung_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTendn.Text.Trim() == "" || txtMk.Text.Trim() == "" || txtQuyen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin cho người dùng!!!!");
                return;
            }
            bindingSourceNguoidung.EndEdit();
            DialogResult = DialogResult.OK;
            MessageBox.Show("Bạn đã cập nhật người dùng " + txtTendn.Text + " thành công");
        }
    }
}
