using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYSHOP
{
    public class QuanLy : NhanVien, Luong
    {
        public QuanLy() : base()
        {
        }

        public QuanLy(String MaNV, String Ten, int NamSinh, String SDT, String DiaChi, String CMND,
             String LoaiNV, String GioiTinh) : this()
        {
            this.SMaNV = MaNV;
            this.STen = Ten;
            this.INamSinh = NamSinh;
            this.SSDT = SDT;
            this.SDiaChi = DiaChi;
            this.SCMND = CMND;
            this.SLoaiNV = LoaiNV;
            this.SGioiTinh = GioiTinh;

        }
        public double LuongCoBan()
        {
            // lương cơ bản của quản lý là 7 triệu/tháng
            return 7000000;
        }


        public double LuongTangCa()
        {
            // ngày làm 8 tiếng, tăng ca tính thêm tiền
            return IGioTangCa * 40000;
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
