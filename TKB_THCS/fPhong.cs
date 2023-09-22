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
    public partial class fPhong : MetroFramework.Forms.MetroForm
    {
        public fPhong(PhongHoc obj)
        {
            InitializeComponent();
            bindingSourcePhong.DataSource = obj;
        }


        public PhongHoc Capnhatphonghoc { get { return bindingSourcePhong.Current as PhongHoc; } }



        private void fPhong_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenphong.Text.Trim() == "" || txtSucchua.Text.Trim() == "" || txtVitri.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin cho phòng học!!!!");
                return;
            }
            bindingSourcePhong.EndEdit();
            DialogResult = DialogResult.OK;
            MessageBox.Show("Bạn đã cập nhật phòng " + txtTenphong.Text + " thành công");
        }
    }
}
