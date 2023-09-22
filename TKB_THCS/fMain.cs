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
    public partial class fMain : MetroFramework.Forms.MetroForm
    {


        bool _logout;
        static fMain _instance;

        public fMain()
        {
            InitializeComponent();
        }

        public static fMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new fMain();
                return _instance;
            }
        }
        //get và set value cho metroPanel chứa giao diện người dùng
        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return mpTKB; }
            set { mpTKB = value; }
        }

        //get và set value cho mũi tên back
        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return mlback; }
            set { mlback = value; }
        }

        //Khi form mới được load thì sẽ dock uChinh vào trong mpTKB của fMain, set mlback = false
        private void fMain_Load(object sender, EventArgs e)
        {
            mlback.Visible = false;
            _instance = this;
            uChinh uc = new uChinh();
            uc.Dock = DockStyle.Fill;
            mpTKB.Controls.Add(uc);
        }

        //khi ấn mũi tên back thì sẽ quay về giao diện chính và set lại giá trị cho mlback
        private void mlback_Click(object sender, EventArgs e)
        {
            mpTKB.Controls["uChinh"].BringToFront();
            mlback.Visible = false;
        }

        //khi ấn logout thì sẽ thoát ra về lại form đăng nhập
        private void linkLogout_Click(object sender, EventArgs e)
        {
            _logout = true;
            //ẩn form hiện tại đi
            this.Hide();
            //show lên form login
            fLogin frm = new fLogin();
            frm.Show();
        }

        //đóng chương trình
        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
