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
        //khai báo các đối tượng
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

        //contructor
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

        //xây dựng thông tin của các đối tượng lớp học và các tiết đặc biệt, cập nhật thông tin cho dsLop
        public void ListLopHoc(DataTable dt)
        {
            //nếu bảng ko rỗng
            if (dt != null)
            {
                AppConstant c = new AppConstant();
                //duyệt từng hàng của bảng
                foreach (DataRow row in dt.Rows)
                {
                    //tạo đối tượng lớp học
                    LopHoc lop = new LopHoc();
                    // Xác định các thuộc tính của LopHoc bằng cách lấy các giá trị tương ứng từ row (dòng dữ liệu hiện đang được duyệt)
                    lop.IDLop = (int)row["IDLop"];
                    if (!row.IsNull("IDGV")) lop.IDGV = (int)row["IDGV"];
                    if (!row.IsNull("Nam")) lop.Nam = (int)row["Nam"];
                    if (!row.IsNull("Khoi")) lop.Khoi = (int)row["Khoi"];
                    if (!row.IsNull("TenLop")) lop.TenLop = row["TenLop"].ToString();
                    if (!row.IsNull("SiSo")) lop.SiSo = (int)row["SiSo"];
                    if (!row.IsNull("BuoiHoc")) lop.BuoiHoc = (int)row["BuoiHoc"];
                    if (!row.IsNull("IDPH")) lop.IDPH = (int)row["IDPH"];
                    //Xây dựng tiết học cho từng ngày trong tuần bằng cách gán giá trị LoaiTiet tương ứng cho mỗi tiết học của lớp đó
                    //Xây dựng tiết Chào Cờ, Sinh Hoạt
                    lop.Thu[c.Thu7].Tiet[c.Tiet5].Loai = LoaiTiet.SinhHoat;
                    if (lop.BuoiHoc == c.BuoiSang)
                        lop.Thu[c.Thu2].Tiet[c.Tiet1].Loai = LoaiTiet.ChaoCo;
                    else
                        lop.Thu[c.Thu2].Tiet[c.Tiet5].Loai = LoaiTiet.ChaoCo;

                    //Giáo viên chủ nhiệm ở tiết sinh hoạt
                    lop.Thu[c.Thu7].Tiet[c.Tiet5].IDGV = lop.IDGV;

                    //đánh dấu các tiết không học
                    if (lop.Khoi == 6)
                    {
                        lop.TongTiet = 24;
                        lop.Thu[c.Thu3].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        //lop.Thu[c.Thu4].Tiet[c.Tiet4].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu4].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        //lop.Thu[c.Thu5].Tiet[c.Tiet4].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu6].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                    }
                    else if (lop.Khoi == 7)
                    {
                        lop.TongTiet = 26;
                        //lop.Thu[c.Thu3].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu4].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        //lop.Thu[c.Thu5].Tiet[c.Tiet4].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                    }
                    else if (lop.Khoi == 8)
                    {
                        lop.TongTiet = 27;
                        //lop.Thu[c.Thu4].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        //lop.Thu[c.Thu5].Tiet[c.Tiet4].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                    }
                    else if (lop.Khoi == 9)
                    {
                        lop.TongTiet = 27;
                        //lop.Thu[c.Thu3].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet4].Loai = LoaiTiet.KhongHoc;
                        lop.Thu[c.Thu5].Tiet[c.Tiet5].Loai = LoaiTiet.KhongHoc;
                    }
                    //tổng các tiết của các lớp
                    TongTiet += lop.TongTiet;
                    //thêm lớp vừa tạo xong vào dsLop
                    DSLop.Add(lop);
                }
            }
        }

        //xây dựng thông tin của các đối tượng phòng học, thêm phòng học vào cho dsP
        public void ListPhongHoc(DataTable dt)
        {
            //kiểm tra datatable có tồn tại chưa
            if (dt != null)
            {
                //duyệt từng hàng trong bảng
                foreach (DataRow row in dt.Rows)
                {
                    //tạo mới đối tượng phòng
                    PhongHoc phong = new PhongHoc();
                    //gán id của phòng
                    phong.IDPH = (int)row["IDPH"];
                    // Kiểm tra giá trị không phải null trước khi gán và chuyển về kiểu string
                    if (!row.IsNull("TenPH")) phong.TenPH = row["TenPH"].ToString();
                    if (!row.IsNull("SucChua")) phong.SucChua = (int)row["SucChua"];
                    if (!row.IsNull("ViTri")) phong.ViTri = row["ViTri"].ToString();
                    //add phòng mới vừa tạo vào ds
                    DSPhong.Add(phong);
                }
            }
        }

        //xây dựng thông tin của các đối tượng gv, thêm giáo viên vào cho dsGV
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
                    //gán giá trị cho số tiết chưa dạy bằng với số tiết
                    gv.SoTietChuaDay = gv.SoTiet;
                    //thêm gv vào dsGV
                    DSGiaoVien.Add(gv);
                }
            }
        }

        //xây dựng thông tin của các đối tượng môn học, thêm môn học vào cho dsMon
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

        //phân lịch ngẫu nhiên các môn học cho các tiết học trong tuần cho từng lớp
        public void PhanLichMonHoc()
        {
            AppConstant c = new AppConstant();
            ViTriTietHoc vt; int soTiet;
            ViTriNgauNhien rndTiet = new ViTriNgauNhien();
            // Có Lớp và có Môn học
            if (DSLop.Count > 0 && DSMon.Count > 0)
            {
                //Xét từng lớp trong dsLop
                foreach (LopHoc lop in DSLop.GetDanhSach())
                {
                    //Phân ngẫu nhiên các môn học vào các tiết học
                    rndTiet.TronNgauNhien();
                    //Lấy từng môn học trong dsMon
                    foreach (MonHoc mon in DSMon.GetDanhSach())
                    {
                        //lấy ra số tiết của từng môn theo khối
                        soTiet = mon.GetSoTiet(lop.Khoi);
                        //phân môn học vào từng tiết học
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
        }

        //PhanGiaoVien
        public void PhanGiaoVien()
        {
            // Có Lớp và có Môn học
            if (DSLop.Count > 0 && DSMon.Count > 0)
                //Duyệt từng lớp trong dsLop
                foreach (LopHoc lop in DSLop.GetDanhSach())
                    //duyệt từng môn một để có thể phân cho giáo viên của môn đó
                    foreach (MonHoc mon in DSMon.GetDanhSach())
                    {
                        //lấy ra số lượng tiết của môn đó théo từng khối
                        int soTiet = mon.GetSoTiet(lop.Khoi);
                        if (soTiet > 0)
                        {
                            //khởi tạo đối tượng
                            DanhSachGiaoVien dsGiaoVien = new DanhSachGiaoVien();
                            //Lấy danh sách giáo viên theo môn, chuyên khối, và có số tiết rảnh nhiều hơn số tiết đang cần phân.
                            dsGiaoVien = DSGiaoVien.GetDanhSach(mon.IDMon, lop.Khoi, soTiet);
                            //trường hợp nếu ko còn gv chuyên khối đang xét thì phải lấy gv khác khối
                            if (dsGiaoVien.Count == 0)
                                //chỉ cần lấy giáo viên theo môn và đủ thời gian dạy
                                dsGiaoVien = DSGiaoVien.GetDanhSach(mon.IDMon, soTiet);
                            //sau khi đã lấy được dsGV
                            if (dsGiaoVien.Count > 0)
                            {
                                // Lấy ngẫu nhiên một giáo viên trong ds
                                GiaoVien giaoVien = dsGiaoVien.GetNgauNhienGV();
                                //đối tượng lưu ttin dạy học môn nào lớp nào của giáo viên đó.
                                GVDayMonHoc day = new GVDayMonHoc();
                                //gán giá trị
                                day.IDGV = giaoVien.IDGV;
                                day.IDLop = lop.IDLop;
                                day.IDMon = mon.IDMon;
                                day.TenGV = giaoVien.TenGV;
                                day.TenLop = lop.TenLop;
                                day.TenMon = mon.Ten;
                                day.SoTiet = soTiet;

                                //danh sách chung của NST chứa ds thông tin dạy học của các giáo viên
                                DSDayHoc.Add(day);
                                //danh sách dạy học riêng của lớp môn học trong từng tiết do ai dạy
                                lop.DSDayHoc.Add(day);
                                //cập nhật thông tin về giáo viên dạy môn học này vào của lớp học đó
                                lop.UpdateGVDayMonHoc(mon.IDMon, giaoVien);
                                //tăng số tiết đã dạy
                                giaoVien.SoTietDaDay += soTiet;
                                //lấy tổng số số tiết của gv trừ đi số tiết mới đc phân
                                giaoVien.SoTietChuaDay -= soTiet;
                            }
                        }

                    }
        }

        //kiểm tra lịch dạy của giáo viên có bị trùng không, nếu trùng thì đánh dấu là vi phạm
        private void KiemTraTrungLich(Tiet tietKT, LopHoc lopKT)
        {
            ViTriTietHoc vt = new ViTriTietHoc(tietKT.Thu, tietKT.Index);
            foreach (LopHoc lop in DSLop.GetDanhSach())
            {
                //với từng lớp lấy ra tiết có cùng thời gian vưới tiết cần kiểm tra
                Tiet tiet = lop.Thu[vt.Thu].Tiet[vt.Tiet];
                // khác lớp
                if (lop != lopKT && lop.BuoiHoc == lopKT.BuoiHoc)
                    if (lop.BuoiHoc == lopKT.BuoiHoc) // cùng buổi học
                        //xét xem có phải tiết bình thương không trừ tiết chào cờ
                        if (tiet.Loai == LoaiTiet.BinhThuong)
                            if (tiet.IDGV == tietKT.IDGV)//cùng 1 gv => trùng lịch
                            {
                                //set loại vp cho cả 2 tiết vừa xét
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
            // Có Lớp và có Môn học
            if (DSLop.Count > 0 && DSMon.Count > 0)
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
                            //nếu có tiết nào mà chưa phân được giáo viên thì đánh dấu vp
                            if (tiet.Loai == LoaiTiet.BinhThuong && tiet.IDGV == 0)
                                tiet.LoaiViPham = LoaiViPham.ThieuGiaoVien;

                //Kiểm tra trùng lịch giáo viên
                foreach (LopHoc lop in DSLop.GetDanhSach())
                    foreach (Thu thu in lop.Thu)
                        foreach (Tiet tiet in thu.Tiet)
                            //kiểm tra tiết đó đã có gv dạy chưa
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
            //tính hệ số thích nghi bằng cách tính xem tỷ lệ vi phạm là bn
            if (TongTiet > 0)
                HeSoThichNghi = ((float)(TongTiet - TongTietViPham)) / ((float)TongTiet);
            return HeSoThichNghi;
        }

        public void TienHoa()
        {
            // Có Lớp và có Môn học
            if (DSLop.Count > 0 && DSMon.Count > 0)
                //duyệt từng lớp trong dsLop
                foreach (LopHoc lop in DSLop.GetDanhSach())
                    //duyệt từng thứ của lớp đó
                    foreach (Thu thu in lop.Thu)
                        //duyệt từng tiết trong hôm đó
                        foreach (Tiet tiet in thu.Tiet)
                            //kiểm tra có vp không và xử lý.
                            if (tiet.LoaiViPham != LoaiViPham.KhongViPham)
                                if (tiet.LoaiViPham == LoaiViPham.QuaSoBuoi)
                                    lop.GhepBuoi(tiet);
                                else if (tiet.LoaiViPham == LoaiViPham.ThieuSoBuoi)
                                    lop.TachBuoi(tiet);
                                else if (tiet.LoaiViPham == LoaiViPham.TrungLichGiaoVien)
                                    ChuyenTietTrungLich(tiet, lop);
            TinhDoThichNghi();
            //sau mỗi lần thì tăng thế hệ lên
            TheHe++;
        }

        //xử lý việc giáo viên bị trùng lịch
        private void ChuyenTietTrungLich(Tiet tiet, LopHoc lop)
        {
            Tiet tietB;
            ViTriTietHoc vt;
            ViTriNgauNhien rndVT = new ViTriNgauNhien();
            while (true)
            {
                //lấy một vị trí tiết học bất kỳ
                vt = rndVT.GetNextViTri();
                if (vt == null) break;
                tietB = lop.Thu[vt.Thu].Tiet[vt.Tiet];
                //Chỉ chọn tiết bình thường và Khác tiết đang cần chuyển
                if (tietB != tiet && tietB.Loai == LoaiTiet.BinhThuong)
                    //Khác giáo viên và môn học đang cần chuyển
                    if (tietB.IDGV != tiet.IDGV && tietB.IDMon != tiet.IDMon)
                        //kiểm tra xem vị trí mới có bị trùng không
                        if (!TrungLichGiaoVien(lop, tietB.Thu, tietB.Index, tiet.IDGV))
                            //Kiểm tra tiếp gv của tiết định đổi có bị trùng lịch với tiết đó ko.
                            if (!TrungLichGiaoVien(lop, tiet.Thu, tiet.Index, tietB.IDGV))
                            {
                                tiet.SwapNoiDungTiet(tietB);
                                tiet.LoaiViPham = LoaiViPham.DangXuLy;
                                tietB.LoaiViPham = LoaiViPham.DangXuLy;
                                break;
                            }
            }
        }

        //Kiểm tra lịch học này ở các lớp khác xem có cùng GV ko.
        private bool TrungLichGiaoVien(LopHoc lopKT, int iThu, int iTiet, int IDGV)
        {
            foreach (LopHoc lop in DSLop.GetDanhSach())
            {
                //lấy ra tiết học tại vị trí iThu và iTiet
                Tiet tiet = lop.Thu[iThu].Tiet[iTiet];
                //khác lớp
                if (lop != lopKT && lop.BuoiHoc == lopKT.BuoiHoc)
                    if (lop.BuoiHoc == lopKT.BuoiHoc) // cùng buổi học
                        if (tiet.Loai == LoaiTiet.BinhThuong)
                            if (tiet.IDGV == IDGV)//cùng 1 gv => trùng lịch
                                return true;
            }
            return false;
        }

    }
}
