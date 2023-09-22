using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TKB_THCS.AppCode
{
    public class AppConstant
    {
        //buổi
        public int BuoiSang { get { return 1; } }
        public int BuoiChieu { get { return 2; } }
        //Thứ
        public int Thu2 { get { return 0; } }
        public int Thu3 { get { return 1; } }
        public int Thu4 { get { return 2; } }
        public int Thu5 { get { return 3; } }
        public int Thu6 { get { return 4; } }
        public int Thu7 { get { return 5; } }
        public int CN { get { return 6; } }
        //Tiết
        public int Tiet1 { get { return 0; } }
        public int Tiet2 { get { return 1; } }
        public int Tiet3 { get { return 2; } }
        public int Tiet4 { get { return 3; } }
        public int Tiet5 { get { return 4; } }
    }

    public sealed class LoaiTiet
    {
        public static readonly LoaiTiet BinhThuong = new LoaiTiet(1);
        public static readonly LoaiTiet ChaoCo = new LoaiTiet(2);
        public static readonly LoaiTiet SinhHoat = new LoaiTiet(3);
        public static readonly LoaiTiet KhongHoc = new LoaiTiet(5);

        private LoaiTiet(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }
    }

    public sealed class LoaiViPham
    {
        public static readonly LoaiViPham KhongViPham = new LoaiViPham(1);
        public static readonly LoaiViPham QuaSoTiet = new LoaiViPham(2);
        public static readonly LoaiViPham QuaSoBuoi = new LoaiViPham(3);
        public static readonly LoaiViPham ThieuSoBuoi = new LoaiViPham(4);
        public static readonly LoaiViPham TrungLichGiaoVien = new LoaiViPham(5);
        public static readonly LoaiViPham ThieuGiaoVien = new LoaiViPham(6);
        public static readonly LoaiViPham DangXuLy = new LoaiViPham(7);

        private LoaiViPham(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }
    }


    public class Tiet : ICloneable
    {
        //tiết thứ mấy
        public int Index { get; set; }
        public int Thu { get; set; }
        public int IDMon { get; set; }
        public int IDGV { get; set; }
        public string TenGV { get; set; }
        public string TenMon { get; set; }
        //Loại tiết gì (bình thường or chào cờ)
        public LoaiTiet Loai { get; set; }
        public LoaiViPham LoaiViPham { get; set; }
        public bool TietKep { get; set; }
        public bool TietPhu { get; set; }
        public Tiet(int index, int thu)
        {
            Loai = LoaiTiet.BinhThuong;
            LoaiViPham = LoaiViPham.KhongViPham;
            Thu = thu;
            Index = index;
            IDMon = 0;
            IDGV = 0;
        }

        //hoán đổi nội dung 2 tiết
        public void SwapNoiDungTiet(Tiet tietB)
        {
            //lưu tạm thời nội dung của tiết hiện tại vào đối tượng tmp
            Tiet tmp = new Tiet(0, 0);
            tmp.IDMon = this.IDMon;
            tmp.TenMon = this.TenMon;
            tmp.IDGV = this.IDGV;
            tmp.TenGV = this.TenGV;
            tmp.TietKep = this.TietKep;
            tmp.TietPhu = this.TietPhu;

            //gán nội dung của tiết được truyền vào tiết hiện tại
            this.IDMon = tietB.IDMon;
            this.TenMon = tietB.TenMon;
            this.IDGV = tietB.IDGV;
            this.TenGV = tietB.TenGV;
            this.TietKep = tietB.TietKep;
            this.TietPhu = tietB.TietPhu;

            tietB.IDMon = tmp.IDMon;
            tietB.TenMon = tmp.TenMon;
            tietB.IDGV = tmp.IDGV;
            tietB.TenGV = tmp.TenGV;
            tietB.TietKep = tmp.TietKep;
            tietB.TietPhu = tmp.TietPhu;
        }

        //trả về một bản sao của đối tượng hiện tại 
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Thu : ICloneable
    {
        //lưu trữ thứ mấy trong tuần
        public int Index { get; set; }
        private const int tongTiet = 5;
        public Tiet[] Tiet = new Tiet[tongTiet];

        //Constructor
        public Thu(int index)
        {
            Index = index;
            for (int i = 0; i < tongTiet; i++)
                Tiet[i] = new Tiet(i, Index);
        }

        //trả về một bản sao của đối tượng hiện tại 
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class LopHoc : ICloneable
    {
        public int IDLop { get; set; }
        public int IDGV { get; set; }
        public int IDPH { get; set; }
        public string TenLop { get; set; }
        public string TenGVCN { get; set; }
        public string TenPhongHoc { get; set; }
        public int Nam { get; set; }
        public int Khoi { get; set; }
        public int SiSo { get; set; }
        public int BuoiHoc { get; set; }

        public int TongTiet { get; set; }
        public int TongTietHopLe { get; set; }
        public int TongTietViPham { get; set; }

        //Giáo viên dạy những môn học của lớp, được phân ngẫu nhiên ở NST
        public DanhSachGVDayMH DSDayHoc { get; set; }

        //t2 den t7
        private const int tongThu = 6;
        public Thu[] Thu = new Thu[tongThu];

        //Constructor
        public LopHoc()
        {
            //lưu trữ danh sách các giáo viên dạy môn học cũng như các thông tin
            //liên quan đến giảng dạy của họ trong một lớp học
            DSDayHoc = new DanhSachGVDayMH();
            //tạo các đối tượng Thu cho mỗi ngày học trong tuần
            for (int i = 0; i < tongThu; i++)
                Thu[i] = new Thu(i);
            //khởi tạo các thuộc tính trong LopHoc
            IDLop = 0;
            IDGV = 0;
            IDPH = 0;
            TenLop = "";
            Nam = 0;
            Khoi = 0;
            SiSo = 0;
            BuoiHoc = 0;
        }

        // cập nhật thông tin cho giáo viên dạy môn học tương ứng được cập nhật cho tất cả
        // các tiết học trong lớp học có mã số môn học tương ứng.
        public void UpdateGVDayMonHoc(int IDMon, GiaoVien gv)
        {
            foreach (Thu thu in Thu)
                foreach (Tiet tiet in thu.Tiet)
                {
                    //Nếu đối tượng Tiet có thuộc tính IDMon bằng với mã số môn học đã truyền vào
                    //từ tham số của phương thức, các thuộc tính IDGV và TenGV của đối tượng tiet sẽ được cập nhật
                    //bằng mã số và tên của giáo viên từ đối tượng gv đã truyền vào.
                    if (tiet.IDMon == IDMon)
                    {
                        tiet.IDGV = gv.IDGV;
                        tiet.TenGV = gv.TenGV;
                    }
                }
        }

        //kiểm tra xem một môn học trong 1 ngày học của lớp học có vi phạm quy định về số tiết học không (true là có vp).
        public bool ViPhamSoTiet(MonHoc mon)
        {
            bool res = false;
            //duyệt qua từng thứ trong tuần
            foreach (Thu thu in Thu)
            {
                int slTietTrongNgay = 0;
                bool viPham = false;
                //duyệt từng tiết trong thứ
                foreach (Tiet tiet in thu.Tiet)
                {
                    //nếu trùng với môn đang xét thì tăng lên
                    if (tiet.IDMon == mon.IDMon)
                        slTietTrongNgay++;
                }

                if (slTietTrongNgay > 1)
                {
                    //ko phải tiết kép và sl tiết > 1
                    if (!mon.TietKep)
                        viPham = true;
                    //đúng là tiết kép nhưng sl > 2
                    else if (slTietTrongNgay > 2)
                        viPham = true;
                }

                //nếu vi phạm thì lưu lại vị trí tiết vi phạm 
                if (viPham)
                {
                    res = true;
                    foreach (Tiet tiet in thu.Tiet)
                        if (tiet.IDMon == mon.IDMon)
                            //gán cho các tiết của môn trong ngày đó này loại vp quá số tiết
                            tiet.LoaiViPham = LoaiViPham.QuaSoTiet;
                }
            }
            return res;
        }

        //kiểm tra xem việc dạy một môn trong lớp học có vi phạm quy định về số buổi học không
        public bool ViPhamSoBuoi(MonHoc mon)
        {
            int tongBuoi = 0;
            foreach (Thu thu in Thu)
            {
                foreach (Tiet tiet in thu.Tiet)
                    if (tiet.IDMon == mon.IDMon)
                    {
                        tongBuoi++;
                        break;
                    }
            }

            //xếp loại loại vp
            LoaiViPham vp = LoaiViPham.KhongViPham;
            if (this.Khoi == 6 && tongBuoi > mon.SoBuoiK6) vp = LoaiViPham.QuaSoBuoi;
            else if (this.Khoi == 6 && tongBuoi < mon.SoBuoiK6) vp = LoaiViPham.ThieuSoBuoi;
            else if (this.Khoi == 7 && tongBuoi > mon.SoBuoiK7) vp = LoaiViPham.QuaSoBuoi;
            else if (this.Khoi == 7 && tongBuoi < mon.SoBuoiK7) vp = LoaiViPham.ThieuSoBuoi;
            else if (this.Khoi == 8 && tongBuoi > mon.SoBuoiK8) vp = LoaiViPham.QuaSoBuoi;
            else if (this.Khoi == 8 && tongBuoi < mon.SoBuoiK8) vp = LoaiViPham.ThieuSoBuoi;
            else if (this.Khoi == 9 && tongBuoi > mon.SoBuoiK9) vp = LoaiViPham.QuaSoBuoi;
            else if (this.Khoi == 9 && tongBuoi < mon.SoBuoiK9) vp = LoaiViPham.ThieuSoBuoi;

            //nếu vp thì gán cho các tiết của môn này    
            if (vp != LoaiViPham.KhongViPham)
                foreach (Thu thu in Thu)
                    foreach (Tiet tiet in thu.Tiet)
                        if (tiet.IDMon == mon.IDMon)
                            tiet.LoaiViPham = vp;

            //trả về true nếu vp != KhongVIPham
            return (vp != LoaiViPham.KhongViPham);
        }

        //Kiểm tra xem có bao nhiêu tiết vi phạm
        public void TinhSoTietViPham()
        {
            int viPham = 0;
            foreach (Thu thu in Thu)
                foreach (Tiet tiet in thu.Tiet)
                    //đếm số tiết vi phạm
                    if (tiet.LoaiViPham != LoaiViPham.KhongViPham)
                        viPham++;
            TongTietViPham = viPham;
            TongTietHopLe = TongTiet - TongTietViPham;
        }

        //Xử lý vi phạm quá số buổi học (Ghép tiết).
        public void GhepBuoi(Tiet tiet)
        {
            AppConstant cons = new AppConstant();
            ViTriNgauNhien rndVT = new ViTriNgauNhien();
            ViTriTietHoc vt;
            Tiet tmp = null, tietA = null, tietB = null;
            //Chọn một vị trí tiết học bất kỳ đủ điều kiện để ghép
            do
            {
                //random lấy một vị trí ngẫu nhiên
                vt = rndVT.GetNextViTri();
                //nếu ko chọn đc thì thoát
                if (vt == null) break;
                //nếu lấy được thì gán giá trị vào biến tmp
                tmp = Thu[vt.Thu].Tiet[vt.Tiet];
                //Kiểm tra xem tiết đó có là loại tiết thường và là cùng một môn nhưng khác tiết ko.
                if (tmp.Loai == LoaiTiet.BinhThuong)
                    if (tmp.IDMon == tiet.IDMon && tmp != tiet)
                    {
                        tietA = tmp;
                        break; //chọn một tiết bất kỳ cùng môn
                    }
            } while (true);

            //Chọn tiết khác cùng buổi để thay đổi vị trí
            if (tiet.Index == cons.Tiet1)
                tietB = Thu[tiet.Thu].Tiet[cons.Tiet2];
            else if (tiet.Index == cons.Tiet5)
                tietB = Thu[tiet.Thu].Tiet[cons.Tiet4];
            //kiểm tra vị trí sau tiết truyền vào có phải tiết bt ko (tránh tiết sh or tiết trống).
            else if (Thu[tiet.Thu].Tiet[tiet.Index + 1].Loai == LoaiTiet.BinhThuong)
                tietB = Thu[tiet.Thu].Tiet[tiet.Index + 1];
            //Kiểm tra vtri trước đó có bth ko
            else if (Thu[tiet.Thu].Tiet[tiet.Index - 1].Loai == LoaiTiet.BinhThuong)
                tietB = Thu[tiet.Thu].Tiet[tiet.Index - 1];

            ////hoán đổi nội dung 2 tiết (Môn, GV)
            if (tietA != null && tietB != null)
            {
                tietA.SwapNoiDungTiet(tietB);
                //set lại loại vp cho 2 môn
                tietA.LoaiViPham = LoaiViPham.DangXuLy;
                tietB.LoaiViPham = LoaiViPham.DangXuLy;
            }
        }

        //Xử lý vp thiếu số buổi học (TachTiet).
        public void TachBuoi(Tiet tiet)
        {
            AppConstant cons = new AppConstant();
            ViTriNgauNhien rndVT = new ViTriNgauNhien();
            ViTriTietHoc vt;
            Tiet tmp = null, tietA = null;

            //Chọn một vị trí tiết học bất kỳ đủ điều kiện để tách
            do
            {
                vt = rndVT.GetNextViTri();
                //ko chọn đc
                if (vt == null) break;
                tmp = Thu[vt.Thu].Tiet[vt.Tiet];
                //chọn một tiết bất kỳ là một tiết bình thường khác thứ, khác môn
                if (tmp.Loai == LoaiTiet.BinhThuong)
                    if (tmp.Thu != tiet.Thu && tmp.IDMon != tiet.IDMon)
                    {
                        tietA = tmp;
                        break;
                    }
            } while (true);


            if (tietA != null)//hoán đổi nội dung (Môn, GV)
            {
                tietA.SwapNoiDungTiet(tiet);
                tietA.LoaiViPham = LoaiViPham.DangXuLy;
                tiet.LoaiViPham = LoaiViPham.DangXuLy;
            }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    //tạo danh sách các lớp học
    public class DanhSachLopHoc
    {
        List<LopHoc> danhsach;
        //khai báo thuộc tính Count để trả về số lượng lớp học trong danh sách
        public int Count { get { return danhsach.Count; } }

        //phương thức khởi tạo không tham số
        public DanhSachLopHoc()
        {
            danhsach = new List<LopHoc>();
        }

        //phương thức để thêm một lớp học mới vào danh sách
        public void Add(LopHoc lop)
        {
            danhsach.Add(lop);
        }

        //lấy ra một lớp học từ danh sách với vitri là vị trí của lớp học trong danh sách.
        //Nếu danh sách không có lớp học, hoặc vitri lớn hơn hoặc bằng số lượng lớp học trong danh sách,
        //phương thức sẽ trả về `null`
        public LopHoc GetLopHoc(int vitri)
        {
            if (danhsach.Count > 0 && danhsach.Count > vitri)
                return danhsach[vitri];
            else
                return null;
        }

        //phương thức để lấy ra toàn bộ danh sách lớp học
        public List<LopHoc> GetDanhSach()
        {
            return danhsach;
        }
    }
    public class PhongHoc : ICloneable
    {
        public int IDPH { get; set; }
        public string TenPH { get; set; }
        public int SucChua { get; set; }
        public string ViTri { get; set; }
        //Hàm tạo
        public PhongHoc()
        {
            IDPH = 0;
            TenPH = "";
            SucChua = 0;
            ViTri = "";
        }

        //sao chép đối tượng ph
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    //tạo danh sách các phòng học
    public class DanhSachPhongHoc
    {
        List<PhongHoc> danhsach;
        public int Count { get { return danhsach.Count; } }
        public DanhSachPhongHoc()
        {
            danhsach = new List<PhongHoc>();
        }

        public void Add(PhongHoc phong)
        {
            danhsach.Add(phong);
        }

        public PhongHoc GetPhongHoc(int vitri)
        {
            if (danhsach.Count > 0 && danhsach.Count > vitri)
                return danhsach[vitri];
            else
                return null;
        }

        public List<PhongHoc> GetDanhSach()
        {
            return danhsach;
        }
    }

    //Tạo đối tượng giáo viên
    public class GiaoVien : ICloneable
    {
        public int IDGV { get; set; }
        public int IDMon { get; set; }
        public int ChuyenKhoi { get; set; }
        public string TenGV { get; set; }
        public string TenMon { get; set; }
        public int SoTiet { get; set; }
        public int SoTietDaDay { get; set; }
        public int SoTietChuaDay { get; set; }
        //hàm tạo
        public GiaoVien()
        {
            IDGV = 0;
            IDMon = 0;
            ChuyenKhoi = 0;
            TenGV = "";
            SoTiet = 0;
            SoTietDaDay = 0;
            SoTietChuaDay = 0;
        }

        //sao chép đối tượng giáo viên
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class DanhSachGiaoVien
    {
        List<GiaoVien> danhsach;
        public int Count { get { return danhsach.Count; } }
        public DanhSachGiaoVien()
        {
            danhsach = new List<GiaoVien>();
        }

        public void Add(GiaoVien gv)
        {
            danhsach.Add(gv);
        }

        public GiaoVien GetGiaoVien(int vitri)
        {
            if (danhsach.Count > 0 && danhsach.Count > vitri)
                return danhsach[vitri];
            else
                return null;
        }

        //overloading
        public DanhSachGiaoVien GetDanhSach(int IDMon)
        {
            DanhSachGiaoVien dsGV = new DanhSachGiaoVien();
            foreach (GiaoVien gv in danhsach)
                //nếu cùng môn thì thêm một bản sao của gv vào danh sách
                if (gv.IDMon == IDMon)
                    dsGV.Add((GiaoVien)gv.Clone());
            return dsGV;
        }

        //Để lấy ds các gv dạy môn có idMon và có số tiết rảnh đủ để dạy những tiết còn thiếu.
        public DanhSachGiaoVien GetDanhSach(int idMon, int soTiet)
        {
            DanhSachGiaoVien dsGV = new DanhSachGiaoVien();
            foreach (GiaoVien gv in danhsach)
                //nếu có cũng môn và có đủ số lượng tiết rảnh >= số tiết phân công thêm thì thêm gv vào ds
                if (gv.IDMon == idMon && gv.SoTietChuaDay >= soTiet)
                    dsGV.Add(gv);
            return dsGV;
        }

        //lấy ds các gv có cùng môn, dạy cùng khối, và có số tiết rảnh nhiều hơn số tiết cần
        public DanhSachGiaoVien GetDanhSach(int idMon, int khoi, int soTiet)
        {
            DanhSachGiaoVien dsGV = new DanhSachGiaoVien();
            foreach (GiaoVien gv in danhsach)
                if (gv.IDMon == idMon && gv.ChuyenKhoi == khoi && gv.SoTietChuaDay >= soTiet)
                    dsGV.Add(gv);
            return dsGV;
        }

        //lấy ra ngẫu nhiên một giáo viên
        public GiaoVien GetNgauNhienGV()
        {
            GiaoVien gv = new GiaoVien();
            if (danhsach.Count > 0)
            {
                Random rnd = new Random();
                //sinh số ngẫu nhiên trong khoảng số lượng của ds
                int vt = rnd.Next(danhsach.Count);
                gv = danhsach[vt];
            }
            return gv;
        }

        public List<GiaoVien> GetDanhSach()
        {
            return danhsach;
        }
    }

    public class MonHoc : ICloneable
    {
        public int IDMon { get; set; }
        public string Ten { get; set; }
        public bool Khoi6 { get; set; }
        public bool Khoi7 { get; set; }
        public bool Khoi8 { get; set; }
        public bool Khoi9 { get; set; }
        public int SoTietK6 { get; set; }
        public int SoTietK7 { get; set; }
        public int SoTietK8 { get; set; }
        public int SoTietK9 { get; set; }
        public int SoBuoiK6 { get; set; }
        public int SoBuoiK7 { get; set; }
        public int SoBuoiK8 { get; set; }
        public int SoBuoiK9 { get; set; }
        public bool TietKep { get; set; }
        public bool TietPhu { get; set; }

        //hàm tạo
        public MonHoc()
        {
            IDMon = 0;
            Ten = "";
            Khoi6 = false;
            Khoi7 = false;
            Khoi8 = false;
            Khoi9 = false;
            SoTietK6 = 0;
            SoTietK7 = 0;
            SoTietK8 = 0;
            SoTietK9 = 0;
            SoBuoiK6 = 0;
            SoBuoiK7 = 0;
            SoBuoiK8 = 0;
            SoBuoiK9 = 0;
            TietKep = false;
            TietPhu = false;
        }

        public int GetSoTiet(int khoi)
        {
            if (khoi == 6) return SoTietK6;
            else if (khoi == 7) return SoTietK7;
            else if (khoi == 8) return SoTietK8;
            else if (khoi == 9) return SoTietK9;
            else return 0;
        }

        public int GetSoBuoi(int khoi)
        {
            if (khoi == 6) return SoBuoiK6;
            else if (khoi == 7) return SoBuoiK7;
            else if (khoi == 8) return SoBuoiK8;
            else if (khoi == 9) return SoBuoiK9;
            else return 0;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class DanhSachMonHoc
    {
        List<MonHoc> danhsach;
        public int Count { get { return danhsach.Count; } }
        public DanhSachMonHoc()
        {
            danhsach = new List<MonHoc>();
        }

        public void Add(MonHoc mh)
        {
            danhsach.Add(mh);
        }

        public MonHoc GetMonHoc(int vitri)
        {
            if (danhsach.Count > 0 && danhsach.Count > vitri)
                return danhsach[vitri];
            else
                return null;
        }

        public List<MonHoc> GetDanhSach()
        {
            return danhsach;
        }
    }

    public class GVDayMonHoc : ICloneable
    {
        public int IDGV { get; set; }
        public int IDMon { get; set; }
        public int IDLop { get; set; }
        public string TenGV { get; set; }
        public string TenMon { get; set; }
        public string TenLop { get; set; }
        public int SoTiet { get; set; }

        public GVDayMonHoc()
        {
            IDGV = 0;
            IDMon = 0;
            IDLop = 0;
            SoTiet = 0;
            TenGV = "";
            TenMon = "";
            TenLop = "";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class DanhSachGVDayMH
    {
        List<GVDayMonHoc> danhsach;
        public int Count { get { return danhsach.Count; } }
        public DanhSachGVDayMH()
        {
            danhsach = new List<GVDayMonHoc>();
        }

        public void Add(GVDayMonHoc mh)
        {
            danhsach.Add(mh);
        }

        public GVDayMonHoc GetItem(int vitri)
        {
            if (danhsach.Count > 0 && danhsach.Count > vitri)
                return danhsach[vitri];
            else
                return null;
        }

        public List<GVDayMonHoc> GetDanhSach()
        {
            return danhsach;
        }
    }
}
