using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYSHOP
{
    public static class Shop
    {
        public static List<NhanVien> lNhanVien = new List<NhanVien>();
        public static List<SanPham> lSanPham = new List<SanPham>();
        public static List<HoaDon> lHoaDon = new List<HoaDon>();

        public static void Add()
        {
            //Hoa don
            HoaDon hd1 = new HoaDon("HD01", DateTime.Today);
            hd1.LSanphammua = new List<SanPham>();
            hd1.soluongmua = new int[100];

            SanPham sp1 = new AoThun("AT001", "Đạo đức tốt", 10, "M", "Trắng", "AT", "Có cổ áo", 350000);
            hd1.LSanphammua.Add(sp1);
            SanPham sp2 = new AoThun("AT002", "Học tập tốt", 10, "L", "Trắng", "AT", "Có cổ áo", 350000);
            hd1.LSanphammua.Add(sp2); 
            SanPham sp3 = new AoThun("AT004", "Đạo đức tốt", 10, "M", "Đen", "AT", "Có cổ áo", 350000);

            hd1.Manv = new ThuNgan("TN01", "Lê Quỳnh Trâm Anh", 1998, "0986978673", "Quận Thủ Đức, Tp.HCM", "251274453", "TN", "Nữ", 0, 0);

            hd1.LSanphammua.Add(sp3);

            hd1.soluongmua[0] = 2;
            hd1.soluongmua[1] = 3;
            hd1.soluongmua[2] = 1;

            hd1.Tongtien = 0;

            for(int i = 0; i < hd1.LSanphammua.Count; i++)
            {
                hd1.Tongtien = hd1.Tongtien + hd1.LSanphammua[i].DGiaTien * hd1.soluongmua[i];
            }
            lHoaDon.Add(hd1);
            //HOA DON 2 

            HoaDon hd2 = new HoaDon("HD02", DateTime.Now);
            hd2.LSanphammua = new List<SanPham>();
            hd2.soluongmua = new int[100];

            SanPham sp4 = new AoThun("AT001", "Đạo đức tốt", 10, "M", "Trắng", "AT", "Có cổ áo", 350000);
            hd2.LSanphammua.Add(sp4);
            SanPham sp5 = new Quan("QUAN002", "CHINA", 6, "39", "ĐEN", "QUAN", "KAKI", 495000);
            hd2.LSanphammua.Add(sp5);
         

            hd2.Manv = new ThuNgan("TN02", "Nguyễn Đình Thái Ngân", 1997, "0984567673", "Quận Bình Thạnh, Tp.HCM", "256784453", "TN", "Nam", 0, 0);


            hd2.soluongmua[0] = 2;
            hd2.soluongmua[1] = 3;

            hd2.Tongtien = 0;

            for (int i = 0; i < hd2.LSanphammua.Count; i++)
            {
                hd2.Tongtien = hd2.Tongtien + hd2.LSanphammua[i].DGiaTien * hd2.soluongmua[i];
            }
            lHoaDon.Add(hd2);


            //áo thun
            SanPham at1 = new AoThun("AT001", "Đạo đức tốt", 10, "M", "Trắng", "AT", "Có cổ áo", 350000);
            lSanPham.Add(at1);
            SanPham at2 = new AoThun("AT002", "Học tập tốt", 10, "L", "Trắng", "AT", "Có cổ áo", 350000);
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
            lSanPham.Add(new Quan("QUAN001", "KOREA", 12, "39", "ĐEN", "QUAN", "KAKI", 495000));
            lSanPham.Add(new Quan("QUAN002", "CHINA", 16, "39", "ĐEN", "QUAN", "KAKI", 495000));
            lSanPham.Add(new Quan("QUAN003", "KOREA", 10, "40", "XAM", "QUAN", "KAKI", 495000));
            lSanPham.Add(new Quan("QUAN001", "VIETNAM", 12, "39", "ĐEN", "QUAN", "KAKI", 500000));
            lSanPham.Add(new Quan("QUAN002", "CHINA", 6, "39", "ĐEN", "QUAN", "KAKI", 495000));
            lSanPham.Add(new Quan("QUAN003", "VIETNAM", 9, "40", "XAM", "QUAN", "KAKI", 490000));


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

    }
}
