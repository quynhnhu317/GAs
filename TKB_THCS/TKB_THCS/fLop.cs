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
        public fLop( LopHoc obj)
        {
            InitializeComponent();
            bindingSourceLop.DataSource = obj;
        }


        public LopHoc Capnhatlophoc { get { return bindingSourceLop.Current as LopHoc; } }
        private void fLop_Load(object sender, EventArgs e)
        {
            cbxGvcn.DisplayMember = "TenGV";
            cbxGvcn.ValueMember = "IDGV";
            cbxPhong.DisplayMember = "TenPH";
            cbxPhong.ValueMember = "IDPH";
            using (DbEntities db = new DbEntities())
            {
                cbxGvcn.DataSource = db.GiaoViens.ToList();
                cbxPhong.DataSource = db.PhongHocs.ToList();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bindingSourceLop.EndEdit();
            DialogResult = DialogResult.OK;
        }
    }
}
