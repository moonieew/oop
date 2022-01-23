import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.List;

public class QuanLySanPham {
	public static List<SanPham> SanPhams;
	public static List<HDNhapHang> HDNhapHangs = new ArrayList<HDNhapHang>();
	public static List<NoiCungCap> NoiCungCaps = new ArrayList<NoiCungCap>();
	public static List<PhieuBaoHanh> PhieuBaoHanhs = new ArrayList<PhieuBaoHanh>();

	protected static List<SanPham> getSanPhams() {
		return SanPhams;
	}

	protected static void setSanPhams(List<SanPham> sanPhams) {
		SanPhams = sanPhams;
	}

	public QuanLySanPham() {
		super();

	}

	public static void TaoDanhSachSanPham() {
		SanPham sp = new SanPham("SP01", "CAI", "NIKE", HDNhapHangs.get(0));
		SanPhams.add(sp);
		//SanPhams.add(new SanPham("SP02", "CAI", "ADIDAS", HDNhapHangs.get(1)));
		//SanPhams.add(new SanPham("SP03", "chiec", "TOMY", HDNhapHangs.get(2)));
		//SanPhams.add(new SanPham("SP04", "chiec", "ITALY", HDNhapHangs.get(3)));
		//SanPhams.add(new SanPham("SP05", "chiec", "PARIS", HDNhapHangs.get(4)));
		//SanPhams.add(new SanPham("SP06", "chiec", "CONVER", HDNhapHangs.get(5)));
	}

	public static void TaoDanhSachNoiCungCap() {
		NoiCungCaps.add(new NoiCungCap("SS01", "ANH BA", "QUAN JEAN", "012345678", "ANHBA@gmail.com"));
		NoiCungCaps.add(new NoiCungCap("SS02", "CHI HAI", "AO THUN", "9756433562", "CHIHAI@gmail.com"));
		NoiCungCaps.add(new NoiCungCap("AA01", "ANH MUOI", "AO SO MI", "0465465456", "ANHMUOI@gmail.com"));
		NoiCungCaps.add(new NoiCungCap("AA02", "ANH SAU", "THAT LUNG", "0465465456", "hANH SAU@gmail.com"));
		NoiCungCaps.add(new NoiCungCap("CC01", "HA NOI 1", "AO KHOAC", "0865462132132", "hanoi1@gmail.com"));
		NoiCungCaps.add(new NoiCungCap("CC02", "HA NOI 2", "GIAY", "08564564561", "hanoi2@gmail.com"));
	}

	public static void TaoDanhSachPhieuBaoHanh() {
		PhieuBaoHanh pbh = new PhieuBaoHanh("PBH01", new SimpleDateFormat("10/04/2019"), 6, SanPhams.get(0));
		PhieuBaoHanhs.add(pbh);
		//PhieuBaoHanhs.add(new PhieuBaoHanh("PBH02", new SimpleDateFormat("10/07/2019"), 12, SanPhams.get(1)));
		//PhieuBaoHanhs.add(new PhieuBaoHanh("PBH03", new SimpleDateFormat("10/10/2019"), 24, SanPhams.get(2)));
		//PhieuBaoHanhs.add(new PhieuBaoHanh("PBH04", new SimpleDateFormat("10/01/2019"), 6, SanPhams.get(3)));
		//PhieuBaoHanhs.add(new PhieuBaoHanh("PBH05", new SimpleDateFormat("20/02/2019"), 18, SanPhams.get(4)));
		//PhieuBaoHanhs.add(new PhieuBaoHanh("PBH06", new SimpleDateFormat("22/03/2019"), 6, SanPhams.get(5)));
	}

	public static void TaoDanhSachHDNhapHang() {
		HDNhapHang hdnh = new HDNhapHang("HDN01", new SimpleDateFormat("10/01/2019"), 500000, 10, 05, NoiCungCaps.get(0));
		HDNhapHangs.add(hdnh);
	//	HDNhapHangs
	//			.add(new HDNhapHang("HDN02", new SimpleDateFormat("20/03/2019"), 600000, 15, 10, NoiCungCaps.get(1)));
	//	HDNhapHangs
	//			.add(new HDNhapHang("HDN03", new SimpleDateFormat("07/04/2019"), 700000, 50, 05, NoiCungCaps.get(2)));
	//	HDNhapHangs
	//			.add(new HDNhapHang("HDN04", new SimpleDateFormat("10/12/2018"), 800000, 15, 10, NoiCungCaps.get(3)));
	//	HDNhapHangs
	//			.add(new HDNhapHang("HDN05", new SimpleDateFormat("02/01/2019"), 900000, 20, 10, NoiCungCaps.get(4)));
	//	HDNhapHangs
	//			.add(new HDNhapHang("HDN06", new SimpleDateFormat("04/07/2019"), 850000, 25, 10, NoiCungCaps.get(5)));
	}

	public void showSanPhams() {
		System.out.println("                        ***DANH SÁCH SẢN PHẨM FASHION SHOP***");
		System.out.println(
				"    __________________________________________________________________________________________________");
		System.out.println(
				"    | STT | Mã SP |Đơn vị tính|Số lượng| Ngày  nhập |   Hãng sản xuất    |         Nơi Nhập       |");
		System.out.println(
				"    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		int i = 1;
		for (SanPham sp : SanPhams) {
			System.out.printf("    |%3d  |%6s |%11s|%8s|%12s|%21s|%32s|\n", i, sp.getsMaSanPham(),
					sp.getsDonViTinh(), sp.getHDNhapHang().getiSoLuong(), sp.getHDNhapHang().getsNgayNhap(),
					sp.getsHangSanPham(), sp.getHDNhapHang().getNoiCungCap());
			i++;
		}
		System.out.println(
				"    ____________________________________________________________________________________________________________________");
		System.out.println();

	}
}
