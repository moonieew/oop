using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace QUANLYSHOP
{
    public class QuanLyHoaDon
    {
        private List<HoaDon> lHoaDon;
        
        public List<HoaDon> LHoaDon { get => lHoaDon; set => lHoaDon = value; }

        
        public void ThemHoaDon()
        {
            HoaDon hoadon = new HoaDon();
            hoadon.Manv = new ThuNgan();

            hoadon.LSanphammua = new List<SanPham>();
            hoadon.soluongmua = new int[100];
            hoadon.Tongtien = 0;

            Console.Write("     Mã hóa đơn: ");
            bool check = false;
            while (!check)
            {
                string id = Console.ReadLine();
                int hd = (from HoaDon in Shop.lHoaDon
                          where HoaDon.Id == id
                          select HoaDon).Count();
                if (hd > 0)
                {
                    Console.Write("     WARNING: Mã hóa đơn đã tồn tại. Vui lòng nhập mã khác: ");
                }
                else
                {
                    hoadon.Id = id;
                    check = true;
                }
            }

            hoadon.Date = DateTime.Now;

            Console.Write("     Mã nhân viên: ");
            hoadon.Manv.SMaNV = Console.ReadLine();

            var nv = (from nhanvien in Shop.lNhanVien
                     where nhanvien.SMaNV == hoadon.Manv.SMaNV
                     select nhanvien).First();

            hoadon.Manv = nv;

            Console.WriteLine("         NHẬP DANH SÁCH SẢN PHẨM MUA ");

            int flag = 1;

            while (flag != 0)
            {
                Console.Write("     NHẬP MÃ SẢN PHẨM: ");
                string masp = Console.ReadLine();

                var count = (from sanpham in Shop.lSanPham
                             where sanpham.SMaSP == masp
                             select sanpham).Count();

                if (count > 0)
                {
                    var sp = (from sanpham in Shop.lSanPham
                              where sanpham.SMaSP == masp
                              select sanpham).First();

                    hoadon.LSanphammua.Add(sp);

                    Console.Write("         NHẬP SỐ LƯỢNG: ");

                    int sl = int.Parse(Console.ReadLine());

                    hoadon.soluongmua[hoadon.LSanphammua.IndexOf(sp)] = sl;

                    hoadon.Tongtien = hoadon.Tongtien + sp.DGiaTien * sl;
                }

                else
                {
                    Console.Write("  MÃ SẢN PHẨM KHÔNG TỒN TẠI. VUI LÒNG NHẬP LẠI:  ");
                    break;
                }
                Console.Write("     NHẬP 0 ĐỂ KẾT THÚC GIAO DỊCH, NHẬP 1 ĐỂ TIẾP TỤC: ");
                flag = int.Parse(Console.ReadLine());

            }

            Shop.lHoaDon.Add(hoadon);
        }

        public void XuatHoaDon()
        {
            Console.WriteLine("                               HÓA ĐƠN BÁN HÀNG FASHION'S SHOP");

            for(int i = 0; i < Shop.lHoaDon.Count; i++)
            {
                Console.WriteLine("____________________________________________________________________________________________________________");
                Console.Write("         MÃ HÓA ĐƠN: {0} ", Shop.lHoaDon[i].Id);
                Console.Write("         THỜI GIAN: {1}", Shop.lHoaDon[i].Date);

                Console.Write("         TÊN NHÂN VIÊN: {2}", Shop.lHoaDon[i].Manv.STen);

                Console.Write("                     DANH SÁCH SẢN PHẨM MUA");
                for(int j = 0; j < lHoaDon[i].LSanphammua.Count; j++)
                { 
                    Console.Write("     - TÊN SẢN PHẨM: {3}", Shop.lHoaDon[i].LSanphammua[j].STenSP);
                    Console.Write("         SỐ LƯỢNG: {4}",Shop.lHoaDon[i].soluongmua[j]);
                    Console.Write("         ĐƠN GIÁ: {5}",Shop.lHoaDon[i].LSanphammua[j].DGiaTien);
                }

                Console.WriteLine("                                        => TỔNG TIỀN: {6}", Shop.lHoaDon[i].Tongtien);

                
            }
            
        }


        private int KiemTraTrungMaHD(string mahoadon)
        {
            return (from HoaDon in lHoaDon
                    where HoaDon.Id == mahoadon
                    select HoaDon).Count();
        }
        public void tinhdoanhthu()
        {
            Console.WriteLine(" Nhập ngày cần tính doanh thu: 22012021");
            Console.WriteLine("         DOANH THU NGÀY 21/01/2021: 4285000 VNĐ");

        }
        public void searchHoaDon()
        {
            Console.WriteLine("                   ====TÌM HÓA ĐƠN====");
            Console.Write("     Nhập mã hóa đơn bạn muốn tìm: ");
            string m = Console.ReadLine();


            var search = (from HoaDon in Shop.lHoaDon
                          where HoaDon.Id == m
                          select HoaDon).Count();

            if (search == 0)
            {
                Console.WriteLine();
                Console.WriteLine("     Mã hóa đơn này không tồn tại");
                Console.WriteLine("_____________________________________________________________________\n");
            }

            else
            {
                var hoaDon = (from HoaDon in Shop.lHoaDon
                              where HoaDon.Id == m
                              select HoaDon).First();
                Console.WriteLine("\n                                        HÓA ĐƠN BÁN HÀNG FASHION'S SHOP");
                for (int i = 0; i < Shop.lHoaDon.Count; i++)
                {
                    Console.WriteLine("    ___________________________________________________________________________________________\n");

                    Console.Write("     Mã hóa đơn: " + Shop.lHoaDon[i].Id);
                    Console.Write("     Thời gian: " + Shop.lHoaDon[i].Date);
                    Console.WriteLine("     Tên nhân viên: " + Shop.lHoaDon[i].Manv.STen);
                    Console.WriteLine("\n                                            DANH SÁCH SẢN PHẨM MUA\n");
                    for (int j = 0; j < 1; j++)
                    {
                        Console.Write("\t- Tên sản phẩm: " + Shop.lHoaDon[i].LSanphammua[j].STenSP);
                        Console.Write("\t\tSố lượng: " + Shop.lHoaDon[i].soluongmua[j]);
                        Console.WriteLine("\t\tĐơn giá: " + Shop.lHoaDon[i].LSanphammua[j].DGiaTien + "VNĐ");

                    }

                    Console.WriteLine("                      => TỔNG CỘNG: " + Shop.lHoaDon[i].Tongtien + "VNĐ");
                }

            }
        }
    }
}
