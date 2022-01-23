using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHOP
{
    public class TuVan : NhanVien,Luong
    {
        public TuVan() : base()
        {
        }

        public TuVan(String MaNV, String Ten, int NamSinh, String SDT, String DiaChi, String CMND, String LoaiNV, String GioiTinh, int SoNgayLam, int GioTangCa) : this()
        {
            this.SMaNV = MaNV;
            this.STen = Ten;
            this.INamSinh = NamSinh;
            this.SSDT = SDT;
            this.SDiaChi = DiaChi;
            this.SCMND = CMND;
        
            this.SLoaiNV = LoaiNV;
            this.SGioiTinh = GioiTinh;
            this.ISoNgayLam = SoNgayLam;
            this.IGioTangCa = GioTangCa;

        }
        public double LuongCoBan()
        {
            // lương cơ bản của quản lý là 6.5 triệu/tháng
            return 6500000;
        }


        public double LuongTangCa()
        {
            // ngày làm 8 tiếng, tăng ca tính thêm tiền
            return IGioTangCa * 350000;
        }
        public double TienThuong()
        {
            return TienThuong(ISoNgayLam, Thuong);

        }

        public double LuongTong()
        {
            double LuongTong = (LuongCoBan() + LuongTangCa() + TienThuong());
            return LuongTong;
        }

    }
}
