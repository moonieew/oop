
public class TuVan extends NhanVien implements Luong {

	public TuVan(String MaNV, String Ten, int NamSinh, String SDT, String DiaChi, String CMND, int SoNgayLam,
			int GioTangCa, String LoaiNV, String GioiTinh) {
		super(MaNV, Ten, NamSinh, SDT, DiaChi, CMND, SoNgayLam, GioTangCa, LoaiNV, GioiTinh);
	}

	public TuVan(String sMaNV, String sTen, int iNamSinh, String sSDT, String sDiaChi, String sCMND, String sLoaiNV,
			String sGioiTinh)
	{
		super(sMaNV, sTen, iNamSinh, sSDT, sDiaChi, sCMND, sLoaiNV, sGioiTinh);

	}

	

	public TuVan() {
		super();
		
	}

	@Override
	public double LuongCoBan() {
		return 600000;
	}

	@Override
	public double LuongTangCa() {
		return iGioTangCa * 30000;
	}

	@Override
	public double TienThuong() {
		return TienThuong(iSoNgayLam, thuong);
	}

	@Override
	public double LuongTong() {
		return (LuongCoBan() + LuongTangCa() + TienThuong());
	}

}
