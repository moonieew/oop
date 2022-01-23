
public abstract class NhanVien
{
	protected static int iSoLuongNhanVien = 0;
	protected String sMaNV;
	protected String sTen;
	protected int iNamSinh;
	protected String sSDT;
	protected String sDiaChi;
	protected String sCMND;
	protected int iSoNgayLam;
	protected int iGioTangCa;
	final double thuong = 500000;
	protected String sLoaiNV;
	protected String sGioiTinh;

	protected String getsGioiTinh() {
		return sGioiTinh;
	}

	protected void setsGioiTinh(String sGioiTinh) {
		this.sGioiTinh = sGioiTinh;
	}

	protected String getLoaiNV() {
		return sLoaiNV;
	}

	protected void setLoaiNV(String LoaiNV) {
		this.sLoaiNV = LoaiNV;
	}

	protected static int getSoLuongNhanVien() {
		return iSoLuongNhanVien;
	}

	protected static void setSoLuongNhanVien(int SoLuongNhanVien) {
		NhanVien.iSoLuongNhanVien = SoLuongNhanVien;
	}

	protected String getMaNV() {
		return sMaNV;
	}

	protected void setMaNV(String MaNV) {
		this.sMaNV = MaNV;
	}

	protected String getTen() {
		return sTen;
	}

	protected void setTen(String Ten) {
		this.sTen = Ten;
	}

	protected int getNamSinh() {
		return iNamSinh;
	}

	protected void setNamSinh(int NamSinh) {
		this.iNamSinh = NamSinh;
	}

	protected String getSDT() {
		return sSDT;
	}

	protected void setSDT(String SDT) {
		this.sSDT = SDT;
	}

	protected String getDiaChi() {
		return sDiaChi;
	}

	protected void setDiaChi(String DiaChi) {
		this.sDiaChi = DiaChi;
	}

	protected String getCMND() {
		return sCMND;
	}

	protected void setCMND(String CMND) {
		this.sCMND = CMND;
	}

	protected int getSoNgayLam() {
		return iSoNgayLam;
	}

	protected void setSoNgayLam(int NgayLam) {
		this.iSoNgayLam = NgayLam;
	}

	protected int getGioTangCa() {
		return iGioTangCa;
	}

	protected void setGioTangCa(int GioTangCa) {
		this.iGioTangCa = GioTangCa;
	}

	

	public NhanVien(String sMaNV, String sTen, int iNamSinh, String sSDT, String sDiaChi, String sCMND, int iSoNgayLam,
			int iGioTangCa, String sLoaiNV, String sGioiTinh)
	{
		super();
		this.sMaNV = sMaNV;
		this.sTen = sTen;
		this.iNamSinh = iNamSinh;
		this.sSDT = sSDT;
		this.sDiaChi = sDiaChi;
		this.sCMND = sCMND;
		this.iSoNgayLam = iSoNgayLam;
		this.iGioTangCa = iGioTangCa;
		this.sLoaiNV = sLoaiNV;
		this.sGioiTinh = sGioiTinh;
		iSoLuongNhanVien++;
	}




	public NhanVien(String sMaNV, String sTen, int iNamSinh, String sSDT, String sDiaChi, String sCMND, String sLoaiNV,
			String sGioiTinh)
	{
		super();
		this.sMaNV = sMaNV;
		this.sTen = sTen;
		this.iNamSinh = iNamSinh;
		this.sSDT = sSDT;
		this.sDiaChi = sDiaChi;
		this.sCMND = sCMND;
		this.sLoaiNV = sLoaiNV;
		this.sGioiTinh = sGioiTinh;
	}

	public NhanVien() {
		super();
	}

	@SuppressWarnings("deprecation")
	@Override
	protected void finalize() throws Throwable
	{
		// TODO Auto-generated method stub
		super.finalize();
	}

	public static double TienThuong(int iSoNgayLam, final double thuong)
	{
		// mỗi tháng 30 ngày, được nghỉ 4 ngày tùy chọn
		// ngoài lương cơ bản, mỗi tháng có 500000 tiền thưởng
		// nghỉ thêm 1 ngày thì tiền thưởng giảm 100000, nghỉ quá 3 ngày thì không có
		// thưởng
		if (iSoNgayLam > 26)
			return (thuong + (iSoNgayLam - 26) * 100000);
		int soNgayNghi = 26 - iSoNgayLam;
		if (soNgayNghi < 4)
			return (thuong - soNgayNghi * 100000);
		else
			return 0;
	}

}
