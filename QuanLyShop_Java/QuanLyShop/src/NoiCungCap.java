 public class NoiCungCap
    {
        // khóa chính
        private String sMaNoiCungCap;
        // thuộc tính
        private String sTenNoiCungCap;
        private String sSanPhamCungCap;
        private String sSĐT;
        private String sEmail;
		protected String getsMaNoiCungCap() {
			return sMaNoiCungCap;
		}
		protected void setsMaNoiCungCap(String sMaNoiCungCap) {
			this.sMaNoiCungCap = sMaNoiCungCap;
		}
		protected String getsTenNoiCungCap() {
			return sTenNoiCungCap;
		}
		protected void setsTenNoiCungCap(String sTenNoiCungCap) {
			this.sTenNoiCungCap = sTenNoiCungCap;
		}
		protected String getsSanPhamCungCap() {
			return sSanPhamCungCap;
		}
		protected void setsSanPhamCungCap(String sSanPhamCungCap) {
			this.sSanPhamCungCap = sSanPhamCungCap;
		}
		protected String getsSĐT() {
			return sSĐT;
		}
		protected void setsSĐT(String sSĐT) {
			this.sSĐT = sSĐT;
		}
		protected String getsEmail() {
			return sEmail;
		}
		protected void setsEmail(String sEmail) {
			this.sEmail = sEmail;
		}
		public NoiCungCap(String sMaNoiCungCap, String sTenNoiCungCap, String sSanPhamCungCap, String sSĐT,
				String sEmail)
		{
			super();
			this.sMaNoiCungCap = sMaNoiCungCap;
			this.sTenNoiCungCap = sTenNoiCungCap;
			this.sSanPhamCungCap = sSanPhamCungCap;
			this.sSĐT = sSĐT;
			this.sEmail = sEmail;
		}
		
}