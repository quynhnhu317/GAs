using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKB_THCS.AppCode
{
    public class ViTriTietHoc
    {
        public int Thu { get; set; }
        public int Tiet { get; set; }
        public ViTriTietHoc()
        {
            Thu = 0;
            Tiet = 0;
        }
        public ViTriTietHoc(int thu, int tiet)
        {
            Thu = thu;
            Tiet = tiet;
        }
    }

    public class DanhSachViTriTietHoc
    {
        List<ViTriTietHoc> danhsach;
        public int Count { get { return danhsach.Count; } }

        public DanhSachViTriTietHoc()
        {
            danhsach = new List<ViTriTietHoc>();
        }

        public void Add(ViTriTietHoc vt)
        {
            danhsach.Add(vt);
        }

        public ViTriTietHoc GetViTri(int index)
        {
            if (danhsach.Count > 0 && danhsach.Count > index)
                return danhsach[index];
            else
                return null;
        }

        public List<ViTriTietHoc> GetDanhSach()
        {
            return danhsach;
        }
    }

    // khởi tạo một danh sách các vị trí tiết học, sau đó trộn ngẫu nhiên các vị trí này lên
    public class ViTriNgauNhien
    {
        //khởi tạo danh sách chứa vtri các tiết học
        List<ViTriTietHoc> danhsach;
        int viTri = 0;
        public int Count { get { return danhsach.Count; } }

        public ViTriNgauNhien()
        {
            danhsach = new List<ViTriTietHoc>();
            AppConstant c = new AppConstant();
            viTri = 0;
            //Khởi tạo thứ và tiết theo thứ tự
            for (int thu = c.Thu2; thu <= c.Thu7; thu++)
                for (int tiet = c.Tiet1; tiet <= c.Tiet5; tiet++)
                {
                    //Với mỗi thứ và tiết học, tạo một đối tượng mới của ViTriTietHoc và thêm nó vào danh sách
                    ViTriTietHoc point = new ViTriTietHoc(thu, tiet);
                    danhsach.Add(point);
                }
            TronNgauNhien();
        }

        //Trộn ngẫu nhiên vị trí danh sách các vị trí đã khởi tạo trước đó.
        public void TronNgauNhien()
        {
            viTri = 0;
            int vitriDau, vitriCuoi;
            ViTriTietHoc tmp = new ViTriTietHoc();
            AppConstant c = new AppConstant();

            Random rnd = new Random();
            for (int thu = c.Thu2; thu <= c.Thu7; thu++)
                for (int tiet = c.Tiet1; tiet <= c.Tiet5; tiet++)
                {
                    vitriDau = rnd.Next(0, 29);// 30 tiết trong tuần
                    vitriCuoi = rnd.Next(0, 29);// 30 tiết trong tuần
                    if (vitriDau != vitriCuoi)
                    {
                        //swap vị trí
                        tmp.Thu = danhsach[vitriDau].Thu;
                        tmp.Tiet = danhsach[vitriDau].Tiet;

                        danhsach[vitriDau].Thu = danhsach[vitriCuoi].Thu;
                        danhsach[vitriDau].Tiet = danhsach[vitriCuoi].Tiet;

                        danhsach[vitriCuoi].Thu = tmp.Thu;
                        danhsach[vitriCuoi].Tiet = tmp.Tiet;
                    }
                }
        }

        public ViTriTietHoc GetNextViTri()
        {
            if (danhsach.Count > 0 && danhsach.Count > viTri)
                return danhsach[viTri++];
            else
                return null;
        }

        public ViTriTietHoc GetViTri(int index)
        {
            if (danhsach.Count > 0 && danhsach.Count > index)
                return danhsach[index];
            else
                return null;
        }

        public List<ViTriTietHoc> GetDanhSach()
        {
            return danhsach;
        }


    }
}
