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
		KhachHangs.add(new KhachHang("KH01", "A", "QUẬN 7", "VIP", "123456789"));
		KhachHangs.add(new KhachHang("KH02", "B", "QUẬN 6", "VIP", "123456789"));
		KhachHangs.add(new KhachHang("KH03", "C", "THỦ ĐỨC", "VIP", "123456789"));
		KhachHangs.add(new KhachHang("KH04", "D", "BÌNH THẠNH", "THÂN THIẾT", "02344484848"));
		KhachHangs.add(new KhachHang("KH05", "E", "QUẬN 9", "THÀNH VIÊN", "0982478136"));
		KhachHangs.add(new KhachHang("KH06", "F", "QUẬN 3", "THÀNH VIÊN", "0982325136"));
	}

	public static void showMenu()
	{
		System.out.println("--------- HÃY CÙNG SHIN QUẢN LÝ CỬA HÀNG NÀO ^^ ---------");
		System.out.println("	0.Thoát.");
		System.out.println("	1.Quản lý nhân viên nhà SHIN");
		System.out.println("	2.Quản lý sản phẩm nhà SHIN");
		System.out.println("	3.Quản lý bán hàng");
		System.out.println("Chọn thao tác nào !");
		System.out.println("****************************************************************************************");
	}

	public static void showMenuNhanVien()
	{
		System.out.println("--------- HÃY CÙNG SHIN QUẢN LÝ NHÂN VIÊN CỬA HÀNG NÀO ^^ ---------");
		System.out.println("	0.Thoát.");
		System.out.println("	1.Thêm nhân viên mới");
		System.out.println("	2.Cập nhật thông tin nhân viên");
		System.out.println("	3.Xóa nhân viên theo mã nhân viên");
		System.out.println("	4.In danh sách nhân viên");
		System.out.println("	5.Tìm kiếm nhân viên");
	}

	public static void showMenuSanPham()
	{
		System.out.println("--------- HÃY CÙNG SHIN QUẢN LÝ SẢN PHẨM CỬA HÀNG NÀO ^^ ---------");
		System.out.println("	0.Thoát.");
		System.out.println("	1.Danh sách sản phẩm");
		System.out.println("	2.Danh sách nơi cung cấp hàng");
		System.out.println("	3.Danh sách phiếu bảo hành");
		System.out.println("	4.Danh sách hóa đơn nhập hàng");
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
				System.out.println("Lựa chọn không hợp lệ! Vui lòng chọn thao tác khác !");
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
				System.out.println("Lựa chọn không hợp lệ! Vui lòng chọn thao tác khác !");
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
				System.out.println("chưa xong");
				break;
			default:
				System.out.println("Lựa chọn không hợp lệ! Vui lòng chọn thao tác khác !");
				break;
			}
			if (exit)
			{
				System.out.println("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				System.out.println("SHIN rất vui vì đã giúp đỡ bạn ^^");
				System.out.println("Hẹn gặp lại lần sau");
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