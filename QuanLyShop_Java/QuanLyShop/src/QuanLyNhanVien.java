import java.util.ArrayList;
import java.util.Collection;
import java.util.List;
import java.util.Scanner;

public class QuanLyNhanVien {
	// khởi tạo,thêm, sửa, xóa, sắp xếp, hiển thị danh sách nhân viên
	public static Scanner sc = new Scanner(System.in);
	public static List<NhanVien> lNhanVien;

	public static List<NhanVien> getlNhanVien() {
		return lNhanVien;
	}

	protected void setlNhanVien(List<NhanVien> NhanViens) {
		QuanLyNhanVien.lNhanVien = NhanViens;
	}

	public QuanLyNhanVien()
	{

	}

	public void KhoiTaoNhanVien() {
		lNhanVien = new ArrayList<NhanVien>();
		// String MaNV, String Ten, int NamSinh, String SDT, String DiaChi, String CMND,
		// int SoNgayLam, int GioTangCa, String LoaiNV

		// quản lý
		NhanVien ql1 = new QuanLy("QL01", "Trần Thị Quản Lý", 1999, "0988188449", "Quận 9, Tp.HCM", "251274983", 0, 0,
				"QL", "Nữ");
		lNhanVien.add(ql1);
		NhanVien ql2 = new QuanLy("QL02", "Nguyễn Trần Quản Lý", 1999, "0988188733", "Quận 8, Tp.HCM", "251287483", 0,
				0, "QL", "Nam");
		lNhanVien.add(ql2);

		// thu ngân
		NhanVien tn1 = new ThuNgan("TN01", "Lê Quỳnh Thu Ngân", 1998, "0986978673", "Quận Thủ Đức, Tp.HCM", "251274453",
				0, 0, "TV", "Nữ");
		lNhanVien.add(tn1);
		NhanVien tn2 = new ThuNgan("TN02", "Cao Thu Ngân", 1997, "0984567673", "Quận Bình Thạnh, Tp.HCM", "256784453",
				0, 0, "TV", "Nam");
		lNhanVien.add(tn2);

		// tư vấn
		NhanVien tv1 = new TuVan("TV01", "Cao Mỹ Tư Vấn", 2001, "0987983245", "Quận 2, Tp.HCM", "245274983", 0, 0, "TV",
				"Nữ");
		lNhanVien.add(tv1);
		NhanVien tv2 = new TuVan("TV02", "Trần Nguyễn Tư Vấn", 2001, "0935983245", "Quận 3, Tp.HCM", "246274983", 0, 0,
				"TV", "Nam");
		lNhanVien.add(tv2);

	}

	public void showNhanVien()
	{
		Scanner sc = new Scanner(System.in);
		System.out.println("____Chọn danh sách: ");
		System.out.println("	0.Toàn bộ nhân viên");
		System.out.println("	1.Quản Lý");
		System.out.println("	2.Thu Ngân");
		System.out.println("	3.Tư Vấn Mua Hàng");
		int ch = 0;
		ch = Integer.parseInt(sc.next());
		String l = null;
		if (ch == 1)
			l = "QL";
		if (ch == 2)
			l = "TN";
		if (ch == 3)
			l = "TV";
		switch (ch) {
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
		System.out.println("                               ***DANH SÁCH NHÂN VIÊN FASHION SHOP***");
		System.out.println(
				"    ____________________________________________________________________________________________________________________");
		System.out.println(
				"    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
		System.out.println(
				"    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		int i = 1;
		for (NhanVien nv : lNhanVien)
		{
			System.out.printf("    |%3d  |%5s|%23s|%7s  |%12s|%8d|%32s|%13" + "s|\n", i, nv.sMaNV, nv.sTen,
					nv.sGioiTinh, nv.sCMND, nv.iNamSinh, nv.sDiaChi, nv.sSDT);
			i++;
		}
		System.out.println(
				"    ____________________________________________________________________________________________________________________");
		System.out.println();
	}

	public void showQuanLy()
	{
		System.out.println("                            ***DANH SÁCH NHÂN VIÊN THU NGÂN FASHION SHOP***");
		System.out.println(
				"    ____________________________________________________________________________________________________________________");
		System.out.println(
				"    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
		System.out.println(
				"    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		int i = 1;
		for (NhanVien nv : lNhanVien)
			if (nv.sLoaiNV == "QL")
			{
				System.out.printf("    |%3d  |%5s|%23s|%7s  |%12s|%8d|%32s|%13" + "s|\n", i, nv.sMaNV, nv.sTen,
						nv.sGioiTinh, nv.sCMND, nv.iNamSinh, nv.sDiaChi, nv.sSDT);
				i++;
			}
		System.out.println(
				"    ____________________________________________________________________________________________________________________");
		System.out.println();
	}

	public void showThuNgan()
	{
		System.out.println("                            ***DANH SÁCH NHÂN VIÊN THU NGÂN FASHION SHOP***");
		System.out.println(
				"    ____________________________________________________________________________________________________________________");
		System.out.println(
				"    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
		System.out.println(
				"    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		int i = 1;
		for (NhanVien nv : lNhanVien)
			if (nv.sLoaiNV == "TN")
			{
				System.out.printf("    |%3d  |%5s|%23s|%7s  |%12s|%8d|%32s|%13" + "s|\n", i, nv.sMaNV, nv.sTen,
						nv.sGioiTinh, nv.sCMND, nv.iNamSinh, nv.sDiaChi, nv.sSDT);
				i++;
			}
		System.out.println(
				"    ____________________________________________________________________________________________________________________");
		System.out.println();
	}

	public void showTuVan()
	{
		System.out.println("                         ***DANH SÁCH NHÂN VIÊN TƯ VẤN MUA HÀNG FASHION SHOP***");
		System.out.println(
				"    ____________________________________________________________________________________________________________________");
		System.out.println(
				"    | STT |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
		System.out.println(
				"    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		int i = 1;
		for (NhanVien nv : lNhanVien)
			if (nv.sLoaiNV == "TV")
			{
				System.out.printf("    |%3d  |%5s|%23s|%7s  |%12s|%8d|%32s|%13" + "s|\n", i, nv.sMaNV, nv.sTen,
						nv.sGioiTinh, nv.sCMND, nv.iNamSinh, nv.sDiaChi, nv.sSDT);
				i++;
			}
		System.out.println(
				"    ____________________________________________________________________________________________________________________");
		System.out.println();

	}

	public void addNhanVien()
	{
		Scanner sc = new Scanner(System.in);
		System.out.println("____Hãy nhập thông tin nhân viên mới____");
		System.out.println("____Chọn loại nhân viên: ");
		System.out.println("Quản Lý  : QL");
		System.out.println("Thu Ngân : TN");
		System.out.println("Tư Vấn   : TV");
		String loaiNV = sc.next();
		// System.out.println(lNhanVien.get(2).sMaNV);
		System.out.print("Tên nhân viên: ");
		String ten = sc.next();

		System.out.print("Giới tính: ");
		String gt = sc.next();

		System.out.print("CMND: ");
		String cmnd = sc.next();

		System.out.print("Năm sinh: ");
		int namsinh = Integer.parseInt(sc.next());

		System.out.print("Địa chỉ: ");
		String dc = sc.next();

		System.out.print("SĐT: ");
		String sdt = sc.next();
		sc.nextLine();
		String maNV;
		int so = 0;
		//System.out.println(loaiNV);
		for (int j = lNhanVien.size() - 1; j >= 0; j--)
		{
			if (lNhanVien.get(j).sLoaiNV.equals(loaiNV))
			{
				so = Integer.parseInt(lNhanVien.get(j).sMaNV.substring(2, 4)); //substring(a,b) lấy đoạn chuỗi từ a đến b-1
				break;
			}
		}
		if (so < 9)
			maNV = loaiNV + "0" + String.valueOf(so + 1);
		else
			maNV = loaiNV + String.valueOf(so + 1);
		// sMaNV, sTen, iNamSinh, sSDT, sDiaChi, sCMND, sLoaiNV, sGioiTinh

		int i = 0;

		switch (loaiNV)
		{
		case "QL":
			NhanVien ql = new QuanLy(maNV, ten, namsinh, sdt, dc, cmnd, "QL", gt);
			lNhanVien.add(ql);
			i++;
			break;
		case "TN":
			NhanVien tn = new ThuNgan(maNV, ten, namsinh, sdt, dc, cmnd, "TN", gt);
			lNhanVien.add(tn);
			i++;
			break;
		case "TV":
			NhanVien tv = new TuVan(maNV, ten, namsinh, sdt, dc, cmnd, "TV", gt);
			lNhanVien.add(tv);
			i++;
			break;
		default:
			break;
		}
		if (i > 0)
		{
			System.out.println("Thông tin nhân viên mới đã được lưu !!");
			System.out.println("__________________________________________________________");
		} else
			{
			System.out.println("Có gì đó không ổn, bạn gõ 1 để nhập lại thông tin nhé !!");
			System.out.println("__________________________________________________________");
		}
	}

	public void delNhanVien()
	{
		boolean i = true;
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập mã nhân viên của nhân viên bạn muốn xóa: ");
		String m = sc.next();
		for (NhanVien nv : lNhanVien)
		{
			if (nv.sMaNV.equals(m))
			{
				lNhanVien.remove(nv);
				System.out.println("Nhân viên " + m + " đã bị xóa !");
				System.out.println("__________________________________________________________");
				i = false;
				break;
			}
		}
		if (i)
		{
			System.out.println("Mã nhân viên này không tồn tại, bạn gõ 3 đã tiếp tục xóa !");
			System.out.println("__________________________________________________________");
		}

	}

	public void editNhanVien()
	{
		boolean i = true;
		Scanner sc = new Scanner(System.in);
		System.out.print("Nhập mã nhân viên của nhân viên bạn muốn chỉnh sửa: ");
		String m = sc.next();
		for (NhanVien nv : lNhanVien)
		{
			if (nv.sMaNV.equals(m))
			{
				System.out.print("Tên nhân viên: ");
				String ten = sc.next();
				nv.setTen(ten);
				System.out.print("Giới tính: ");
				String gt = sc.next();
				nv.setsGioiTinh(gt);
				System.out.print("CMND: ");
				String cmnd = sc.next();
				nv.setCMND(cmnd);
				System.out.print("Năm sinh: ");
				int namsinh = Integer.parseInt(sc.next());
				nv.setNamSinh(namsinh);
				System.out.print("Địa chỉ: ");
				String dc = sc.next();
				nv.setDiaChi(dc);
				System.out.print("SĐT: ");
				String sdt = sc.next();
				nv.setSDT(sdt);
				sc.nextLine();

				System.out.println("Thông tin nhân viên " + m + " đã được cập nhật !");
				System.out.println("__________________________________________________________");
				i = false;
				break;
			}
		}
		if (i) {
			System.out.println("Mã nhân viên này không tồn tại, bạn gõ 2 đã tiếp tục xóa !");
			System.out.println("__________________________________________________________");

		}

	}

	public void searchNhanVien()
	{
		boolean i = true;
		Scanner sc = new Scanner(System.in);
		System.out.println("                                        ***TÌM NHÂN VIÊN***");
		System.out.print("Nhập mã nhân viên của nhân viên bạn muốn tìm: ");
		String m = sc.nextLine();
		System.out.println(
				"    ______________________________________________________________________________________________________________");
		System.out.println(
				"    |Mã NV|       Họ và Tên       |Giới Tính|    CMND    |Năm sinh|             Địa chỉ            |Số Điện Thoại|");
		System.out.println(
				"    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
		for (NhanVien nv : lNhanVien)
		{
			if (nv.getMaNV().equals(m))
			{
				System.out.printf("    |%5s|%23s|%7s  |%12s|%8d|%32s|%13" + "s|\n", nv.sMaNV, nv.sTen, nv.sGioiTinh,
						nv.sCMND, nv.iNamSinh, nv.sDiaChi, nv.sSDT);
				System.out.println(
						"    ______________________________________________________________________________________________________________");
				System.out.println();
				i = false;
				break;
			}
		}
		if (i)
		{
			System.out.println("Mã nhân viên này không tồn tại, bạn gõ 5 đã tiếp tục xóa !");
			System.out.println("__________________________________________________________");
		}

	}
}