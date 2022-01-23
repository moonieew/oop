import java.util.List;

public class KhachHang
{
	 // KHÓA CHÍNH
    private String sMaKhachHang;
    // thuộc tính
    private String sTenKhachHang;
    private String sDiaChi;
    private String sLoaiKhach;
    private String sSDT;
    //khóa ngoại
    public String maHDMuaBan;
    // plural
    public List<HoaDonMuaBan> HoaDonMuaBans;
	protected String getsMaKhachHang() {
		return sMaKhachHang;
	}
	protected void setsMaKhachHang(String sMaKhachHang) {
		this.sMaKhachHang = sMaKhachHang;
	}
	protected String getsTenKhachHang() {
		return sTenKhachHang;
	}
	protected void setsTenKhachHang(String sTenKhachHang) {
		this.sTenKhachHang = sTenKhachHang;
	}
	protected String getsDiaChi() {
		return sDiaChi;
	}
	protected void setsDiaChi(String sDiaChi) {
		this.sDiaChi = sDiaChi;
	}
	protected String getsLoaiKhach() {
		return sLoaiKhach;
	}
	protected void setsLoaiKhach(String sLoaiKhach) {
		this.sLoaiKhach = sLoaiKhach;
	}
	protected String getsSDT() {
		return sSDT;
	}
	protected void setsSDT(String sSDT) {
		this.sSDT = sSDT;
	}
	protected String getMaHDMuaBan() {
		return maHDMuaBan;
	}
	protected void setMaHDMuaBan(String maHDMuaBan) {
		this.maHDMuaBan = maHDMuaBan;
	}
	protected List<HoaDonMuaBan> getHoaDonMuaBans() {
		return HoaDonMuaBans;
	}
	protected void setHoaDonMuaBans(List<HoaDonMuaBan> hoaDonMuaBans) {
		HoaDonMuaBans = hoaDonMuaBans;
	}
	public KhachHang(String sMaKhachHang, String sTenKhachHang, String sDiaChi, String sLoaiKhach, String sSDT,
			String maHDMuaBan, List<HoaDonMuaBan> hoaDonMuaBans)
	{
		super();
		this.sMaKhachHang = sMaKhachHang;
		this.sTenKhachHang = sTenKhachHang;
		this.sDiaChi = sDiaChi;
		this.sLoaiKhach = sLoaiKhach;
		this.sSDT = sSDT;
		this.maHDMuaBan = maHDMuaBan;
		HoaDonMuaBans = hoaDonMuaBans;
	}
	
	public KhachHang()
	{
		super();
	}
	//(new KhachHang("KH01","A","BIEN HOA","VIP","123456789");
	public KhachHang(String sMaKhachHang, String sTenKhachHang, String sDiaChi, String sLoaiKhach, String sSDT) {
		super();
		this.sMaKhachHang = sMaKhachHang;
		this.sTenKhachHang = sTenKhachHang;
		this.sDiaChi = sDiaChi;
		this.sLoaiKhach = sLoaiKhach;
		this.sSDT = sSDT;
	}
	
}
