using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKB_THCS;
using TKB_THCS.AppCode;

namespace TKB_THCS.AppCode
{
    public class NhiemSacThe
    {
        public DanhSachLopHoc DSLop { get; set; }
        public DanhSachPhongHoc DSPhong { get; set; }
        public DanhSachMonHoc DSMon { get; set; }
        public DanhSachGiaoVien DSGiaoVien { get; set; }
        public DanhSachGVDayMH DSDayHoc { get; set; }

        public int TongTiet { get; set; }
        public int TongTietHopLe { get; set; }
        public int TongTietViPham { get; set; }
        public int TheHe { get; set; }
        public float HeSoThichNghi { get; set; }

        public NhiemSacThe()
        {
            DSLop = new DanhSachLopHoc();
            DSPhong = new DanhSachPhongHoc();
            DSMon = new DanhSachMonHoc();
            DSGiaoVien = new DanhSachGiaoVien();
            DSDayHoc = new DanhSachGVDayMH();

            TheHe = 0;
            TongTiet = 0;
            TongTietHopLe = 0;
            TongTietViPham = 0;
            HeSoThichNghi = 0;
        }

        public void ListLopHoc(DataTable dt)
        {
            if (dt != null)
            {
                AppConstant c = new AppConstant();
                foreach (DataRow row in dt.Rows)
                {
                    LopHoc lop = new LopHoc();
                    lop.IDLop = (int)row["IDLop"];
                    if (!row.IsNull("IDGV")) lop.IDGV = (int)row["IDGV"];
                    //if (!row.IsNull("TenGV")) lop.TenGVCN = row["TenGV"].ToString();
                    if (!row.IsNull("Nam")) lop.Nam = (int)row["Nam"];
                    if (!row.IsNull("Khoi")) lop.Khoi = (int)row["Khoi"];
                    if (!row.IsNull("TenLop")) lop.TenLop = row["TenLop"].ToString();
                    if (!row.IsNull("SiSo")) lop.SiSo = (int)row["SiSo"];
                    if (!row.IsNull("BuoiHoc")) lop.BuoiHoc = (int)row["BuoiHoc"];
                    if (!row.IsNull("IDPH")) lop.IDPH = (int)row["IDPH"];

                    //Xây dựng tiết Chào Cờ, Sinh Hoạt
                    lop.Thu[c.Thu7].Tiet[c.Tiet5].Loai = LoaiTiet.SinhHoat;
                    if (lop.BuoiHoc == c.BuoiSang)
                        lop.Thu[c.Thu2].Tiet[c.Tiet1].Loai = LoaiTiet.ChaoCo;
                    else
                        lop.Thu[c.Thu2].Tiet[c.Tiet5].Loai = LoaiTiet.ChaoCo;

                    //Giáo viên chủ nhiệm ở tiết sinh hoạt
                    lop.Thu[c.Thu7].Tiet[c.Tiet5].IDGV = lop.IDGV;

                    //Lock các tiết không học
                    if (lop.Khoi == 6)
                    {
                        lop.TongTiet = 24;
                        lop.Thu[c.Thu3].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu4].Tiet[c.Tiet4].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu4].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet4].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu6].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                    }
                    else if (lop.Khoi == 7)
                    {
                        lop.TongTiet = 26;
                        lop.Thu[c.Thu3].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu4].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet4].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                    }
                    else if (lop.Khoi == 8)
                    {
                        lop.TongTiet = 27;
                        lop.Thu[c.Thu4].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet4].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                    }
                    else if (lop.Khoi == 9)
                    {
                        lop.TongTiet = 27;
                        lop.Thu[c.Thu3].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet4].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                    }
                    TongTiet += lop.TongTiet;
                    DSLop.Add(lop);
                }
            }
        }

        public void ListPhongHoc(DataTable dt)
        {
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    PhongHoc phong = new PhongHoc();
                    phong.IDPH = (int)row["IDPH"];
                    if (!row.IsNull("TenPH")) phong.TenPH = row["TenPH"].ToString();
                    if (!row.IsNull("SucChua")) phong.SucChua = (int)row["SucChua"];
                    if (!row.IsNull("ViTri")) phong.ViTri = row["ViTri"].ToString();
                    DSPhong.Add(phong);
                }
            }
        }

        public void ListGiaoVien(DataTable dt)
        {
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    GiaoVien gv = new GiaoVien();
                    gv.IDGV = (int)row["IDGV"];

                    if (!row.IsNull("TenGV")) gv.TenGV = row["TenGV"].ToString();
                    if (!row.IsNull("IDMon")) gv.IDMon = (int)row["IDMon"];
                    if (!row.IsNull("TenMon")) gv.TenMon = row["TenMon"].ToString();
                    if (!row.IsNull("ChuyenKhoi")) gv.ChuyenKhoi = (int)row["ChuyenKhoi"];
                    if (!row.IsNull("SoTiet")) gv.SoTiet = (int)row["SoTiet"];
                    gv.SoTietChuaDay = gv.SoTiet;
                    DSGiaoVien.Add(gv);
                }
            }
        }

        public void ListMonHoc(DataTable dt)
        {
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    MonHoc mh = new MonHoc();
                    mh.IDMon = (int)row["IDMon"];
                    if (!row.IsNull("Ten")) mh.Ten = row["Ten"].ToString();
                    if (!row.IsNull("Khoi6")) mh.Khoi6 = (bool)row["Khoi6"];
                    if (!row.IsNull("Khoi7")) mh.Khoi7 = (bool)row["Khoi7"];
                    if (!row.IsNull("Khoi8")) mh.Khoi8 = (bool)row["Khoi8"];
                    if (!row.IsNull("Khoi9")) mh.Khoi9 = (bool)row["Khoi9"];
                    if (!row.IsNull("SoTietK6")) mh.SoTietK6 = (int)row["SoTietK6"];
                    if (!row.IsNull("SoTietK7")) mh.SoTietK7 = (int)row["SoTietK7"];
                    if (!row.IsNull("SoTietK8")) mh.SoTietK8 = (int)row["SoTietK8"];
                    if (!row.IsNull("SoTietK9")) mh.SoTietK9 = (int)row["SoTietK9"];
                    if (!row.IsNull("SoBuoiK6")) mh.SoBuoiK6 = (int)row["SoBuoiK6"];
                    if (!row.IsNull("SoBuoiK7")) mh.SoBuoiK7 = (int)row["SoBuoiK7"];
                    if (!row.IsNull("SoBuoiK8")) mh.SoBuoiK8 = (int)row["SoBuoiK8"];
                    if (!row.IsNull("SoBuoiK9")) mh.SoBuoiK9 = (int)row["SoBuoiK9"];
                    if (!row.IsNull("Kep")) mh.TietKep = (bool)row["Kep"];
                    if (!row.IsNull("Phu")) mh.TietPhu = (bool)row["Phu"];
                    DSMon.Add(mh);
                }
            }
        }

        public void PhanLichMonHoc()
        {
            AppConstant c = new AppConstant(); ViTriTietHoc vt; int soTiet;
            ViTriNgauNhien rndTiet = new ViTriNgauNhien();

            if (DSLop.Count > 0 && DSMon.Count > 0) // Có Lớp và có Môn học
            {
                foreach (LopHoc lop in DSLop.GetDanhSach())
                {
                    rndTiet.TronNgauNhien(); //Phân ngẫu nhiên các môn học vào các tiết học
                    foreach (MonHoc mon in DSMon.GetDanhSach())
                    {
                        soTiet = mon.GetSoTiet(lop.Khoi);
                        for (int i = 0; i < soTiet; i++)
                        {
                            //Chỉ chọn những tiết trong quy định
                            do
                            {
                                vt = rndTiet.GetNextViTri();
                                if (vt == null) break;
                            } while (lop.Thu[vt.Thu].Tiet[vt.Tiet].Loai != LoaiTiet.BinhThuong);

                            if (vt != null)
                            {
                                lop.Thu[vt.Thu].Tiet[vt.Tiet].IDMon = mon.IDMon;
                                lop.Thu[vt.Thu].Tiet[vt.Tiet].TenMon = mon.Ten;
                                lop.Thu[vt.Thu].Tiet[vt.Tiet].TietKep = mon.TietKep;
                                lop.Thu[vt.Thu].Tiet[vt.Tiet].TietPhu = mon.TietPhu;
                            }
                            //else Ghi log lỗi. không còn tiết để phân môn học (số tiết môn học lớn hơn số tiết quy định trong tuần)
                        }
                    }
                }
            }
        }//PhanLichMonHoc

        public void PhanGiaoVien()
        {
            if (DSLop.Count > 0 && DSMon.Count > 0) // Có Lớp và có Môn học
                foreach (LopHoc lop in DSLop.GetDanhSach())
                    foreach (MonHoc mon in DSMon.GetDanhSach())
                    {

                        int soTiet = mon.GetSoTiet(lop.Khoi);
                        if (soTiet > 0)
                        {
                            DanhSachGiaoVien dsGiaoVien = new DanhSachGiaoVien();
                            //Láy danh sách giáo viên theo môn, chuyên khối
                            dsGiaoVien = DSGiaoVien.GetDanhSach(mon.IDMon, lop.Khoi, soTiet);
                            if (dsGiaoVien.Count == 0)  //nếu ko còn gv thì phải láy gv khác khối
                                dsGiaoVien = DSGiaoVien.GetDanhSach(mon.IDMon, soTiet);
                            if (dsGiaoVien.Count > 0)
                            {
                                GiaoVien giaoVien = dsGiaoVien.GetNgauNhienGV(); // Láy ngẫu nhiên một giáo viên
                                GVDayMonHoc day = new GVDayMonHoc();
                                day.IDLop = lop.IDLop;
                                day.IDMon = mon.IDMon;
                                day.IDGV = giaoVien.IDGV;
                                day.TenLop = lop.TenLop;
                                day.TenMon = mon.Ten;
                                day.TenGV = giaoVien.TenGV;
                                day.SoTiet = soTiet;

                                DSDayHoc.Add(day); //danh sách chung của NST
                                lop.DSDayHoc.Add(day); //danh sách dạy học riêng của lớp
                                lop.UpdateGVDayMonHoc(mon.IDMon, giaoVien);
                                giaoVien.SoTietDaDay += soTiet;
                                giaoVien.SoTietChuaDay -= soTiet;
                            } //else //Ghi log loi
                        } //else //Ghi log loi

                    }
        }//PhanGiaoVien

        private void KiemTraTrungLich(Tiet tietKT, LopHoc lopKT)
        {
            ViTriTietHoc vt = new ViTriTietHoc(tietKT.Thu, tietKT.Index);
            foreach (LopHoc lop in DSLop.GetDanhSach())
            {
                Tiet tiet = lop.Thu[vt.Thu].Tiet[vt.Tiet];//cùng thứ, cùng tiết
                if (lop != lopKT && lop.BuoiHoc == lopKT.BuoiHoc) // khác lớp
                    if (lop.BuoiHoc == lopKT.BuoiHoc) // cùng buổi học
                        if (tiet.Loai == LoaiTiet.BinhThuong)
                            if (tiet.IDGV == tietKT.IDGV)//cùng 1 gv => trùng lịch
                            {
                                tiet.LoaiViPham = LoaiViPham.TrungLichGiaoVien;
                                tietKT.LoaiViPham = LoaiViPham.TrungLichGiaoVien;
                            }
            }
        }

        public float TinhDoThichNghi()
        {
            HeSoThichNghi = 0;
            //int tongTiet, tongTietViPham;
            TongTiet = 0;
            TongTietHopLe = 0;
            TongTietViPham = 0;
            if (DSLop.Count > 0 && DSMon.Count > 0) // Có Lớp và có Môn học
            {
                //Xóa hết vi phạm để tính lại
                foreach (LopHoc lop in DSLop.GetDanhSach())
                {
                    foreach (Thu thu in lop.Thu)
                        foreach (Tiet tiet in thu.Tiet)
                            tiet.LoaiViPham = LoaiViPham.KhongViPham;
                    lop.TongTietHopLe = lop.TongTiet;
                    lop.TongTietViPham = 0;
                }

                //Kiểm tra thiếu giáo viên
                foreach (LopHoc lop in DSLop.GetDanhSach())
                    foreach (Thu thu in lop.Thu)
                        foreach (Tiet tiet in thu.Tiet)
                            if (tiet.Loai == LoaiTiet.BinhThuong && tiet.IDGV == 0)
                                tiet.LoaiViPham = LoaiViPham.ThieuGiaoVien;

                //Kiểm tra trùng lịch giáo viên
                foreach (LopHoc lop in DSLop.GetDanhSach())
                    foreach (Thu thu in lop.Thu)
                        foreach (Tiet tiet in thu.Tiet)
                            if (tiet.Loai == LoaiTiet.BinhThuong && tiet.IDGV > 0)
                                KiemTraTrungLich(tiet, lop);

                //Kiểm tra vi phạm số buổi và số tiết
                foreach (LopHoc lop in DSLop.GetDanhSach())
                {
                    foreach (MonHoc mon in DSMon.GetDanhSach())
                    {
                        lop.ViPhamSoTiet(mon);
                        lop.ViPhamSoBuoi(mon);
                    }
                    lop.TinhSoTietViPham();
                    TongTiet += lop.TongTiet;
                    TongTietHopLe += lop.TongTietHopLe;
                    TongTietViPham += lop.TongTietViPham;
                }
            }

            if (TongTiet > 0)
                HeSoThichNghi = ((float)(TongTiet - TongTietViPham)) / ((float)TongTiet);
            return HeSoThichNghi;
        }

        public void TienHoa()
        {
            if (DSLop.Count > 0 && DSMon.Count > 0) // Có Lớp và có Môn học
                foreach (LopHoc lop in DSLop.GetDanhSach())
                    foreach (Thu thu in lop.Thu)
                        foreach (Tiet tiet in thu.Tiet)
                            if (tiet.LoaiViPham != LoaiViPham.KhongViPham)
                                if (tiet.LoaiViPham == LoaiViPham.QuaSoBuoi)
                                    lop.GhepBuoi(tiet);
                                else if (tiet.LoaiViPham == LoaiViPham.ThieuSoBuoi)
                                    lop.TachBuoi(tiet);
                                else if (tiet.LoaiViPham == LoaiViPham.TrungLichGiaoVien)
                                    ChuyenTietTrungLich(tiet, lop);
            TinhDoThichNghi();
            TheHe++;
        }

        private void ChuyenTietTrungLich(Tiet tiet, LopHoc lop)
        {
            Tiet tietB;
            ViTriTietHoc vt;
            ViTriNgauNhien rndVT = new ViTriNgauNhien();
            while (true)
            {
                vt = rndVT.GetNextViTri();//láy một vị trí tiết học bất kỳ
                if (vt == null) break;
                tietB = lop.Thu[vt.Thu].Tiet[vt.Tiet];
                if (tietB != tiet && tietB.Loai == LoaiTiet.BinhThuong)//Chỉ chọn tiết bình thường và Khác tiết đang cần chuyển
                    if (tietB.IDGV != tiet.IDGV && tietB.IDMon != tiet.IDMon)//Khác giáo viên và môn học đang cần chuyển
                        if (!TrungLichGiaoVien(lop, tietB.Thu, tietB.Index, tiet.IDGV))//Không trùng lịch ở vị trí mới
                            if (!TrungLichGiaoVien(lop, tiet.Thu, tiet.Index, tietB.IDGV))//Không trùng lịch ở vị trí mới
                            {
                                tiet.SwapNoiDungTiet(tietB);
                                tiet.LoaiViPham = LoaiViPham.DangXuLy;
                                tietB.LoaiViPham = LoaiViPham.DangXuLy;
                                break;
                            }
            }
        }

        private bool TrungLichGiaoVien(LopHoc lopKT, int iThu, int iTiet, int IDGV)
        {
            foreach (LopHoc lop in DSLop.GetDanhSach())
            {
                Tiet tiet = lop.Thu[iThu].Tiet[iTiet];//cùng thứ, cùng tiết
                if (lop != lopKT && lop.BuoiHoc == lopKT.BuoiHoc) // khác lớp
                    if (lop.BuoiHoc == lopKT.BuoiHoc) // cùng buổi học
                        if (tiet.Loai == LoaiTiet.BinhThuong)
                            if (tiet.IDGV == IDGV)//cùng 1 gv => trùng lịch
                                return true;
            }
            return false;
        }

    }
}
