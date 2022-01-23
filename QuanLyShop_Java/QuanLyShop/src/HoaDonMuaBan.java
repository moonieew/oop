import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.List;

public class HoaDonMuaBan
{
	 // khóa chính
    private String sMaHDMuaBan;
    // thuộc tính
    private SimpleDateFormat sNgayMua;
    private double iSoTien;         //đây là tiền mà bán cho Khách, chưa tính VAT
    private double iThueVAT;
    private boolean sCachChiTra;
    
    //plural
    public List<ChiTietHDMuaBan> ChiTietHDMuaBans ;
    public List<PhieuThu> PhieuThus;
    //singular
    public QuanLy QuanLy;
    public KhachHang KhachHang;
    public NhanVien TuVan;
    //Khóa Ngoại
    public String maChiTietHoaDonMuaBan;
    public String maNhanVien;
    public String maKhachHang ;
    public String maPhieuThu;
	public HoaDonMuaBan(String sMaHDMuaBan, SimpleDateFormat sNgayMua, double iSoTien, double iThueVAT,
			boolean sCachChiTra, List<ChiTietHDMuaBan> chiTietHDMuaBans, List<PhieuThu> phieuThus, QuanLy quanLy,
			KhachHang khachHang, String maChiTietHoaDonMuaBan, String maNhanVien, String maKhachHang,
			String maPhieuThu)
	{
		super();
		this.sMaHDMuaBan = sMaHDMuaBan;
		this.sNgayMua = sNgayMua;
		this.iSoTien = iSoTien;
		this.iThueVAT = iThueVAT;
		this.sCachChiTra = sCachChiTra;
		ChiTietHDMuaBans = chiTietHDMuaBans;
		PhieuThus = phieuThus;
		QuanLy = quanLy;
		KhachHang = khachHang;
		this.maChiTietHoaDonMuaBan = maChiTietHoaDonMuaBan;
		this.maNhanVien = maNhanVien;
		this.maKhachHang = maKhachHang;
		this.maPhieuThu = maPhieuThu;
	}
	//HoaDonMuaBans.add(new HoaDonMuaBan("HDMB01",SimpleDateFormat("04/05/2019"),3000000,10,true,"KH01",tamkh,tamnv));
	//"HDMB01",new SimpleDateFormat("04/05/2019"),3000000,10,true,"KH01",tamkh,tamnv)
	
	protected String getsMaHDMuaBan() {
		return sMaHDMuaBan;
	}
	public HoaDonMuaBan(String sMaHDMuaBan, SimpleDateFormat sNgayMua, double iSoTien, double iThueVAT,
			boolean sCachChiTra, String maKhachHang, KhachHang khachHang, NhanVien nhanVien)
	{
		super();
		this.sMaHDMuaBan = sMaHDMuaBan;
		this.sNgayMua = sNgayMua;
		this.iSoTien = iSoTien;
		this.iThueVAT = iThueVAT;
		this.sCachChiTra = sCachChiTra;
		this.maKhachHang = maKhachHang;
		KhachHang = khachHang;
		TuVan = nhanVien;
	}
	public HoaDonMuaBan(String sMaHDMuaBan, SimpleDateFormat sNgayMua, double iSoTien, double iThueVAT,
			boolean sCachChiTra, KhachHang khachHang, String maNhanVien)
	{
		super();
		this.sMaHDMuaBan = sMaHDMuaBan;
		this.sNgayMua = sNgayMua;
		this.iSoTien = iSoTien;
		this.iThueVAT = iThueVAT;
		this.sCachChiTra = sCachChiTra;
		KhachHang = khachHang;
		this.maNhanVien = maNhanVien;
	
	}
	public HoaDonMuaBan()
	{
		
	}

	protected void setsMaHDMuaBan(String sMaHDMuaBan) {
		this.sMaHDMuaBan = sMaHDMuaBan;
	}
	protected SimpleDateFormat getsNgayMua() {
		return sNgayMua;
	}
	protected void setsNgayMua(SimpleDateFormat sNgayMua) {
		this.sNgayMua = sNgayMua;
	}
	protected double getiSoTien() {
		return iSoTien;
	}
	protected void setiSoTien(double iSoTien) {
		this.iSoTien = iSoTien;
	}
	protected double getiThueVAT() {
		return iThueVAT;
	}
	protected void setiThueVAT(double iThueVAT) {
		this.iThueVAT = iThueVAT;
	}
	protected boolean issCachChiTra() {
		return sCachChiTra;
	}
	protected void setsCachChiTra(boolean sCachChiTra) {
		this.sCachChiTra = sCachChiTra;
	}
	protected List<ChiTietHDMuaBan> getChiTietHDMuaBans() {
		return ChiTietHDMuaBans;
	}
	protected void setChiTietHDMuaBans(List<ChiTietHDMuaBan> chiTietHDMuaBans) {
		ChiTietHDMuaBans = chiTietHDMuaBans;
	}
	protected List<PhieuThu> getPhieuThus() {
		return PhieuThus;
	}
	protected void setPhieuThus(List<PhieuThu> phieuThus) {
		PhieuThus = phieuThus;
	}
	protected QuanLy getQuanLy() {
		return QuanLy;
	}
	protected void setQuanLy(QuanLy quanLy) {
		QuanLy = quanLy;
	}
	protected KhachHang getKhachHang() {
		return KhachHang;
	}
	protected void setKhachHang(KhachHang khachHang) {
		KhachHang = khachHang;
	}
	protected String getMaChiTietHoaDonMuaBan() {
		return maChiTietHoaDonMuaBan;
	}
	protected void setMaChiTietHoaDonMuaBan(String maChiTietHoaDonMuaBan)
	{
		this.maChiTietHoaDonMuaBan = maChiTietHoaDonMuaBan;
	}
	protected String getMaNhanVien() {
		return maNhanVien;
	}
	protected void setMaNhanVien(String maNhanVien) {
		this.maNhanVien = maNhanVien;
	}
	protected String getMaKhachHang() {
		return maKhachHang;
	}
	protected void setMaKhachHang(String maKhachHang) {
		this.maKhachHang = maKhachHang;
	}
	protected String getMaPhieuThu() {
		return maPhieuThu;
	}
	protected void setMaPhieuThu(String maPhieuThu) {
		this.maPhieuThu = maPhieuThu;
	}
}
