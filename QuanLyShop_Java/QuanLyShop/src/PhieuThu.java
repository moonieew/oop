
public class PhieuThu
{
	// Khóa Chính
	public String maPhieuThu;
	// Thuoc tinh
	public double soTienTra;
	// Khóa Ngoại
	public String maHDMuaBan;
	// singular
	public HoaDonMuaBan HoaDonMuaBan;
	protected String getMaPhieuThu() {
		return maPhieuThu;
	}
	protected void setMaPhieuThu(String maPhieuThu) {
		this.maPhieuThu = maPhieuThu;
	}
	protected double getSoTienTra() {
		return soTienTra;
	}
	protected void setSoTienTra(double soTienTra) {
		this.soTienTra = soTienTra;
	}
	protected String getMaHDMuaBan() {
		return maHDMuaBan;
	}
	protected void setMaHDMuaBan(String maHDMuaBan) {
		this.maHDMuaBan = maHDMuaBan;
	}
	protected HoaDonMuaBan getHoaDonMuaBan() {
		return HoaDonMuaBan;
	}
	protected void setHoaDonMuaBan(HoaDonMuaBan hoaDonMuaBan) {
		HoaDonMuaBan = hoaDonMuaBan;
	}
	public PhieuThu(String maPhieuThu, double soTienTra, String maHDMuaBan, HoaDonMuaBan hoaDonMuaBan)
	{
		super();
		this.maPhieuThu = maPhieuThu;
		this.soTienTra = soTienTra;
		this.maHDMuaBan = maHDMuaBan;
		HoaDonMuaBan = hoaDonMuaBan;
	}
	
}
