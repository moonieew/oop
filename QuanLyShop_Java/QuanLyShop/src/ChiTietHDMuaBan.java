public class ChiTietHDMuaBan
{
	// khoa chính
	private String sMaChiTietHoaDonMuaBan;
	// thuộc tính
	private int iSoLuong;
	// khoa phu
	private String sMaSanPham;
	private String sHDMuaBan;
	public SanPham SanPham;
    public HoaDonMuaBan HoaDonMuaBan;
	protected String getsMaChiTietHoaDonMuaBan() {
		return sMaChiTietHoaDonMuaBan;
	}
	protected void setsMaChiTietHoaDonMuaBan(String sMaChiTietHoaDonMuaBan)
	{
		this.sMaChiTietHoaDonMuaBan = sMaChiTietHoaDonMuaBan;
	}
	protected int getiSoLuong() {
		return iSoLuong;
	}
	protected void setiSoLuong(int iSoLuong) {
		this.iSoLuong = iSoLuong;
	}
	protected String getsMaSanPham() {
		return sMaSanPham;
	}
	protected void setsMaSanPham(String sMaSanPham) {
		this.sMaSanPham = sMaSanPham;
	}
	protected String getsHDMuaBan() {
		return sHDMuaBan;
	}
	protected void setsHDMuaBan(String sHDMuaBan) {
		this.sHDMuaBan = sHDMuaBan;
	}
	protected SanPham getSanPham() {
		return SanPham;
	}
	protected void setSanPham(SanPham sanPham) {
		SanPham = sanPham;
	}
	protected HoaDonMuaBan getHoaDonMuaBan() {
		return HoaDonMuaBan;
	}
	protected void setHoaDonMuaBan(HoaDonMuaBan hoaDonMuaBan) {
		HoaDonMuaBan = hoaDonMuaBan;
	}
	public ChiTietHDMuaBan(String sMaChiTietHoaDonMuaBan, int iSoLuong, String sMaSanPham, String sHDMuaBan,
			SanPham sanPham, HoaDonMuaBan hoaDonMuaBan)
	{
		super();
		this.sMaChiTietHoaDonMuaBan = sMaChiTietHoaDonMuaBan;
		this.iSoLuong = iSoLuong;
		this.sMaSanPham = sMaSanPham;
		this.sHDMuaBan = sHDMuaBan;
		SanPham = sanPham;
		HoaDonMuaBan = hoaDonMuaBan;
	}
	//new ChiTietHDMuaBan("CTHDMB01",10,SanPhams.get(0),"HDMB01",hdmb);
	public ChiTietHDMuaBan(String sMaChiTietHoaDonMuaBan, int iSoLuong, SanPham sanPham, String sMaSanPham,
			HoaDonMuaBan hoaDonMuaBan)
	{
		super();
		this.sMaChiTietHoaDonMuaBan = sMaChiTietHoaDonMuaBan;
		this.iSoLuong = iSoLuong;
		SanPham = sanPham;
		this.sMaSanPham = sMaSanPham;
		HoaDonMuaBan = hoaDonMuaBan;
	}
}