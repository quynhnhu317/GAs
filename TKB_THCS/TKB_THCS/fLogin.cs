using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKB_THCS
{
    public partial class fLogin : MetroFramework.Forms.MetroForm
    {
        public fLogin()
        {
              

                InitializeComponent();

        }

        public void Splash()
        {
            Application.Run(new fLoading());
        }



        private void fLogin_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            // Loading data
            Thread.Sleep(8000);
            //Complete
            t.Abort();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
                        
            if (string.IsNullOrEmpty(txtTendn.Text) || string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Vui lòng nhập tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTendn.Focus();
                txtMatkhau.Focus();
                return;
            }
            try
            {
                using (DbUserEntities db = new DbUserEntities())
                {
                    var query = from u in db.QuyenTruyCaps
                                where u.TenDN == txtTendn.Text && u.MatKhau == txtMatkhau.Text
                                select u;

                    if (query.SingleOrDefault() != null)
                    {
                        this.Hide();
                        fMain frm = new fMain();
                        frm.Show();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Người dùng không tồn tại vui lòng đăng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtTendn.Text = "";
                    this.txtMatkhau.Text = "";
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMatkhau.Text = "";
            txtTendn.Text = "";
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
