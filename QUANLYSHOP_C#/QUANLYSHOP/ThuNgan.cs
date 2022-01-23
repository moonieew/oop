using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYSHOP
{
    public class ThuNgan : NhanVien, Luong
    {
        public ThuNgan() : base()
        {
        }

        public ThuNgan(string MaNV, string Ten, int NamSinh, string SDT, string DiaChi, string CMND, string LoaiNV, 
            string GioiTinh, int SoNgayLam, int GioTangCa) : this()
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
            // lương cơ bản của quản lý là 6 triệu/tháng
            return 6000000;
        }

        public double LuongTangCa()
        {
            // ngày làm 8 tiếng, tăng ca tính thêm tiền
            return IGioTangCa * 30000;
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
