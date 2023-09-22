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
        public static readonly LoaiTiet TheDuc = new LoaiTiet(4);
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
        public int Index { get; set; }
        public int Thu { get; set; }
        public int IDMon { get; set; }
        public int IDGV { get; set; }
        public string TenGV { get; set; }
        public string TenMon { get; set; }
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

        public void SwapNoiDungTiet(Tiet tietB)
        {
            Tiet tmp = new Tiet(0, 0);
            tmp.IDMon = this.IDMon;
            tmp.TenMon = this.TenMon;
            tmp.IDGV = this.IDGV;
            tmp.TenGV = this.TenGV;
            tmp.TietKep = this.TietKep;
            tmp.TietPhu = this.TietPhu;

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

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public class Thu : ICloneable
    {
        public int Index { get; set; }
        private const int tongTiet = 5;
        public Tiet[] Tiet = new Tiet[tongTiet];
        public Thu(int index)
        {
            Index = index;
            for (int i = 0; i < tongTiet; i++)
                Tiet[i] = new Tiet(i, Index);
        }

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

        private const int tongThu = 6; //t2 den t7
        public Thu[] Thu = new Thu[tongThu];
        public LopHoc()
        {
            DSDayHoc = new DanhSachGVDayMH();
            for (int i = 0; i < tongThu; i++)
                Thu[i] = new Thu(i);
            IDLop = 0;
            IDGV = 0;
            IDPH = 0;
            TenLop = "";
            Nam = 0;
            Khoi = 0;
            SiSo = 0;
            BuoiHoc = 0;
        }

        public void UpdateGVDayMonHoc(int IDMon, GiaoVien gv)
        {
            foreach (Thu thu in Thu)
                foreach (Tiet tiet in thu.Tiet)
                {
                    if (tiet.IDMon == IDMon)
                    {
                        tiet.IDGV = gv.IDGV;
                        tiet.TenGV = gv.TenGV;
                    }
                }
        }

        public bool ViPhamSoTiet(MonHoc mon)
        {
            bool res = false;
            foreach (Thu thu in Thu)
            {
                int slTietTrongNgay = 0;
                bool viPham = false;
                foreach (Tiet tiet in thu.Tiet)
                    if (tiet.IDMon == mon.IDMon)
                        slTietTrongNgay++;

                if (slTietTrongNgay > 1)
                {
                    if (!mon.TietKep)
                        viPham = true;//ko phải tiết kép và sl tiết > 1
                    else if (slTietTrongNgay > 2)
                        viPham = true;//tiết kép mà sl > 2
                }

                if (viPham)//nếu vi phạm thì lưu lại vị trí tiết vi phạm 
                {
                    res = true;
                    foreach (Tiet tiet in thu.Tiet)
                        if (tiet.IDMon == mon.IDMon)
                            tiet.LoaiViPham = LoaiViPham.QuaSoTiet;
                }
            }
            return res;
        }

        public bool ViPhamSoBuoi(MonHoc mon)
        {
            int tongBuoi = 0;
            foreach (Thu thu in Thu)
                foreach (Tiet tiet in thu.Tiet)
                    if (tiet.IDMon == mon.IDMon)
                    {
                        tongBuoi++;
                        break;
                    }

            LoaiViPham vp = LoaiViPham.KhongViPham;
            if (this.Khoi == 6 && tongBuoi > mon.SoBuoiK6) vp = LoaiViPham.QuaSoBuoi;
            else if (this.Khoi == 6 && tongBuoi < mon.SoBuoiK6) vp = LoaiViPham.ThieuSoBuoi;
            else if (this.Khoi == 7 && tongBuoi > mon.SoBuoiK7) vp = LoaiViPham.QuaSoBuoi;
            else if (this.Khoi == 7 && tongBuoi < mon.SoBuoiK7) vp = LoaiViPham.ThieuSoBuoi;
            else if (this.Khoi == 8 && tongBuoi > mon.SoBuoiK8) vp = LoaiViPham.QuaSoBuoi;
            else if (this.Khoi == 8 && tongBuoi < mon.SoBuoiK8) vp = LoaiViPham.ThieuSoBuoi;
            else if (this.Khoi == 9 && tongBuoi > mon.SoBuoiK9) vp = LoaiViPham.QuaSoBuoi;
            else if (this.Khoi == 9 && tongBuoi < mon.SoBuoiK9) vp = LoaiViPham.ThieuSoBuoi;

            if (vp != LoaiViPham.KhongViPham)
                foreach (Thu thu in Thu)
                    foreach (Tiet tiet in thu.Tiet)
                        if (tiet.IDMon == mon.IDMon)
                            tiet.LoaiViPham = vp;

            return (vp != LoaiViPham.KhongViPham);
        }

        public void TinhSoTietViPham()
        {
            int viPham = 0;
            foreach (Thu thu in Thu)
                foreach (Tiet tiet in thu.Tiet)
                    if (tiet.LoaiViPham != LoaiViPham.KhongViPham)
                        viPham++;
            TongTietViPham = viPham;
            TongTietHopLe = TongTiet - TongTietViPham;
        }

        public void GhepBuoi(Tiet tiet)
        {
            AppConstant cons = new AppConstant();
            ViTriNgauNhien rndVT = new ViTriNgauNhien();
            ViTriTietHoc vt;
            Tiet tmp = null, tietA = null, tietB = null;
            //Chọn một vị trí tiết học bất kỳ đủ điều kiện để ghép
            do
            {
                vt = rndVT.GetNextViTri();
                if (vt == null) break; //ko chọn đc
                tmp = Thu[vt.Thu].Tiet[vt.Tiet];
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
            else if (Thu[tiet.Thu].Tiet[tiet.Index + 1].Loai == LoaiTiet.BinhThuong)
                tietB = Thu[tiet.Thu].Tiet[tiet.Index + 1];
            else if (Thu[tiet.Thu].Tiet[tiet.Index - 1].Loai == LoaiTiet.BinhThuong)
                tietB = Thu[tiet.Thu].Tiet[tiet.Index - 1];

            if (tietA != null && tietB != null)//hoán đổi nội dung (Môn, GV)
            {
                tietA.SwapNoiDungTiet(tietB);
                tietA.LoaiViPham = LoaiViPham.DangXuLy;
                tietB.LoaiViPham = LoaiViPham.DangXuLy;
            }
        }

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
                if (vt == null) break; //ko chọn đc
                tmp = Thu[vt.Thu].Tiet[vt.Tiet];
                if (tmp.Loai == LoaiTiet.BinhThuong)
                    if (tmp.Thu != tiet.Thu && tmp.IDMon != tiet.IDMon)
                    {
                        tietA = tmp;
                        break; //chọn một tiết bất kỳ không vi phạm, không phải tiết kép, khác thứ, khác môn
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

    public class DanhSachLopHoc
    {
        List<LopHoc> danhsach;
        public int Count { get { return danhsach.Count; } }

        public DanhSachLopHoc()
        {
            danhsach = new List<LopHoc>();
        }

        public void Add(LopHoc lop)
        {
            danhsach.Add(lop);
        }

        public LopHoc GetLopHoc(int vitri)
        {
            if (danhsach.Count > 0 && danhsach.Count > vitri)
                return danhsach[vitri];
            else
                return null;
        }

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
        public PhongHoc()
        {
            IDPH = 0;
            TenPH = "";
            SucChua = 0;
            ViTri = "";
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

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

        public DanhSachGiaoVien GetDanhSach(int IDMon)
        {
            DanhSachGiaoVien dsGV = new DanhSachGiaoVien();
            foreach (GiaoVien gv in danhsach)
                if (gv.IDMon == IDMon)
                    dsGV.Add((GiaoVien)gv.Clone());
            return dsGV;
        }

        public DanhSachGiaoVien GetDanhSach(int idMon, int soTiet)
        {
            DanhSachGiaoVien dsGV = new DanhSachGiaoVien();
            foreach (GiaoVien gv in danhsach)
                if (gv.IDMon == idMon && gv.SoTietChuaDay >= soTiet)
                    dsGV.Add(gv); //dsGV.Add((GiaoVien)gv.Clone()); dsGV.Add(gv);
            return dsGV;
        }

        public DanhSachGiaoVien GetDanhSach(int idMon, int khoi, int soTiet)
        {
            DanhSachGiaoVien dsGV = new DanhSachGiaoVien();
            foreach (GiaoVien gv in danhsach)
                if (gv.IDMon == idMon && gv.ChuyenKhoi == khoi && gv.SoTietChuaDay >= soTiet)
                    dsGV.Add(gv); //dsGV.Add((GiaoVien)gv.Clone());
            return dsGV;
        }

        public GiaoVien GetNgauNhienGV()
        {
            GiaoVien gv = new GiaoVien();
            if (danhsach.Count > 0)
            {
                Random rnd = new Random();
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
