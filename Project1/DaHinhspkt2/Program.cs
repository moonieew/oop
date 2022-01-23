using System;
using System.Collections.Generic;
using System.Text;
namespace DoHoa
{
    class Program
    {
        public static List<Hinh> LHinh = new List<Hinh>();
        public static List<List<Hinh>> GHinh = new List<List<Hinh>>();
        public static List<List<int>> chon = new List<List<int>>();
        static void Main(string[] args)
        {
            int choose = 0;
            bool exit = false;
            while (true)
            {
                showMenu();
                Console.Write("Nhap lua chon: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        NhapHinh();
                        break;
                    case 2:
                        XuatHinh();
                        break;
                    case 3:
                        GroupHinh();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }

            }
        }
        public static void showMenu()
        {
            Console.WriteLine("Chon chuc nang");
            Console.WriteLine("1. Nhap hinh");
            Console.WriteLine("2. Xuat hinh");
            Console.WriteLine("3. Cac thao tac voi hinh");
            Console.WriteLine("4. Chon lai mau sac");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("===================================================");
        }
        public static void showMenuNhapHinh()
        {
            Console.WriteLine("Nhap hinh");
            Console.WriteLine("1. Nhap duong thang");
            Console.WriteLine("2. Nhap hinh tron");
            Console.WriteLine("3. Nhap hinh chu nhat");
            Console.WriteLine("4. Nhap hinh vuong");
            Console.WriteLine("5. Nhap hinh tam giac");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("===================================================");
        }
        public static void NhapHinh()
        {
            int choose = 0;
            bool exit = false;

            //Hinh h = new Hinh();
            //h.Ve();
            while (true)
            {
                showMenuNhapHinh();
                Console.Write("Nhap lua chon: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        Hinh h1 = new DuongThang();
                        h1.Ve();
                        LHinh.Add(h1);                     
                        break;
                    case 2:
                        Hinh h2 = new HinhTron();
                        h2.Ve();
                        LHinh.Add(h2);
                        break;
                    case 3:
                        Hinh h3 = new HinhCN();
                        h3.Ve();
                        LHinh.Add(h3);
                        break;
                    case 4:
                        Hinh h4 = new HinhVuong();
                        h4.Ve();
                        LHinh.Add(h4);
                        break;
                    case 5:
                        Hinh h5 = new TamGiac();
                        h5.Ve();
                        LHinh.Add(h5);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
                if (exit)
                {
                    break;
                }
            }
        }
        public static void showMenuXuatHinh()
        {
            Console.WriteLine("Xuat hinh");
            Console.WriteLine("1. Xuat duong thang");
            Console.WriteLine("2. Xuat hinh tron");
            Console.WriteLine("3. Xuat hinh chu nhat");
            Console.WriteLine("4. Xuat hinh vuong");
            Console.WriteLine("5. Xuat hinh tam giac");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("===================================================");
        }
        public static void XuatHinh()
        {
            int choose = 0;
            bool exit = false;

            //Hinh h = new Hinh();
            //h.Ve();
            while (true)
            {
                showMenuXuatHinh();
                Console.Write("Nhap lua chon: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        for (int i = 0; i < LHinh.Count; i++)
                        {
                            if (LHinh[i].LoaiHinh == "DT")
                                LHinh[i].Xuat();
                        }
                        
                        break;
                    case 2:
                        for (int i = 0; i < LHinh.Count; i++)
                        {
                            if (LHinh[i].LoaiHinh == "HT")
                                LHinh[i].Xuat();
                        }
                        break;
                    case 3:
                        for (int i = 0; i < LHinh.Count; i++)
                        {
                            if (LHinh[i].LoaiHinh == "HCN")
                                LHinh[i].Xuat();
                        }
                        break;
                    case 4:
                        for (int i = 0; i < LHinh.Count; i++)
                        {
                            if (LHinh[i].LoaiHinh == "HV")
                                LHinh[i].Xuat();
                        }
                        break;
                    case 5:
                        for (int i = 0; i < LHinh.Count; i++)
                        {
                            if (LHinh[i].LoaiHinh == "TG")
                                LHinh[i].Xuat();
                        }
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
                if (exit)
                {
                    break;
                }

            }
        }
        public static void GroupHinh()
        {
            int choose = 0;
            bool exit = false;
            while (true)
            {
                showMenuGroupHinh();
                Console.Write("Nhap lua chon: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        groupHinh();
                        break;
                    case 2:
                        xoaGroup();
                        break;
                    case 3:
                        xuatGroup();
                        break;
                    case 4:
                        chinhSuaGroup();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ");
                        break;
                }
                if (exit)
                {
                    break;
                }
            }
        }
        public static void showMenuGroupHinh()
        {
            Console.WriteLine("1. Group hinh");
            Console.WriteLine("2. Ungroup hinh");
            Console.WriteLine("3. In group hinh theo ID");
            Console.WriteLine("4. Chinh sua group hinh");
            Console.WriteLine("===================================================");
        }
        public static void chinhSuaGroup()
        {
            int choose = 0;
            bool exit = false;
            while (true)
            {
                Console.WriteLine("0. Thoat");
                Console.WriteLine("1. Xoa tung hinh trong group");
                Console.WriteLine("2. Di chuyen hinh");
                Console.Write("Nhap lua chon: ");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        xoaTungHinh();
                        break;
                    case 2:
                        diChuyen();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le");
                        break;
                }
                if (exit)
                {
                    break;
                }
            }
        }
        public static void groupHinh()
        {
            Console.WriteLine("Danh sach hinh: ");
            for(int i = 0; i< LHinh.Count;i++)
            {
                Console.WriteLine("===================================================");
                Console.WriteLine("| id = " + i + "  loai: " + LHinh[i].LoaiHinh + " Mau: "+LHinh[i].MauSac+"||");
                Console.WriteLine("===================================================" );
            }
            List<Hinh> listChild = new List<Hinh>() ;
            List<int> chonChild = new List<int>();
            Console.WriteLine("Vui Long chon Hinh can Group");
            Console.WriteLine("Chon -1 la ngung chon");
            int exit = 1;
            while (exit != -1)
            {
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp == -1)
                    break;
                chonChild.Add(temp);
                //listChild.Add(LHinh[temp]);
                

                // Console.WriteLine(listChild.Count);
            }
            chon.Add(chonChild);
            //GHinh.Add(listChild);
            Console.WriteLine("-----------"+GHinh.Count);
            
            for(int i = 0; i < chon.Count; i++)
                {
                Console.WriteLine("============================================"+i);
                for (int j = 0; j < chon[i].Count; j++)
                    {
                        
                        Console.WriteLine("| Group = " + i + " id: " + j + "  loai: " + LHinh[chon[i][j]].LoaiHinh + " Mau: "+ LHinh[chon[i][j]].MauSac + "||");
                    
                    }
            }
            //listChild.Clear();
            //chon.Clear();
        }
        public static void xuatGroup()
        {
            Console.Write("Nhap ID group can xuat:");
            int t = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("============================================ Group new : " + t);
                for (int j = 0; j < chon[t].Count; j++)
                {

                    Console.WriteLine("| Group = " + t + " id: " + j + "  loai: " + LHinh[chon[t][j]].LoaiHinh + " Mau: " + LHinh[chon[t][j]].MauSac + "||");

                }
            }
            catch
            {
                Console.WriteLine("ID group khong hop le");
            }
        }
        public static void xoaGroup()
        {
            Console.Write("Nhap ID group can xoa:");
            int t = int.Parse(Console.ReadLine());
            try
            {
                chon.Remove(chon[t]);
            }
            catch
            {
                Console.WriteLine("ID group khong hop le");
            }
        }
        public static void xoaTungHinh()
        {
            Console.Write("Nhap ID group co hinh can xoa:");
            int t = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("============================================ Group new : " + t);
                for (int j = 0; j < chon[t].Count; j++)
                {

                    Console.WriteLine("| Group = " + t + " id: " + j + "  loai: " + LHinh[chon[t][j]].LoaiHinh + " Mau: " + LHinh[chon[t][j]].MauSac + "||");

                }
                Console.Write("Nhap ID hinh can xoa: ");
                int x = int.Parse(Console.ReadLine());
                chon[t].Remove(chon[t][x]);
            }
            catch
            {
                Console.WriteLine("ID group khong hop le");
            }
            Console.WriteLine("Group hinh moi");
            for (int j = 0; j < chon[t].Count; j++)
            {

                Console.WriteLine("| Group = " + t + " id: " + j + "  loai: " + LHinh[chon[t][j]].LoaiHinh + " Mau: " + LHinh[chon[t][j]].MauSac + "||");

            }
        }
        public static void diChuyen()
        {
            Console.Write("Nhap ID group co hinh can di chuyen:");
            int t = int.Parse(Console.ReadLine());
            int y=-1;
            try
            {

                Console.WriteLine("============================================ Group new : " + t);
                for (int j = 0; j < chon[t].Count; j++)
                {
                       Console.WriteLine("| Group = " + t + " id: " + j + "  loai: " + LHinh[chon[t][j]].LoaiHinh + " Mau: " + LHinh[chon[t][j]].MauSac + "||");

                }
                Console.Write("Nhap ID hinh can di chuyen: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Nhap ID Group di chuyen toi: ");
                y = int.Parse(Console.ReadLine());
                chon[y].Add(chon[t][x]);
                chon[t].Remove(chon[t][x]);

            }
            catch
            {
                Console.WriteLine("ID group hoac ID hinh khong hop le");
            }
            Console.WriteLine("Group hinh moi");
            for (int j = 0; j < chon[y].Count; j++)
            {

                Console.WriteLine("| Group = " + t + " id: " + j + "  loai: " + LHinh[chon[y][j]].LoaiHinh + " Mau: " + LHinh[chon[y][j]].MauSac + "||");

            }
                      
            
            
        }
    }
}
