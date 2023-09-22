using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TKB_THCS.AppCode;
using TKB_THCS;



namespace TKB_THCS
{
    public partial class frmPhanLich : MetroFramework.Forms.MetroForm
    {
        TKB_THCS.AppCode.NhiemSacThe nst;
        DataTable dtTheHe;
        TKB_THCS.AppCode.DataBase db = new TKB_THCS.AppCode.DataBase();
        int sec = 0;
        bool Running = false;
      
        //hàm khởi tạo
        public frmPhanLich()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //Loại bỏ nút điều khiển chính là các nút max, min, close phía trên phải của form.
            this.ControlBox = false;
            // Thiết lập trạng thái của Form là hiển thị tối đa (maximized)
            this.WindowState = FormWindowState.Maximized;
            //Đưa Form này lên trên cùng của tất cả các cửa sổ khác đang mở trong ứng dụng
            this.BringToFront();
        }

        //được kích hoạt khi form được tải lên lần đầu tiên
        private void uLapTKB_Load(object sender, EventArgs e)
        {
            //Tạo mới một DtTable
            dtTheHe = new DataTable();
            //thêm cột TheHe vào table dtTheHe với kiểu dữ liệu Integer
            dtTheHe.Columns.Add("TheHe", System.Type.GetType("System.Int32"));
            dtTheHe.Columns.Add("SoTietHopLe", System.Type.GetType("System.Int32"));
            dtTheHe.Columns.Add("SoTietViPham", System.Type.GetType("System.Int32"));
            dtTheHe.Columns.Add("DoThichNghi", System.Type.GetType("System.String"));
            //gán datatable dtthehe vào datagridview1
            dataGridView1.DataSource = dtTheHe;
            //đặt tiêu đề cho cột thehe trong datagridview1 là Thế hệ
            dataGridView1.Columns["TheHe"].HeaderText = "Thế hệ";
            dataGridView1.Columns["SoTietHopLe"].HeaderText = "Số tiết hợp lệ";
            dataGridView1.Columns["SoTietViPham"].HeaderText = "Số tiết v.phạm";
            dataGridView1.Columns["DoThichNghi"].HeaderText = "Hệ số Th.Nghi";
            //Đặt độ rộng cho cột thế hệ trong dtgridView là 50
            dataGridView1.Columns["TheHe"].Width = 50;
            dataGridView1.Columns["SoTietHopLe"].Width = 60;
            dataGridView1.Columns["SoTietViPham"].Width = 60;
            dataGridView1.Columns["DoThichNghi"].Width = 50;
            //gọi hàm loadNST.
            LoadNST();
        }

        //hàm thêm một cột mới vào biểu đồ và thêm một hàng mới vào bảng dữ liệu
        private void AddChartColumn()
        {
            //Lấy ra giá trị HeSoThichNghi của nst * 100 
            float dothichnghi = nst.HeSoThichNghi * 100;

            //Lấy ra giá trị của biến nst.thehe và lưu vào biến thehe
            int thehe = nst.TheHe;

            //Tạo biến DataPoint với tham số truyền vào là thehe và dothichnghi.
            DataPoint col = new DataPoint(thehe, dothichnghi);

            //thêm đối tượng DataPoint mới vào danh sách các điểm của loạt dữ liệu đầu tiên trong biểu đồ
            chart1.Series[0].Points.Add(col);

            //tạo một hàng mới trong bảng dữ liệu dtTheHe
            DataRow row = dtTheHe.NewRow();
            // lưu giá trị số thế hệ vào cột TheHe của hàng mới vừa tạo
            row["TheHe"] = thehe;
            //chuyển độ thích nghi thành chuỗi có độ chính xác 2 số thập phân
            //và lưu vào cột DoThichNghi của hàng mới vừa tạo
            row["DoThichNghi"] = dothichnghi.ToString("0.00");
            row["SoTietHopLe"] = nst.TongTietHopLe;
            row["SoTietViPham"] = nst.TongTietViPham;
            //thêm hàng mới vào bảng dữ liệu dtTheHe
            dtTheHe.Rows.Add(row);
        }

        //hàm scroll đến hàng cuối cùng và đánh dấu ô trong cột cuối cùng của dataGridView
        private void ForcusLastRow()
        {
            //Lấy ra chỉ số của hàng cuối cùng trong dataGridView1.
            int nRowIndex = dataGridView1.Rows.Count - 1;
            //gán chỉ số của cột cuối cùng vào nColumnIndex(bắt đầu từ 0)
            //int nColumnIndex = 3;

            //đánh dấu hàng cuối cùng trong dataGridView1.
            dataGridView1.Rows[nRowIndex].Selected = true;
            //đánh dấu ô tại cột cuối cùng và hàng cuối cùng trong dataGridView1.
            //dataGridView1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

            //Trong trường hợp có nhiều hàng thì nó sẽ tự cuộn xuống hàng cuối
            dataGridView1.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        private void LoadNST()
        {
            //Tạo đối tượng nst
            nst = new TKB_THCS.AppCode.NhiemSacThe();

            //gán đối tượng "nst" cho biến "nst" trong lớp "Program" để có thể truy
            //cập đến đối tượng này từ nhiều form khác nhau trong chương trình
            Program.nst = nst;

            //Tạo dtTable mới để chứa dữ liệu danh sách lớp học.
            DataTable dsLop = new DataTable();
            DataTable dsPhong = new DataTable();
            DataTable dsGV = new DataTable();
            DataTable dsMon = new DataTable();

            //"Select LopHoc.*, GiaoVien.TenGV From LopHoc Left Join GiaoVien On LopHoc.IDGV = GiaoVien.IDGV"
            //Lấy ds lớp học từ bảng LopHoc, nếu ko có đưa ra thông báo.
            if (!db.GetData(dsLop, "Select * From LopHoc"))
                MessageBox.Show("Không có dữ liệu Lớp học");

            //Lấy ds phòng học
            else if (!db.GetData(dsPhong, "Select * From PhongHoc"))
                MessageBox.Show("Không có dữ liệu Phòng học");

            //Lấy ds Giáo Viên
            else if (!db.GetData(dsGV, "Select GiaoVien.*, MonHoc.Ten As TenMon From GiaoVien Left Join MonHoc On GiaoVien.IDMon = MonHoc.IDMon"))
                MessageBox.Show("Không có dữ liệu Giáo viên");

            //Lấy ds môn học (chỉ lấy môn chính)   Where Phu = 0  Or Phu IS NULL
            else if (!db.GetData(dsMon, "Select * From MonHoc"))
                MessageBox.Show("Không có dữ liệu Môn học");
            else
            {
                // xử lý danh sách lớp học và lưu vào nst thông qua phương thức ListLopHoc
                nst.ListLopHoc(dsLop);
                nst.ListPhongHoc(dsPhong);
                nst.ListGiaoVien(dsGV);
                nst.ListMonHoc(dsMon);

                nst.PhanLichMonHoc();
                nst.PhanGiaoVien();
                nst.TinhDoThichNghi();
                //thêm một cột mới vào biểu đồ và một hàng mới vào bảng dữ liệu thông qua phương thức AddChartColumn
                AddChartColumn();
            }
        }

        private void btnTienHoa_Click(object sender, EventArgs e)
        {
            nst.TienHoa();
            //thêm 1 cột vào biểu đồ và 1 hàng vào dtGridView1
            AddChartColumn();
            ForcusLastRow();
        }

        //thực hiện tiến hóa 100 thế hệ
        private void btnTienHoa100_Click(object sender, System.EventArgs e)
        {
            //tạm thời vô hiệu hóa các nút để tránh xung đột
            btnTienHoa.Enabled = false;
            btnTienHoa100.Enabled = false;
            btnTienHoaAll.Enabled = false;
            for (int i = 0; i < 100; i++)
            {
                nst.TienHoa();
                AddChartColumn();
                // cho phép ứng dụng thực hiện các sự kiện khác đang chờ đợi xử lý lên đầu của hàng đợi,
                // cho phép người dùng tương tác với ứng dụng trong khi tiến hóa đang diễn ra
                Application.DoEvents();
            }
            btnTienHoa.Enabled = true;
            btnTienHoa100.Enabled = true;
            btnTienHoaAll.Enabled = true;
            ForcusLastRow();
        }

        //Tiến hóa hết
        private void btnTienHoaAll_Click(object sender, System.EventArgs e)
        {
            btnTienHoa.Enabled = false;
            btnTienHoa100.Enabled = false;
            btnTienHoaAll.Enabled = false;
            //để người dùng có thể dừng tiến hóa
            btnStop.Enabled = true;

            //hiển thị thanh tiến trình
            progressBar1.Visible = true;
            //thiết lập kiểu tiến trình là Marquee để hiển thị liên tục.
            progressBar1.Style = ProgressBarStyle.Marquee;
            //giá trị max = 100
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 1;
            //Thiết lập giá trị hiện tại là 100 để bắt đầu chạy
            progressBar1.Value = 100;
            //thiết lập tốc độ chạy
            progressBar1.MarqueeAnimationSpeed = 100;
            //thiết lập giá trị đếm ngược
            sec = 0;
            //người dùng có thể dừng tiến hóa.
            Running = true;
            //cho phép timer bắt đầu đếm ngược
            timer1.Enabled = true;

            //tiến hóa đến khi HeSoThichNghi = 1 hoặc người dùng ấn stop
            do
            {
                nst.TienHoa();
                Application.DoEvents();
            } while (nst.HeSoThichNghi != 1 && Running);
            Running = false;
            timer1.Enabled = false;
            AddChartColumn();
            ForcusLastRow();
            //thiết lập tốc độ chạy của thanh tiến trình Marquee là 0 để dừng
            progressBar1.MarqueeAnimationSpeed = 0;
            //ẩn thanh tiến trình
            progressBar1.Visible = false;

            //thiết lập lại các nút
            btnTienHoa.Enabled = true;
            btnTienHoa100.Enabled = true;
            btnTienHoaAll.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStop_Click(object sender, System.EventArgs e)
        {
            Running = false;
        }

        //hàm đếm ngược thời gian khi người dùng thực hiện tiến hóa cho tất cả các thế hệ
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            sec += 1;
            //sec/60 tính số phút sec%60 là số giây (thêm 0 vào số giấy nếu chỉ có 1 số).
            lblTime.Text = (sec / 60).ToString() + ":" + (sec % 60).ToString("00");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        //khi ấn Lập TKB thì sẽ chuyển hướng đến trang TKB
        private void btnTKB_Click(object sender, EventArgs e)
        {
            frmMain fMain = (frmMain)this.MdiParent;
            if (fMain != null)
                fMain.ShowTKB();
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
