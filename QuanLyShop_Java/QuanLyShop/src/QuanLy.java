
public class QuanLy extends NhanVien implements Luong {

	public QuanLy(String MaNV, String Ten, int NamSinh, String SDT, String DiaChi, String CMND, int SoNgayLam,
			int GioTangCa, String LoaiNV, String GioiTinh) {
		super(MaNV, Ten, NamSinh, SDT, DiaChi, CMND, SoNgayLam, GioTangCa, LoaiNV, GioiTinh);

	}
	
	public QuanLy(String sMaNV, String sTen, int iNamSinh, String sSDT, String sDiaChi, String sCMND, String sLoaiNV,
			String sGioiTinh) {
		super(sMaNV, sTen, iNamSinh, sSDT, sDiaChi, sCMND, sLoaiNV, sGioiTinh);
		
	}

	@Override
	public double LuongCoBan() {
		// lương cơ bản của quản lý là 6 triệu/tháng
		return 7000000;
	}

	@Override
	public double LuongTangCa() {
		// ngày làm 8 tiếng, tăng ca tính thêm tiền
		return iGioTangCa * 40000;
	}

	@Override
	public double LuongTong() {
		return (LuongCoBan() + LuongTangCa() + TienThuong());
	}

	@Override
	public double TienThuong() {
		return TienThuong(iSoNgayLam, thuong);

	}

}
