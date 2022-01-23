using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYSHOP
{
    public abstract class SanPham
    {
        private String sMaSP;
        private String sTenSP;
        private int iSoluong;
        private String sSize;
        private String sMau;
        private String sLoaiSP;
        private double dGiaTien;

        public string SMaSP { get => sMaSP; set => sMaSP = value; }
        public string STenSP { get => sTenSP; set => sTenSP = value; }
        public int ISoluong { get => iSoluong; set => iSoluong = value; }
        public string SSize { get => sSize; set => sSize = value; }
        public string SMau { get => sMau; set => sMau = value; }
        public string SLoaiSP { get => sLoaiSP; set => sLoaiSP = value; }
        public double DGiaTien { get => dGiaTien; set => dGiaTien = value; }

        public SanPham(String sMaSP, String sTenSP, int iSoluong, String sSize, String sMau, String sLoaiSP, double dGiaTien)
        {
            this.SMaSP = sMaSP;
            this.STenSP = sTenSP;
            this.ISoluong = iSoluong;
            this.SSize = sSize;
            this.SMau = sMau;
            this.SLoaiSP = sLoaiSP;
            this.DGiaTien = dGiaTien;
        }

        protected SanPham()
        {

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("     {0,-10}{1,-25}{2,-9}{3,-12}{4,-15}{5,-10}", SMaSP, STenSP, ISoluong, SSize, SMau, DGiaTien);
        }

        public void Update()
        {
            Console.Write("SỐ LƯỢNG MỚI CỦA SẢN PHẨM LÀ: ");

            this.ISoluong = Convert.ToInt32(Console.ReadLine());
        }
    }
}
