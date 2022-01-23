import java.text.SimpleDateFormat;
import java.util.Date;

public class PhieuBaoHanh
{
	// khóa chính 
    private String sMaPhieuBaoHanh;
    // thuộc tính
    private SimpleDateFormat sNgayMua;
    private int iThoiHanBaoHanh;
    // maSanPham kế thừa từ classs san pham thông qua class HoaDonMuaBan

    public SanPham SanPham;

	protected String getsMaPhieuBaoHanh() {
		return sMaPhieuBaoHanh;
	}

	protected void setsMaPhieuBaoHanh(String sMaPhieuBaoHanh) {
		this.sMaPhieuBaoHanh = sMaPhieuBaoHanh;
	}

	protected SimpleDateFormat getsNgayMua() {
		return sNgayMua;
	}

	protected void setsNgayMua(SimpleDateFormat sNgayMua) {
		this.sNgayMua = sNgayMua;
	}

	protected int getiThoiHanBaoHanh() {
		return iThoiHanBaoHanh;
	}

	protected void setiThoiHanBaoHanh(int iThoiHanBaoHanh) {
		this.iThoiHanBaoHanh = iThoiHanBaoHanh;
	}

	protected SanPham getSanPham() {
		return SanPham;
	}

	protected void setSanPham(SanPham sanPham) {
		SanPham = sanPham;
	}

	public PhieuBaoHanh(String sMaPhieuBaoHanh, SimpleDateFormat sNgayMua, int iThoiHanBaoHanh, SanPham sanPham) {
		super();
		this.sMaPhieuBaoHanh = sMaPhieuBaoHanh;
		this.sNgayMua = sNgayMua;
		this.iThoiHanBaoHanh = iThoiHanBaoHanh;
		SanPham = sanPham;
	}
	

	//PhieuBaoHanhs.add(new PhieuBaoHanh("PBH02", new SimpleDateFormat("10/07/2019"), 12, SanPhams.get(1)));
    
    
}
