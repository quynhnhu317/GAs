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
    public partial class uChinh : MetroFramework.Controls.MetroUserControl
    {
        public uChinh()
        {
            InitializeComponent();
        }

        private void uChinh_Load(object sender, EventArgs e)
        {

        }

        //Khi click vào mtPhong thì sẽ dock uPhong vào mpTKB của fMain, set MetroBack = true để có thể quay lại
        private void mtPhong_Click(object sender, EventArgs e)
        {

            uPhong uc = new uPhong();
            uc.Dock = DockStyle.Fill;
            fMain.Instance.MetroContainer.Controls.Add(uc);
            //Đưa uPhong lên phía trước 
            fMain.Instance.MetroContainer.Controls["uPhong"].BringToFront();
            //hiển thị nút back
            fMain.Instance.MetroBack.Visible = true;
        }

        private void mtMon_Click(object sender, EventArgs e)
        {

            uMon uc = new uMon();
            uc.Dock = DockStyle.Fill;
            fMain.Instance.MetroContainer.Controls.Add(uc);
            fMain.Instance.MetroContainer.Controls["uMon"].BringToFront();
            fMain.Instance.MetroBack.Visible = true;
        }

        private void mtGiaovien_Click(object sender, EventArgs e)
        {

            uGiaovien uc = new uGiaovien();
            uc.Dock = DockStyle.Fill;
            fMain.Instance.MetroContainer.Controls.Add(uc);
            fMain.Instance.MetroContainer.Controls["uGiaovien"].BringToFront();
            fMain.Instance.MetroBack.Visible = true;
        }

        private void mtLop_Click(object sender, EventArgs e)
        {

            uLop uc = new uLop();
            uc.Dock = DockStyle.Fill;
            fMain.Instance.MetroContainer.Controls.Add(uc);
            fMain.Instance.MetroContainer.Controls["uLop"].BringToFront();
            fMain.Instance.MetroBack.Visible = true;
        }

        //Khi click vào mtPhanLich thì show frmMain(trang phân lịch) lên
        private void mtPhanlich_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.ShowDialog();
        }

        private void mtQLyNguoiDung_Click(object sender, EventArgs e)
        {
            uNguoidung uc = new uNguoidung();
            uc.Dock = DockStyle.Fill;
            fMain.Instance.MetroContainer.Controls.Add(uc);
            fMain.Instance.MetroContainer.Controls["uNguoidung"].BringToFront();
            fMain.Instance.MetroBack.Visible = true;
        }

        private void mtTacgia_Click(object sender, EventArgs e)
        {
            fTacgia frm = new fTacgia();
            frm.ShowDialog();
        }

        private void mtHDSD_Click(object sender, EventArgs e)
        {
            fHDSD frm = new fHDSD();
            frm.ShowDialog();
        }
    }
}
