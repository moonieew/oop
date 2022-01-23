using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHOP
{
    class Program
    {
        public static void Main(string[] args)
        {
            Shop.Add();

            Console.OutputEncoding = Encoding.UTF8;
            int choose = 0;
            bool exit = false;
            while (true)
            {
                showMenu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        ThaoTacNhanVien();
                        break;
                    case 2:
                        ThaoTacSanPham();
                        break;
                    case 3:
                        ThaoTacHoaDon();
                        break;

                }
                if (exit)
                {
                    Console.WriteLine("             ==============================================");
                    Console.WriteLine("                       CẢM ƠN BẠN ĐÃ QUAN TÂM SHOP");
                    Console.WriteLine("                           HẸN GẶP LẠI LẦN SAU");
                    Console.WriteLine("             ==============================================");
                    break;
                }

            }
        }
        public static void showMenu()
        {
            Console.WriteLine("     ==========================================================================");
            Console.WriteLine("     |                    CHÀO MỪNG BẠN ĐẾN VỚI FASHION'S SHOP                |");
            Console.WriteLine("     ==========================================================================\n");
            Console.WriteLine("	                        0.Thoát");
            Console.WriteLine("	                        1.Quản lý nhân viên");
            Console.WriteLine("	                        2.Quản lý sản phẩm");
            Console.WriteLine("	                        3.Quản lý hóa đơn\n");
            Console.WriteLine("     ---------------------===BẠN MUỐN CHỌN THAO TÁC NÀO===---------------------");
            //Console.WriteLine("	3.Quản lý bán hàng");
            Console.Write("\n LỰA CHỌN CỦA BẠN LÀ: ");
        }

        public static void showMenuNhanVien()
        {
            Console.WriteLine("\n         ======== QUẢN LÝ NHÂN VIÊN ========");
            Console.WriteLine("	0.Thoát.");
            Console.WriteLine("	1.Thêm nhân viên mới");
            Console.WriteLine("	2.Cập nhật thông tin nhân viên");
            Console.WriteLine("	3.Xóa nhân viên theo mã nhân viên");
            Console.WriteLine("	4.In danh sách nhân viên");
            Console.WriteLine("	5.Tìm kiếm nhân viên theo mã nhân viên");
            Console.WriteLine("        6.Tính lương của nhân viên x");
            Console.Write("\n LỰA CHỌN CỦA BẠN LÀ: ");
        }
        public static void showMenuSanPham()
        {
            Console.WriteLine("\n         ======== QUẢN LÝ SẢN PHẨM ========");
            Console.WriteLine("	0.Thoát.");
            Console.WriteLine("	1.Thêm sản phẩm mới");
            Console.WriteLine("	2.Cập nhật số lượng sản phẩm còn trong kho");
            Console.WriteLine("	3.Xóa sản phẩm theo mã sản phẩm");
            Console.WriteLine("	4.In danh sách sản phẩm");
            Console.WriteLine("	5.Tìm kiếm sản phẩm theo mã sản phẩm");
            Console.Write("\n LỰA CHỌN CỦA BẠN LÀ: ");
        }
        public static void showMenuHoaDon()
        {
            Console.WriteLine("\n         ======== QUẢN LÝ HÓA ĐƠN ========");
            Console.WriteLine("	0.Thoát.");
            Console.WriteLine("	1.Thêm hóa đơn mới");
            Console.WriteLine("	2.In danh sách hóa đơn");
            Console.WriteLine("	3.Tìm kiếm hóa đơn");
            Console.WriteLine("	4.Tính doanh thu trong ngày a");
            Console.Write("\n LỰA CHỌN CỦA BẠN LÀ: ");
        }


        public static void ThaoTacHoaDon()
        {
            int choose = 0;
            bool exit = false;
            showMenuHoaDon();
            QuanLyHoaDon qlhd = new QuanLyHoaDon();
            while (true)
            {
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        QuanLyHoaDon listHD = new QuanLyHoaDon();
                        listHD.ThemHoaDon();
                        showMenuHoaDon();
                       break;
                    case 2:
                        Console.WriteLine("\n                                        HÓA ĐƠN BÁN HÀNG FASHION'S SHOP");
                        for (int i = 0; i < Shop.lHoaDon.Count; i++)
                        {
                            Console.WriteLine("    ___________________________________________________________________________________________\n");

                            Console.Write("     Mã hóa đơn: " + Shop.lHoaDon[i].Id);
                            Console.Write("     Thời gian: " + Shop.lHoaDon[i].Date);
                            Console.WriteLine("     Tên nhân viên: " + Shop.lHoaDon[i].Manv.STen);
                            Console.WriteLine("\n                                            DANH SÁCH SẢN PHẨM MUA\n");
                            for (int j = 0; j < Shop.lHoaDon[i].LSanphammua.Count; j++)
                            {
                                Console.Write("\t- Tên sản phẩm: " + Shop.lHoaDon[i].LSanphammua[j].STenSP);
                                Console.Write("\t\tSố lượng: " + Shop.lHoaDon[i].soluongmua[j]);
                                Console.WriteLine("\t\tĐơn giá: " + Shop.lHoaDon[i].LSanphammua[j].DGiaTien + "VNĐ");
                                
                            }

                            Console.WriteLine("                      => TỔNG CỘNG: " + Shop.lHoaDon[i].Tongtien + "VNĐ");


                        }
                        showMenuHoaDon();

                        break;

                    case 3:
                        QuanLyHoaDon list = new QuanLyHoaDon();
                        list.searchHoaDon();
                        showMenuHoaDon();
                        break;
                    case 4:
                        QuanLyHoaDon l = new QuanLyHoaDon();
                        l.tinhdoanhthu();
                        showMenuHoaDon();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn thao tác khác !");
                        showMenuHoaDon();
                        break;
                }
                if (exit)
                {
                    break;
                }

            }

        }
        public static void ThaoTacSanPham()
        {
            int choose = 0;
            bool exit = false;
            showMenuSanPham();
            QuanLySanPham qlsp = new QuanLySanPham();
            while (true)
            {
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        qlsp.addSanPham();
                        showMenuSanPham();
                        break;
                    case 2:
                        qlsp.Update();
                        showMenuSanPham();
                        break;
                    //case 3:
                    //    qlsp.;
                    //        break;
                    case 4:
                        qlsp.showSanPham();
                        showMenuSanPham();
                        break;
                    case 5:
                        qlsp.Search();
                        showMenuSanPham();
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn thao tác khác !");
                        showMenuSanPham();
                        break;
                }
                if (exit)
                {
                    break;
                }

            }
        }
        public static void ThaoTacNhanVien()
        {
            int choose = 0;
            bool exit = false;

            showMenuNhanVien();
            QuanLyNhanVien qlnv = new QuanLyNhanVien();

            while (true)
            {
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        qlnv.addNhanVien();
                        
                        showMenuNhanVien();
                        break;
                    case 2:
                        qlnv.editNhanVien();
                        showMenuNhanVien();
                        break;
                    case 3:
                        qlnv.delNhanVien();
                        showMenuNhanVien();
                        break;
                    case 4:
                        qlnv.showNhanVien();
                        showMenuNhanVien();
                        break;
                    case 5:
                        qlnv.searchNhanVien();
                        showMenuNhanVien();
                        break;
                    case 6:
                        qlnv.Tinhluong();
                        showMenuHoaDon();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng chọn thao tác khác !");
                        showMenuNhanVien();
                        break;
                }
                if (exit)
                {
                    break;
                }

            }
        }
        
    }
}
