import java.text.SimpleDateFormat;
import java.util.Date;

public class HDNhapHang
{
	// khoa chính
	private String sMaHoaDonNhap;
	// thuộc tính
	private SimpleDateFormat sNgayNhap;
	private double sGiaSanPham;
	private int iSoLuong;
	private double iThue;
	// khóa ngoại
	private String sMaNoiCungCap;
	private String sMaSanPham;
	public NoiCungCap NoiCungCap;
	public SanPham SanPham;

	public HDNhapHang(String sMaHoaDonNhap, SimpleDateFormat sNgayNhap, double sGiaSanPham, int iSoLuong, double iThue,
			String sMaNoiCungCap, String sMaSanPham, NoiCungCap noiCungCap, SanPham sanPham)
	{
		super();
		this.sMaHoaDonNhap = sMaHoaDonNhap;
		this.sNgayNhap = sNgayNhap;
		this.sGiaSanPham = sGiaSanPham;
		this.iSoLuong = iSoLuong;
		this.iThue = iThue;
		this.sMaNoiCungCap = sMaNoiCungCap;
		this.sMaSanPham = sMaSanPham;
		NoiCungCap = noiCungCap;
		SanPham = sanPham;
	}

	// "HDN01", new SimpleDateFormat("10/01/2019"), 500000, 10, 5,
	// NoiCungCaps.get(0))
	public HDNhapHang(String sMaHoaDonNhap, SimpleDateFormat sNgayNhap, double sGiaSanPham, int iSoLuong, double iThue,
			NoiCungCap noiCungCap) {
		super();
		this.sMaHoaDonNhap = sMaHoaDonNhap;
		this.sNgayNhap = sNgayNhap;
		this.sGiaSanPham = sGiaSanPham;
		this.iSoLuong = iSoLuong;
		this.iThue = iThue;
		NoiCungCap = noiCungCap;
		
	}

	protected NoiCungCap getNoiCungCap() {
		return NoiCungCap;
	}

	protected void setNoiCungCap(NoiCungCap noiCungCap) {
		NoiCungCap = noiCungCap;
	}

	protected SanPham getSanPham() {
		return SanPham;
	}

	protected void setSanPham(SanPham sanPham) {
		SanPham = sanPham;
	}

	protected String getsMaHoaDonNhap() {
		return sMaHoaDonNhap;
	}

	protected void setsMaHoaDonNhap(String sMaHoaDonNhap) {
		this.sMaHoaDonNhap = sMaHoaDonNhap;
	}

	protected SimpleDateFormat getsNgayNhap() {
		return sNgayNhap;
	}

	protected void setsNgayNhap(SimpleDateFormat sNgayNhap) {
		this.sNgayNhap = sNgayNhap;
	}

	protected double getsGiaSanPham() {
		return sGiaSanPham;
	}

	protected void setsGiaSanPham(double sGiaSanPham) {
		this.sGiaSanPham = sGiaSanPham;
	}

	protected int getiSoLuong() {
		return iSoLuong;
	}

	protected void setiSoLuong(int iSoLuong) {
		this.iSoLuong = iSoLuong;
	}

	protected double getiThue() {
		return iThue;
	}

	protected void setiThue(double iThue) {
		this.iThue = iThue;
	}

	protected String getsMaNoiCungCap() {
		return sMaNoiCungCap;
	}

	protected void setsMaNoiCungCap(String sMaNoiCungCap) {
		this.sMaNoiCungCap = sMaNoiCungCap;
	}

	protected String getsMaSanPham() {
		return sMaSanPham;
	}

	protected void setsMaSanPham(String sMaSanPham) {
		this.sMaSanPham = sMaSanPham;
	}

	public HDNhapHang(String sMaHoaDonNhap, SimpleDateFormat sNgayNhap, double sGiaSanPham, int iSoLuong, double iThue,
			String sMaNoiCungCap, String sMaSanPham) {
		super();
		this.sMaHoaDonNhap = sMaHoaDonNhap;
		this.sNgayNhap = sNgayNhap;
		this.sGiaSanPham = sGiaSanPham;
		this.iSoLuong = iSoLuong;
		this.iThue = iThue;
		this.sMaNoiCungCap = sMaNoiCungCap;
		this.sMaSanPham = sMaSanPham;
	}

}