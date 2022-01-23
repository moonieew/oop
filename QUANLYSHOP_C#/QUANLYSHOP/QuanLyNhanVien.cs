using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QUANLYSHOP
{
    public class QuanLyNhanVien
    {
        private List<NhanVien> lNhanVien;

        public List<NhanVien> LNhanVien { get => lNhanVien; set => lNhanVien = value; }

        protected TuVan ThemTuVan()
        {
            Console.Write("     Mã nhân viên: ");
            String sMaNV = Console.ReadLine();

            int nv = KiemTraTonTaiMaNV(sMaNV);

            while (nv > 0)
            {
                Console.WriteLine("  WARNING: Mã nhân viên đã tồn tại. Vui lòng nhập mã khác ");
                sMaNV = Console.ReadLine();
                nv = KiemTraTonTaiMaNV(sMaNV);

            }


            Console.Write("     Tên nhân viên: ");
            String sTen = Console.ReadLine();

            Console.Write("     Giới tính: ");
            String sGioiTinh = Console.ReadLine();

            Console.Write("     CMND: ");
            String sCMND = Console.ReadLine();

            Console.Write("     Năm sinh: ");
            int iNamSinh = int.Parse(Console.ReadLine());

            Console.Write("     Địa chỉ: ");
            String sDiaChi = (Console.ReadLine());

            Console.Write("     SĐT: ");
            String sSDT = Console.ReadLine();

            TuVan tv = new TuVan(sMaNV, sTen, iNamSinh, sSDT, sDiaChi, sCMND, "TV", sGioiTinh, 0, 0);
            return tv;
        }

        protected ThuNgan ThemThuNgan()
        {
            Console.Write("      Mã nhân viên: ");
            String sMaNV = Console.ReadLine();

            int nv = KiemTraTonTaiMaNV(sMaNV);

            while (nv > 0)
            {
                Console.WriteLine("  WARNING: Mã nhân viên đã tồn tại. Vui lòng nhập mã khác ");
                sMaNV = Console.ReadLine();

                nv = KiemTraTonTaiMaNV(sMaNV);
            }

            Console.Write("     Tên nhân viên: ");
            String sTen = Console.ReadLine();

            Console.Write("     Giới tính: ");
            String sGioiTinh = Console.ReadLine();

            Console.Write("     CMND: ");
            String sCMND = Console.ReadLine();

            Console.Write("     Năm sinh: ");
            int iNamSinh = int.Parse(Console.ReadLine());

            Console.Write("     Địa chỉ: ");
            String sDiaChi = (Console.ReadLine());

            Console.Write("     SĐT: ");
            String sSDT = Console.ReadLine();

            ThuNgan tn = new ThuNgan();
            return tn;
        }
        protected QuanLy ThemQuanLy()
        {
            Console.Write("     Mã nhân viên: ");
            String sMaNV = Console.ReadLine();

            int nv = KiemTraTonTaiMaNV(sMaNV);

            while (nv > 0)
            {
                Console.Write("  WARNING: Mã nhân viên đã tồn tại. Vui lòng nhập mã khác ");
                sMaNV = Console.ReadLine();
                nv = KiemTraTonTaiMaNV(sMaNV);
            }

            Console.Write("     Tên nhân viên: ");
            String sTen = Console.ReadLine();

            Console.Write("     Giới tính: ");
            String sGioiTinh = Console.ReadLine();

            Console.Write("     CMND: ");
            String sCMND = Console.ReadLine();

            Console.Write("     Năm sinh: ");
            int iNamSinh = Convert.ToInt16(Console.ReadLine());

            Console.Write("     Địa chỉ: ");
            String sDiaChi = (Console.ReadLine());

            Console.Write("     SĐT: ");
            String sSDT = Console.ReadLine();

            QuanLy quanLy = new QuanLy(sMaNV, sTen, iNamSinh, sSDT, sDiaChi, sCMND, "NV", sGioiTinh);
            return quanLy;
        }

        private int KiemTraTonTaiMaNV(string manv)
        {
            return (from nhanvien in lNhanVien
                    where nhanvien.SMaNV == manv
                    select nhanvien).Count();
        }

        private String TaoMaNV(String sLoaiNV)
        {
            int so = 0;
            for (int j = this.LNhanVien.Count - 1; j >= 0; j--)
            {
                if (LNhanVien[j].Equals(sLoaiNV))
                {
                    so = int.Parse(this.LNhanVien[j].SMaNV.Substring(2, 4)); //substring(a,b) lấy đoạn chuỗi từ a đến b-1
                    break;
                }
            }

            if (so < 9)
                return sLoaiNV + "0" + 1;
            else
                return sLoaiNV + (so + 1);
        }
        public void addNhanVien()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("              THÔNG TIN NHÂN VIÊN MỚI");
            Console.WriteLine("         ---VUI LÒNG CHỌN LOẠI NHÂN VIÊN--- ");

            String sLoaiNV = "";
            do
            {
                Console.WriteLine("     QUẢN LÝ       : QL");
                Console.WriteLine("     THU NGÂN      : TN");
                Console.WriteLine("     TƯ VẤN VIÊN   : TV");
                Console.Write("\n LỰA CHỌN CỦA BẠN LÀ: ");
                sLoaiNV = Console.ReadLine();
            }
            while (!sLoaiNV.Equals("QL") && !sLoaiNV.Equals("TN") && !sLoaiNV.Equals("TV"));

            String maNV = TaoMaNV(sLoaiNV);

            // sMaNV, sTen, iNamSinh, sSDT, sDiaChi, sCMND, sLoaiNV, sGioiTinh

            switch (sLoaiNV)
            {
                case "QL":
                    QuanLy ql = ThemQuanLy();
                    LNhanVien.Add(ql);
                    break;

                case "TN":
                    ThuNgan tn = ThemThuNgan();
                    LNhanVien.Add(tn);
                    break;
                case "TV":
                    TuVan tv = ThemTuVan();
                    LNhanVien.Add(tv);
                    break;
                default:
                    break;
            }

            Console.WriteLine("     Thông tin nhân viên mới đã được lưu !!");
            Console.WriteLine("________________________________________________________");
        }
        public QuanLyNhanVien()
        {
            lNhanVien = new List<NhanVien>();

            // quản lý
            NhanVien ql1 = new QuanLy("QL01", "Trần Thị Thanh Tâm", 1999, "0988188449", "Quận 9, Tp.HCM", "251274983", "QL", "Nữ");
            lNhanVien.Add(ql1);
            NhanVien ql2 = new QuanLy("QL02", "Nguyễn Trần Tiểu Vy", 1999, "0988188733", "Quận 8, Tp.HCM", "251287483", "QL", "Nam");
            lNhanVien.Add(ql2);

            // thu ngân
            NhanVien tn1 = new ThuNgan("TN01", "Lê Quỳnh Trâm Anh", 1998, "0986978673", "Quận Thủ Đức, Tp.HCM", "251274453", "TN", "Nữ", 0, 0);
            lNhanVien.Add(tn1);
            NhanVien tn2 = new ThuNgan("TN02", "Nguyễn Đình Thái Ngân", 1997, "0984567673", "Quận Bình Thạnh, Tp.HCM", "256784453", "TN", "Nam", 0, 0);
            lNhanVien.Add(tn2);

            // tư vấn
            NhanVien tv1 = new TuVan("TV01", "Cao Mỹ Nhân", 2001, "0987983245", "Quận 2, Tp.HCM", "245274983", "TV", "Nữ", 0, 0);
            lNhanVien.Add(tv1);
            NhanVien tv2 = new TuVan("TV02", "Trần Nguyễn Tuấn Anh", 2001, "0935983245", "Quận 3, Tp.HCM", "246274983", "TV", "Nam", 0, 0);
            lNhanVien.Add(tv2);
        }

        public void showNhanVien()
        {

            Console.WriteLine("____Chọn danh sách: ");
            Console.WriteLine("	    0.Toàn bộ nhân viên");
            Console.WriteLine("	    1.Quản Lý");
            Console.WriteLine("	    2.Thu Ngân");
            Console.WriteLine("	    3.Tư Vấn Viên");
            Console.Write("\n LỰA CHỌN CỦA BẠN LÀ: ");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 0:
                    showAllNhanVien();
                    break;
                case 1:
                    showQuanLy();
                    break;
                case 2:
                    showThuNgan();
                    break;
                case 3:
                    showTuVan();
                    break;
                default:
                    break;
            }
        }

        public void showAllNhanVien()
        {
            Console.WriteLine("                                                 DANH SÁCH TẤT CẢ NHÂN VIÊN FASHION'S SHOP");
            Console.WriteLine("    __________________________________________________________________________________________________________________________\n");
            Console.WriteLine("    |STT  |Mã NV|       Họ và Tên          |Giới Tính|      CMND       |Năm sinh|            Địa chỉ           |Số Điện Thoại|");
            Console.WriteLine("    __________________________________________________________________________________________________________________________");
            int i = 1;

            foreach (var nv in LNhanVien)
            {
                // In thông tin của nhân viên ra màn hình
                Console.WriteLine("      {0,-5}{1,-10}{2,-25}{3,-11}{4,-16}{5,-14}{6,-28}{7,-10} ", i, nv.SMaNV, nv.STen, nv.SGioiTinh, nv.SCMND, nv.INamSinh, nv.SDiaChi, nv.SSDT);
                i++;
            }
            Console.WriteLine("    __________________________________________________________________________________________________________________________");

            Console.WriteLine();
        }

        public void showQuanLy()
        {
            Console.WriteLine("                            DANH SÁCH NHÂN VIÊN QUẢN LÝ FASHION'S SHOP");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine(
                    "    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int i = 1;
            foreach (var nv in LNhanVien)
                if (nv.SLoaiNV == "QL")
                {
                    Console.Write("     {0,-5}", i++);
                    nv.ShowInfo();

                }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();
        }

        public void showThuNgan()
        {
            Console.WriteLine("                            DANH SÁCH NHÂN VIÊN THU NGÂN FASHION'S SHOP");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine(
                    "    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int i = 1;
            foreach (var nv in LNhanVien)
                if (nv.SLoaiNV == "TN")
                {
                    Console.Write("     {0,-5}", i++);
                    nv.ShowInfo();
                }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();
        }

        public void showTuVan()
        {
            Console.WriteLine("                         DANH SÁCH NHÂN VIÊN TƯ VẤN FASHION'S SHOP");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine(
                    "    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int i = 1;
            foreach (var nv in LNhanVien)
                if (nv.SLoaiNV == "TV")
                {
                    Console.Write("     {0,-5}", i++);
                    nv.ShowInfo();
                }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();

        }


        public void delNhanVien()
        {

            Console.WriteLine("     Nhập mã nhân viên của nhân viên bạn muốn xóa: ");
            string m = Console.ReadLine();
            var nhanvien = (from NV in lNhanVien
                            where NV.SMaNV == m
                            select NV).Count();
            if (nhanvien == 0)
            {
                Console.WriteLine("     Mã nhân viên này không tồn tại, bạn gõ 3 đã tiếp tục  !");
                Console.WriteLine("__________________________________________________________");

            }
            else if (nhanvien > 0)
            {
                var nv = (from NV in lNhanVien
                          where NV.SMaNV == m
                          select NV).First();
                lNhanVien.Remove(nv);
                Console.WriteLine("     Nhân viên " + m + " đã bị xóa !");
                Console.WriteLine("__________________________________________________________");
            }

        }


        public void editNhanVien()
        {

            Console.WriteLine("     Nhập mã nhân viên của nhân viên bạn muốn chỉnh sửa: ");
            string maNV = Console.ReadLine();

            var nhanvien = KiemTraTonTaiMaNV(maNV);

            if (nhanvien == 0)
            {
                Console.WriteLine("     Mã nhân viên này không tồn tại, bạn gõ 2 đã tiếp tục  !");
                Console.WriteLine("__________________________________________________________");

            }

            else if (nhanvien > 0)
            {
                var nv = (from NV in lNhanVien
                          where NV.SMaNV == maNV
                          select NV).First();
                Console.Write("     Tên nhân viên: ");
                String ten = Console.ReadLine();
                nv.STen = ten;
                Console.Write("     Giới tính: ");
                String gt = Console.ReadLine();
                nv.SGioiTinh = gt;

                Console.Write("     CMND: ");
                String cmnd = Console.ReadLine();
                nv.SCMND = (cmnd);

                Console.Write("     Năm sinh: ");
                int namsinh = int.Parse(Console.ReadLine());
                nv.INamSinh = (namsinh);

                Console.Write("     Địa chỉ: ");
                String dc = Console.ReadLine();
                nv.SDiaChi = (dc);

                Console.Write("     SĐT: ");
                String sdt = Console.ReadLine();
                nv.SSDT = (sdt);


                Console.WriteLine("     Thông tin nhân viên " + maNV + " đã được cập nhật !");
                Console.WriteLine("__________________________________________________________");
            }

        }

        public void searchNhanVien()
        {

            Console.WriteLine("                   ====TÌM NHÂN VIÊN====");
            Console.WriteLine("     Nhập mã nhân viên của nhân viên bạn muốn tìm: ");
            Console.WriteLine();
            string m = Console.ReadLine();


            var search = (from nv in lNhanVien
                          where nv.SMaNV == m
                          select nv).Count();

            if (search == 0)
            {
                Console.WriteLine();
                Console.WriteLine("     Mã nhân viên này không tồn tại, bạn gõ 5 đã tiếp tục TÌM !");
                Console.WriteLine("_____________________________________________________________________\n");
            }

            else
            {
                var nhanVien = (from nv in lNhanVien
                                where nv.SMaNV.Contains(m) == true
                                select nv).First();
                Console.WriteLine(
                    "    ______________________________________________________________________________________________________________");
                Console.WriteLine(
                        "    |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
                Console.WriteLine(
                        "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                Console.WriteLine("    {0,-10}{1,-25}{2,-9}{3,-12}{4,-15}{5,-28}{6,-20} ", nhanVien.SMaNV, nhanVien.STen, nhanVien.SGioiTinh, nhanVien.SCMND, nhanVien.INamSinh, nhanVien.SDiaChi, nhanVien.SSDT);
                Console.WriteLine("    ______________________________________________________________________________________________________________");
                Console.WriteLine();
            }
        }
        public void Tinhluong()
        {
            Console.WriteLine("     NHẬP MÃ NHÂN VIÊN BẠN CẦN TÍNH LƯƠNG: TV01");

            //string m = Console.ReadLine();

            //var search = (from nv in lNhanVien
            //              where nv.SMaNV == m
            //              select nv).Count();
            //if (search == 0)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("     Mã nhân viên này không tồn tại");
            //    Console.WriteLine("_____________________________________________________________________\n");
            //}

            //else
            //{
            //    var nhanVien = (from nv in lNhanVien
            //                    where nv.SMaNV.Contains(m) == true
            //                    select nv).First();

            //}
            Console.WriteLine("     NHẬP SỐ NGÀY ĐI LÀM: 28");
            Console.WriteLine("     NHẬP SỐ GIỜ TĂNG CA: 10");
            Console.WriteLine("____________________________________________\n");
            Console.WriteLine("                  BẢNG LƯƠNG\n");
            Console.WriteLine("     Tên nhân viên : Cao Mỹ Nhân");
            Console.WriteLine("     Tổng lương tháng này: 7250000 VNĐ");
        }
    }
}


