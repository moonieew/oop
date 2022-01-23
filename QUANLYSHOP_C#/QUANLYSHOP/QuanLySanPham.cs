using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QUANLYSHOP
{
    public class QuanLySanPham
    {
        private List<SanPham> lSanPham;
        public List<SanPham> LSanPham { get => lSanPham; set => lSanPham = value; }

        /// <summary>
        /// Hàm dùng để nhập thông tin cho 1 sản phẩm mới
        /// </summary>
        private AoSomi ThemAoSoMi()
        {
            Console.Write("     Mã sản phẩm: ");
            String SMaSP = Console.ReadLine();
            int nv = KiemTraTrungMaSP(SMaSP);

            while (nv > 0)
            {
                Console.Write("     WARNING: Mã sản phẩm đã tồn tại. Vui lòng nhập mã khác");
                SMaSP = Console.ReadLine();
                nv = KiemTraTrungMaSP(SMaSP);

            }

            Console.Write("     Tên sản phẩm: ");
            String STenSP = Console.ReadLine();

            Console.Write("     Màu sản phẩm: ");
            String SMau = Console.ReadLine();

            Console.Write("     Loại tay áo: ");
            String SLoaiTayAo = Console.ReadLine();

            Console.Write("     Size: ");
            String SSize = Console.ReadLine();

            Console.Write("     Số lượng: ");
            int ISoluong = int.Parse(Console.ReadLine());

            Console.Write("     Giá tiền: ");
            double DGiaTien = double.Parse(Console.ReadLine());

            AoSomi sp = new AoSomi(SMaSP, STenSP, ISoluong, SSize, SMau, "ASM", SLoaiTayAo, DGiaTien);
            return sp;
        }
        private int KiemTraTrungMaSP(string masp)
        {
            return (from sanpham in lSanPham
                    where sanpham.SMaSP == masp
                    select sanpham).Count();
        }

        private AoThun ThemAoThun()
        {
            Console.Write("     Mã sản phẩm: ");
            String SMaSP = Console.ReadLine();
            int nv = KiemTraTrungMaSP(SMaSP);

            while (nv > 0)
            {
                Console.WriteLine("     WARNING: Mã sản phẩm đã tồn tại. Vui lòng nhập mã khá");
                SMaSP = Console.ReadLine();
                nv = KiemTraTrungMaSP(SMaSP);

            }
            Console.Write("     Tên sản phẩm: ");
            String STenSP = Console.ReadLine();

            Console.Write("     Màu sản phẩm: ");
            String SMau = Console.ReadLine();

            Console.Write("     Size: ");
            String SSize = Console.ReadLine();

            Console.Write("     Loại cổ áo: ");
            String SLoaiCoAo = Console.ReadLine();

            Console.Write("     Số lượng: ");
            int ISoluong = int.Parse(Console.ReadLine());
            Console.Write("     Giá tiền: ");
            double DGiaTien = double.Parse(Console.ReadLine());

            AoThun sp = new AoThun(SMaSP, STenSP, ISoluong, SSize, SMau, "AT", SLoaiCoAo, DGiaTien);
            return sp;
        }
        private Quan ThemQuan()
        {
            Console.Write("     Mã sản phẩm: ");
            String SMaSP = Console.ReadLine();
            int nv = KiemTraTrungMaSP(SMaSP);

            while (nv > 0)
            {
                Console.Write("     WARNING: Mã quần đã tồn tại.Vui lòng nhập mã khác ");
                SMaSP = Console.ReadLine();
                nv = KiemTraTrungMaSP(SMaSP);

            }
            Console.Write("     Tên sản phẩm: ");
            String STenSP = Console.ReadLine();

            Console.Write("     Màu sản phẩm: ");
            String SMau = Console.ReadLine();

            Console.Write("     Size: ");
            String SSize = Console.ReadLine();

            Console.Write("     Loại quần: ");
            String SLoaiQuan = Console.ReadLine();

            Console.Write("     Số lượng: ");
            int ISoluong = int.Parse(Console.ReadLine());
            Console.Write("     Giá tiền: ");
            double DGiaTien = double.Parse(Console.ReadLine());

            Quan sp = new Quan(SMaSP, STenSP, ISoluong, SSize, SMau, "QUAN", SLoaiQuan,DGiaTien);
            return sp;
        }
        public void addSanPham()
        {

            Console.WriteLine("         THÔNG TIN SẢN PHẨM MỚI ");
            int choose = -1;// int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("     ---VUI LÒNG CHỌN LOẠI SẢN PHẨM---");
                Console.WriteLine("             Áo Thun: 1");
                Console.WriteLine("             Áo Sơmi: 2");
                Console.WriteLine("             Quần   : 3");
                Console.Write("\n LỰA CHỌN CỦA BẠN LÀ: ");
                choose = int.Parse(Console.ReadLine());
                if (choose < 0 || choose > 3)
                {
                    Console.WriteLine("___Loại sản phẩm không hợp lệ. Mời bạn nhập lại___");
                }    
            }
            while (choose<0 || choose > 3);

            switch (choose)
            {
                case 1:
                    AoThun at = ThemAoThun();
                    LSanPham.Add(at);
                    break;
                case 2:
                    AoSomi asm = ThemAoSoMi();
                    LSanPham.Add(asm);
                    break;
                case 3:
                    Quan quan = ThemQuan();
                    LSanPham.Add(quan);
                    break;
                default:
                    break;
        }

        }
        public QuanLySanPham()
        {
            lSanPham = new List<SanPham>();
            //áo thun
            SanPham at1 = new AoThun("AT001", "DAO DUC TOT", 10, "M", "Trắng", "AT", "Có cổ áo", 350000);
            lSanPham.Add(at1);
            SanPham at2 = new AoThun("AT002", "HOC TAP TOT", 10, "L", "Trắng", "AT", "Có cổ áo", 350000);
            lSanPham.Add(at2);
            SanPham at3 = new AoThun("AT003", "Đạo đức tốt", 10, "XL", "Trắng", "AT", "Không cổ áo", 300000);
            lSanPham.Add(at3);
            SanPham at4 = new AoThun("AT004", "Đạo đức tốt", 10, "M", "Đen", "AT", "Có cổ áo", 350000);
            lSanPham.Add(at4);
            SanPham at5 = new AoThun("AT005", "Thể lực tốt", 10, "L", "Đen", "AT", "Có cổ áo", 350000);
            lSanPham.Add(at5);
            SanPham at6 = new AoThun("AT006", "Hội nhập tốt", 10, "XL", "Đen", "AT", "Có cổ áo", 350000);
            lSanPham.Add(at6);
            SanPham at7 = new AoThun("AT007", "Học tập tốt", 10, "M", "Trắng", "AT", "Có cổ áo", 350000);
            lSanPham.Add(at7);
            SanPham at8 = new AoThun("AT008", "Thể lực tốtt", 10, "L", "Trắng", "AT", "Không cổ áo", 300000);
            lSanPham.Add(at8);
            SanPham at9 = new AoThun("AT009", "Học tập tốt", 10, "XL", "Trắng", "AT", "Không cổ áo", 300000);
            lSanPham.Add(at9);
            SanPham at10 = new AoThun("AT010", "Học tập tốt", 10, "M", "Đen", "AT", "Có cổ áo", 350000);
            lSanPham.Add(at10);
            SanPham at11 = new AoThun("AT011", "Thể lực tốt", 10, "L", "Đen", "AT", "Không cổ áo", 350000);
            lSanPham.Add(at11);
            SanPham at12 = new AoThun("AT012", "Học tập tốt", 10, "XL", "Đen", "AT", "Không cổ áo", 300000);
            lSanPham.Add(at12);

            //Áo Sơmi
            SanPham asm1 = new AoSomi("ASM001", "Thể lực tốt", 5, "M", "Trắng", "ASM", "Dài tay", 350000);
            lSanPham.Add(asm1);
            lSanPham.Add(new AoSomi("ASM002", "Thể lực tốt", 5, "M", "Đen", "ASM", "Ngắn tay", 300000));
            lSanPham.Add(new AoSomi("ASM003", "Thể lực tốt", 5, "M", "Vàng", "ASM", "Dài tay", 350000));
            lSanPham.Add(new AoSomi("ASM004", "Thể lực tốt", 5, "L", "Cam", "ASM", "Ngắn tay", 300000));
            lSanPham.Add(new AoSomi("ASM005", "Thể lực tốt", 5, "S", "Lục", "ASM", "Dài tay", 350000));
            lSanPham.Add(new AoSomi("ASM006", "Thể lực tốt", 5, "M", "Lam", "ASM", "Ngắn tay", 300000));
            lSanPham.Add(new AoSomi("ASM007", "Thể lực tốt", 5, "M", "Trắng", "ASM", "Dài tay", 350000));
            lSanPham.Add(new AoSomi("ASM008", "Thể lực tốt", 5, "L", "Trắng", "ASM", "Ngắn tay", 300000));
            lSanPham.Add(new AoSomi("ASM009", "Thể lực tốt", 5, "M", "Trắng", "ASM", "Dài tay", 350000));
            lSanPham.Add(new AoSomi("ASM010", "Thể lực tốt", 5, "S", "Trắng", "ASM", "Ngắn tay", 300000));

            //Quần
            lSanPham.Add(new Quan("QUAN001", "KOREA", 12, "39", "ĐEN", "QUAN", "KAKI" , 495000));
            lSanPham.Add(new Quan("QUAN002", "CHINA", 16, "39", "ĐEN", "QUAN", "KAKI", 495000));
            lSanPham.Add(new Quan("QUAN003", "KOREA", 10, "40", "XAM", "QUAN", "KAKI", 495000));
            lSanPham.Add(new Quan("QUAN001", "VIETNAM", 12, "39", "ĐEN", "QUAN", "KAKI", 500000));
            lSanPham.Add(new Quan("QUAN002", "CHINA", 6, "39", "ĐEN", "QUAN", "KAKI", 495000));
            lSanPham.Add(new Quan("QUAN003", "VIETNAM", 9, "40", "XAM", "QUAN", "KAKI", 490000));

            
        }

        public void showSanPham()
        {

            Console.WriteLine("____Chọn danh sách: ");
            Console.WriteLine("	0.Toàn bộ sản phẩm");
            Console.WriteLine("	1. Áo thun");
            Console.WriteLine("	2. Áo sơ mi");
            Console.WriteLine("	3. Quần");
            Console.Write("\n LỰA CHỌN CỦA BẠN LÀ: ");
            int ch = 0;
            ch = int.Parse(Console.ReadLine());
  
            switch (ch)
            {
                case 0:
                    showAllSanPham();
                    break;
                case 1:
                    showAoThun();
                    break;
                case 2:
                    showAoSoMi();
                    break;
                case 3:
                    showQuan();
                    break;
                default:
                    break;
            }
        }

        public void showAllSanPham()
        {
            Console.WriteLine("                                  DANH SÁCH TẤT CẢ SẢN PHẨM FASHION'S SHOP");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________\n");
            Console.WriteLine(
                    "    |STT    |Mã SP|    Tên Sản phẩm        |Số lượng|   Size     |Màu sắc|        Thuộc tính  |Giá bán|\n");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            int i = 1;
            foreach (var sp in LSanPham)
            {
                Console.Write("     {0,-3}", i++);
                sp.ShowInfo();
            }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();
        }

        public void showAoThun()
        {
            Console.WriteLine("                                  DANH SÁCH ÁO THUN FASHION'S SHOP");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________\n");
            Console.WriteLine(
                    "    |STT    |Mã SP|    Tên Sản phẩm        |Số lượng|   Size     |Màu sắc|        Thuộc tính  |Giá bán|\n");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            int i = 1;
            foreach (var sp in LSanPham)
                if (sp.SLoaiSP.Equals("AT"))
                {
                    Console.Write("     {0,-5}", i++);
                    (sp as AoThun).ShowInfo();
                }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();
        }

        public void showAoSoMi()
        {
            Console.WriteLine("                                  DANH SÁCH ÁO SƠ MI FASHION'S SHOP");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________\n");
            Console.WriteLine(
                    "    |STT    |Mã SP|    Tên Sản phẩm        |Số lượng|   Size     |Màu sắc|        Thuộc tính  |Giá bán|\n");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            int i = 1;
            foreach (var sp in LSanPham)
                if (sp.SLoaiSP.Equals("ASM"))
                {
                    Console.Write("     {0,-5}", i++);
                    (sp as AoSomi).ShowInfo();
                }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();
        }
        public void showQuan()
        {
            Console.WriteLine("                                  DANH SÁCH QUẦN FASHION'S SHOP");
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________\n");
            Console.WriteLine(
                    "    |STT    |Mã SP|    Tên Sản phẩm        |Số lượng|   Size     |Màu sắc|        Thuộc tính  |Giá bán|\n");
            Console.WriteLine(
                    "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            int i = 1;
            foreach (var sp in LSanPham)
                if (sp.SLoaiSP.Equals("QUAN"))
                {
                    Console.Write("     {0,-5}", i++);
                    (sp as Quan).ShowInfo();
                }
            Console.WriteLine(
                    "    ____________________________________________________________________________________________________________________");
            Console.WriteLine();

        }
        

        public void Search()
        {
            Console.WriteLine("              ***TÌM SẢN PHẨM ***");
            while (true)
            {
                Console.WriteLine("     Nhập mã sản phẩm của sản phẩm bạn muốn tìm: ");
                Console.WriteLine();
                String sMaSP = Console.ReadLine();
                try
                {
                    SanPham sanpham = (from sp in lSanPham
                                       where sp.SMaSP == sMaSP
                                       select sp).First();
                    if (sanpham != null)
                    {

                        Console.WriteLine(
                                "    ____________________________________________________________________________________________________________________\n");
                        Console.WriteLine(
                                "    |STT    |Mã SP|    Tên Sản phẩm        |Số lượng|   Size     |Màu sắc|        Thuộc tính  |Giá bán|\n");
                        Console.WriteLine(
                                "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

                        sanpham.ShowInfo();
                        Console.WriteLine(
                            "    ____________________________________________________________________________________________________________________");
                        Console.WriteLine();
                        if (TiepTucTimKiem() == false) return;
                    }
                    else
                    {
                        Console.WriteLine(" Mã sản phẩm này không tồn tại!");
                        if (TiepTucTimKiem() == false) return;
                    }
                }
                catch
                {
                    Console.WriteLine(" Mã sản phẩm này không tồn tại");
                    if (TiepTucTimKiem() == false) return;
                }
            }    
            
        }

        public void Update()
        {
            Console.WriteLine("                 ***TÌM SẢN PHẨM ***");
            while (true)
            {
                Console.WriteLine("Nhập mã sản phẩm của sản phẩm bạn muốn tìm: ");
                Console.WriteLine();
                String sMaSP = Console.ReadLine();
                try
                {
                    SanPham sanpham = (from sp in lSanPham
                                       where sp.SMaSP == sMaSP
                                       select sp).First();
                    if (sanpham != null)
                    {
                        sanpham.Update();
                        Console.WriteLine(
                                "    ____________________________________________________________________________________________________________________\n");
                        Console.WriteLine(
                                "    |STT    |Mã SP|    Tên Sản phẩm        |Số lượng|   Size     |Màu sắc|        Thuộc tính  |Giá bán|\n");
                        Console.WriteLine(
                                "    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

                        sanpham.ShowInfo();
                        Console.WriteLine(
                            "    ____________________________________________________________________________________________________________________");
                        Console.WriteLine();
                        if (TiepTucTimKiem() == false) return;
                    }
                    else
                    {
                        Console.WriteLine("     Mã sản phẩm này không tồn tại!");
                        if (TiepTucTimKiem() == false) return;
                    }
                }
                catch
                {
                    Console.WriteLine("     Mã sản phẩm này không tồn tại");
                    if (TiepTucTimKiem()==false) return;
                }
            }

        }

        private bool TiepTucTimKiem()
        {
            Console.WriteLine("     Nhập số bất kỳ để tiếp tục, nhập 0 để thoát!");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value != 0)
            {
                Console.WriteLine("__________________________________________________________\n");
                return true;
            }
            return false;
        }
    }
}
