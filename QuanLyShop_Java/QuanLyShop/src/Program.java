import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Program
{
	public static List<NhanVien> NhanViens = new ArrayList<NhanVien>();
	public static List<NoiCungCap> NoiCungCaps = new ArrayList<NoiCungCap>();
	public static List<HDNhapHang> HDNhapHangs = new ArrayList<HDNhapHang>();
	public static List<SanPham> SanPhams = new ArrayList<SanPham>();
	public static List<PhieuBaoHanh> PhieuBaoHanhs = new ArrayList<PhieuBaoHanh>();
	public static List<ChiTietHDMuaBan> ChiTietHDMuaBans = new ArrayList<ChiTietHDMuaBan>();
	public static List<HoaDonMuaBan> HoaDonMuaBans = new ArrayList<HoaDonMuaBan>();
	public static List<KhachHang> KhachHangs = new ArrayList<KhachHang>();
	public static List<PhieuThu> PhieuThus = new ArrayList<PhieuThu>();

	public static void TaoDanhSachHoaDonMuaBan()
	{
		KhachHang tamkh = new KhachHang();
		NhanVien tamnv = new TuVan();
		for (KhachHang kh : KhachHangs)
			if (kh.getsMaKhachHang() == "KH01")
				tamkh = kh;
		for (NhanVien nv : NhanViens)
			if (nv.getMaNV() == "TV01")
				tamnv = nv;
		HoaDonMuaBans.add(new HoaDonMuaBan("HDMB01", new SimpleDateFormat("04/05/2019"), 3000000, 10, true, "KH01",
				tamkh, tamnv));
		for (KhachHang kh : KhachHangs)
			if (kh.getsMaKhachHang() == "KH01")
				tamkh = kh;
		for (NhanVien nv : NhanViens)
			if (nv.getMaNV() == "TV02")
				tamnv = nv;
		HoaDonMuaBans.add(new HoaDonMuaBan("HDMB02", new SimpleDateFormat("04/10/2019"), 5000000, 10, false, "KH01",
				tamkh, tamnv));
		for (KhachHang kh : KhachHangs)
			if (kh.getsMaKhachHang() == "KH03")
				tamkh = kh;
		for (NhanVien nv : NhanViens)
			if (nv.getMaNV() == "TV02")
				tamnv = nv;
		HoaDonMuaBans.add(new HoaDonMuaBan("HDMB03", new SimpleDateFormat("04/11/2019"), 10000000, 10, false, "KH03",
				tamkh, tamnv));
		for (KhachHang kh : KhachHangs)
			if (kh.getsMaKhachHang() == "KH04")
				tamkh = kh;
		for (NhanVien nv : NhanViens)
			if (nv.getMaNV() == "TV02")
				tamnv = nv;
		HoaDonMuaBans.add(new HoaDonMuaBan("HDMB04", new SimpleDateFormat("13/11/2019"), 20000000, 10, false, "KH04",
				tamkh, tamnv));
	}

	public static void TaoDanhSachChiTietHDMuaBan()
	{
		HoaDonMuaBan hdmb = new HoaDonMuaBan();
		for (HoaDonMuaBan hd : HoaDonMuaBans)
			if (hd.getsMaHDMuaBan() == "HDMB01")
				hdmb = hd;
		ChiTietHDMuaBans.add(new ChiTietHDMuaBan("CTHDMB01", 10, SanPhams.get(0), "HDMB01", hdmb));
		for (HoaDonMuaBan hd : HoaDonMuaBans)
			if (hd.getsMaHDMuaBan() == "HDMB01")
				hdmb = hd;
		ChiTietHDMuaBans.add(new ChiTietHDMuaBan("CTHDMB02", 10, SanPhams.get(1), "HDMB01", hdmb));
		for (HoaDonMuaBan hd : HoaDonMuaBans)
			if (hd.getsMaHDMuaBan() == "HDMB02")
				hdmb = hd;
		ChiTietHDMuaBans.add(new ChiTietHDMuaBan("CTHDMB03", 25, SanPhams.get(2), "HDMB02", hdmb));
		for (HoaDonMuaBan hd : HoaDonMuaBans)
			if (hd.getsMaHDMuaBan() == "HDMB02")
				hdmb = hd;
		ChiTietHDMuaBans.add(new ChiTietHDMuaBan("CTHDMB04", 11, SanPhams.get(3), "HDMB02", hdmb));
		for (HoaDonMuaBan hd : HoaDonMuaBans)
			if (hd.getsMaHDMuaBan() == "HDMB03")
				hdmb = hd;
		ChiTietHDMuaBans.add(new ChiTietHDMuaBan("CTHDMB05", 20, SanPhams.get(4), "HDMB03", hdmb));
		for (HoaDonMuaBan hd : HoaDonMuaBans)
			if (hd.getsMaHDMuaBan() == "HDMB04")
				hdmb = hd;
		ChiTietHDMuaBans.add(new ChiTietHDMuaBan("CTHDMB06", 17, SanPhams.get(4), "HDMB04", hdmb));

	}

	public static void TaoDanhSachKhachHang()
	{
		KhachHangs.add(new KhachHang("KH01", "A", "QU???N 7", "VIP", "123456789"));
		KhachHangs.add(new KhachHang("KH02", "B", "QU???N 6", "VIP", "123456789"));
		KhachHangs.add(new KhachHang("KH03", "C", "TH??? ?????C", "VIP", "123456789"));
		KhachHangs.add(new KhachHang("KH04", "D", "B??NH TH???NH", "TH??N THI???T", "02344484848"));
		KhachHangs.add(new KhachHang("KH05", "E", "QU???N 9", "TH??NH VI??N", "0982478136"));
		KhachHangs.add(new KhachHang("KH06", "F", "QU???N 3", "TH??NH VI??N", "0982325136"));
	}

	public static void showMenu()
	{
		System.out.println("--------- H??Y C??NG SHIN QU???N L?? C???A H??NG N??O ^^ ---------");
		System.out.println("	0.Tho??t.");
		System.out.println("	1.Qu???n l?? nh??n vi??n nh?? SHIN");
		System.out.println("	2.Qu???n l?? s???n ph???m nh?? SHIN");
		System.out.println("	3.Qu???n l?? b??n h??ng");
		System.out.println("Ch???n thao t??c n??o !");
		System.out.println("****************************************************************************************");
	}

	public static void showMenuNhanVien()
	{
		System.out.println("--------- H??Y C??NG SHIN QU???N L?? NH??N VI??N C???A H??NG N??O ^^ ---------");
		System.out.println("	0.Tho??t.");
		System.out.println("	1.Th??m nh??n vi??n m???i");
		System.out.println("	2.C???p nh???t th??ng tin nh??n vi??n");
		System.out.println("	3.X??a nh??n vi??n theo m?? nh??n vi??n");
		System.out.println("	4.In danh s??ch nh??n vi??n");
		System.out.println("	5.T??m ki???m nh??n vi??n");
	}

	public static void showMenuSanPham()
	{
		System.out.println("--------- H??Y C??NG SHIN QU???N L?? S???N PH???M C???A H??NG N??O ^^ ---------");
		System.out.println("	0.Tho??t.");
		System.out.println("	1.Danh s??ch s???n ph???m");
		System.out.println("	2.Danh s??ch n??i cung c???p h??ng");
		System.out.println("	3.Danh s??ch phi???u b???o h??nh");
		System.out.println("	4.Danh s??ch h??a ????n nh???p h??ng");
	}

	public static void ThaoTacNhanVien()
	{
		int choose = 0;
		boolean exit = false;
		Scanner sc = new Scanner(System.in);
		showMenuNhanVien();
		QuanLyNhanVien qlnv = new QuanLyNhanVien();
		qlnv.KhoiTaoNhanVien();
		while (true) {
			choose = sc.nextInt();
			switch (choose) {
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
			default:
				System.out.println("L???a ch???n kh??ng h???p l???! Vui l??ng ch???n thao t??c kh??c !");
				showMenuNhanVien();
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
		boolean exit = false;
		Scanner sc = new Scanner(System.in);
		QuanLySanPham qlsp = new QuanLySanPham();
		QuanLySanPham.TaoDanhSachNoiCungCap();
		QuanLySanPham.TaoDanhSachHDNhapHang();
		QuanLySanPham.TaoDanhSachSanPham();
		QuanLySanPham.TaoDanhSachPhieuBaoHanh();
		while (true) {
			choose = sc.nextInt();
			switch (choose) {
			case 0:
				exit = true;
				break;
			case 1:
				qlsp.showSanPhams();
				showMenuSanPham();
				break;
			case 2:
				// qlsp.showNoiCungCaps();
				showMenuSanPham();
				break;
			case 3:
				// qlsp.showPhieuBaoHanh();
				showMenuSanPham();
				break;
			case 4:
				// qlsp.showHoaDonNhapHang();
				showMenuSanPham();
				break;
			default:
				System.out.println("L???a ch???n kh??ng h???p l???! Vui l??ng ch???n thao t??c kh??c !");
				showMenuSanPham();
				break;
			}
			if (exit)
			{
				break;
			}
		}
	}

	public static void main(String[] args)
	{
		int choose = 0;
		boolean exit = false;
		Scanner sc = new Scanner(System.in);

		while (true) {
			showMenu();
			choose = sc.nextInt();
			switch (choose) {
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
				ThaoTacMuaBan();
				System.out.println("ch??a xong");
				break;
			default:
				System.out.println("L???a ch???n kh??ng h???p l???! Vui l??ng ch???n thao t??c kh??c !");
				break;
			}
			if (exit)
			{
				System.out.println("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				System.out.println("SHIN r???t vui v?? ???? gi??p ????? b???n ^^");
				System.out.println("H???n g???p l???i l???n sau");
				System.out.println("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				break;
			}
		}
	}

	private static void ThaoTacMuaBan()
	{
		
		// @@@@@@@
	}
}