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
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {

        frmPhanLich fPhanLich;
        frmTKBGV fTKBGV;
        frmTKB fTKB;
        TKB_THCS.AppCode.DataBase cn = new TKB_THCS.AppCode.DataBase();

        public frmMain()
        {
            InitializeComponent();
        }

        public void ShowTKB()
        {
            if (fTKB == null || fTKB.IsDisposed) fTKB = new frmTKB(Program.nst);
            else fTKB.NST = Program.nst;
            ShowFormChild(fTKB);
        }
        public void ShowTienhoa()
        {
            if (fPhanLich == null || fPhanLich.IsDisposed) fPhanLich = new frmPhanLich();
            ShowFormChild(fPhanLich);
        }
        public void ShowTKBGV()
        {
            if (fTKBGV == null || fTKBGV.IsDisposed) fTKBGV = new frmTKBGV(Program.nst);
            else fTKBGV.NST = Program.nst;
            ShowFormChild(fTKBGV);
        }

        private void ShowFormChild(Form frm)
        {
            //Thiết lập form hiện tại là form cha
            frm.MdiParent = this;
            //hiển thị form con lên
            frm.Show();
            frm.BringToFront();
            frm.Size = this.Size;
            this.Width += 1;
            this.Width += -1;
            //đảm bảo tab hiển thị đúng vị trí
            mdiTabStrip1.Refresh();
        }

        //nút tại đây
        private void rbtnPhanLich_Click(object sender, EventArgs e)
        {

            if (fPhanLich == null || fPhanLich.IsDisposed) fPhanLich = new frmPhanLich();
            ShowFormChild(fPhanLich);

        }

        //xem tkb giáo viên
        private void btnLichGV_Click(object sender, EventArgs e)
        {
            if (fTKBGV == null || fTKBGV.IsDisposed) fTKBGV = new frmTKBGV(Program.nst);
            else fTKBGV.NST = Program.nst;
            ShowFormChild(fTKBGV);
        }

        //xem thời khóa biểu
        private void btnTKB_Click(object sender, EventArgs e)
        {
            if (fTKB == null || fTKB.IsDisposed) fTKB = new frmTKB(Program.nst);
            else fTKB.NST = Program.nst;
            ShowFormChild(fTKB);
        }

    }
}
