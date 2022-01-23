
public class SanPham
{
	private String sMaSanPham;
	private String sDonViTinh;
	private String sHangSanPham;
	private String sMaHoaDonMuaBan;
	private String sMaBaoHanh;
	 public HDNhapHang HDNhapHang; 
     public SanPham(String sMaSanPham, String sDonViTinh, String sHangSanPham, String sMaHoaDonMuaBan, String sMaBaoHanh,
			HDNhapHang hDNhapHang, PhieuBaoHanh phieuBaoHanh, ChiTietHDMuaBan chiTietHDMuaBan) {
		super();
		this.sMaSanPham = sMaSanPham;
		this.sDonViTinh = sDonViTinh;
		this.sHangSanPham = sHangSanPham;
		this.sMaHoaDonMuaBan = sMaHoaDonMuaBan;
		this.sMaBaoHanh = sMaBaoHanh;
		HDNhapHang = hDNhapHang;
		PhieuBaoHanh = phieuBaoHanh;
		ChiTietHDMuaBan = chiTietHDMuaBan;
	}

	protected HDNhapHang getHDNhapHang() {
		return HDNhapHang;
	}

	protected void setHDNhapHang(HDNhapHang hDNhapHang) {
		HDNhapHang = hDNhapHang;
	}

	protected PhieuBaoHanh getPhieuBaoHanh() {
		return PhieuBaoHanh;
	}

	protected void setPhieuBaoHanh(PhieuBaoHanh phieuBaoHanh) {
		PhieuBaoHanh = phieuBaoHanh;
	}

	protected ChiTietHDMuaBan getChiTietHDMuaBan() {
		return ChiTietHDMuaBan;
	}

	protected void setChiTietHDMuaBan(ChiTietHDMuaBan chiTietHDMuaBan) {
		ChiTietHDMuaBan = chiTietHDMuaBan;
	}

	public PhieuBaoHanh PhieuBaoHanh;
     public ChiTietHDMuaBan ChiTietHDMuaBan; 

	public SanPham(String sMaSanPham, String sDonViTinh, String sHangSanPham, String sMaHoaDonMuaBan,
			String sMaBaoHanh) {
		super();
		this.sMaSanPham = sMaSanPham;
		this.sDonViTinh = sDonViTinh;
		this.sHangSanPham = sHangSanPham;
		this.sMaHoaDonMuaBan = sMaHoaDonMuaBan;
		this.sMaBaoHanh = sMaBaoHanh;
	}

	public SanPham(String sMaSanPham, String sDonViTinh, String sHangSanPham, String sMaBaoHanh) {
		super();
		this.sMaSanPham = sMaSanPham;
		this.sDonViTinh = sDonViTinh;
		this.sHangSanPham = sHangSanPham;
		this.sMaBaoHanh = sMaBaoHanh;
	}


//SanPhams.add(new SanPham("SP01", "CAI", "NIKE", HDNhapHangs.get(0)));
	
	protected String getsMaSanPham() {
		return sMaSanPham;
	}

	public SanPham(String sMaSanPham, String sDonViTinh, String sHangSanPham, HDNhapHang hDNhapHang) {
	super();
	this.sMaSanPham = sMaSanPham;
	this.sDonViTinh = sDonViTinh;
	this.sHangSanPham = sHangSanPham;
	HDNhapHang = hDNhapHang;
}

	protected void setsMaSanPham(String sMaSanPham) {
		this.sMaSanPham = sMaSanPham;
	}

	protected String getsDonViTinh() {
		return sDonViTinh;
	}

	protected void setsDonViTinh(String sDonViTinh) {
		this.sDonViTinh = sDonViTinh;
	}

	protected String getsHangSanPham() {
		return sHangSanPham;
	}

	protected void setsHangSanPham(String sHangSanPham) {
		this.sHangSanPham = sHangSanPham;
	}

	protected String getsMaHoaDonMuaBan() {
		return sMaHoaDonMuaBan;
	}

	protected void setsMaHoaDonMuaBan(String sMaHoaDonMuaBan) {
		this.sMaHoaDonMuaBan = sMaHoaDonMuaBan;
	}

	protected String getsMaBaoHanh() {
		return sMaBaoHanh;
	}

	protected void setsMaBaoHanh(String sMaBaoHanh) {
		this.sMaBaoHanh = sMaBaoHanh;
	}

}
