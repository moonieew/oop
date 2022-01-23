using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYSHOP
{
    public abstract class NhanVien
    {
        #region Fields
        private string sMaNV;
        private String sTen;
        private int iNamSinh;
        private String sSDT;
        private String sDiaChi;
        private String sCMND;
        private String sLoaiNV;
        private String sGioiTinh;
        private int iSoNgayLam;
        private int iGioTangCa;
        const double thuong = 500000;
        #endregion

        public string SMaNV { get => sMaNV; set => sMaNV = value; }
        public string STen { get => sTen; set => sTen = value; }
        public int INamSinh { get => iNamSinh; set => iNamSinh = value; }
        public string SSDT { get => sSDT; set => sSDT = value; }
        public string SDiaChi { get => sDiaChi; set => sDiaChi = value; }
        public string SCMND { get => sCMND; set => sCMND = value; }
        public string SLoaiNV { get => sLoaiNV; set => sLoaiNV = value; }
        public string SGioiTinh { get => sGioiTinh; set => sGioiTinh = value; }
        public int ISoNgayLam { get => iSoNgayLam; set => iSoNgayLam = value; }
        public int IGioTangCa { get => iGioTangCa; set => iGioTangCa = value; }
        public static double Thuong => thuong;

        public NhanVien(String sMaNV, String sTen, int iNamSinh, String sSDT, String sDiaChi, String sCMND, String sLoaiNV, String sGioiTinh, int iSoNgayLam,
                int iGioTangCa)
        {

            this.SMaNV = sMaNV;
            this.STen = sTen;
            this.INamSinh = iNamSinh;
            this.SSDT = sSDT;
            this.SDiaChi = sDiaChi;
            this.SCMND = sCMND;
            this.SLoaiNV = sLoaiNV;
            this.SGioiTinh = sGioiTinh;
            this.ISoNgayLam = iSoNgayLam;
            this.IGioTangCa = iGioTangCa;
        }

        public NhanVien()
        {
        }

        public static double TienThuong(int iSoNgayLam, double thuong)
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
        public void ShowInfo()
        {
            Console.WriteLine("{0,-10}{1,-25}{2,-9}{3,-12}{4,-15}{5,-28}{6,-20} ", SMaNV, STen, SGioiTinh, SCMND, INamSinh, SDiaChi, SSDT);
        }
    }
}
