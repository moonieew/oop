using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYSHOP
{
    public class Quan : SanPham
    {
        private String sLoaiQuan;

        public string SLoaiQuan { get => sLoaiQuan; set => sLoaiQuan = value; }

        public Quan() : base()
        {

        }

        public Quan(String sMaSP, String sTenSP, int iSoluong, String sSize, String sMau, String sLoaiSP, String sLoaiQuan, double dGiaTien) : this()
        {
            this.SMaSP = sMaSP;
            this.STenSP = sTenSP;
            this.ISoluong = iSoluong;
            this.SSize = sSize;
            this.SMau = sMau;
            this.SLoaiSP = sLoaiSP;
            this.SLoaiQuan = sLoaiQuan;
            this.DGiaTien = dGiaTien;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("     {0,-10}{1,-25}{2,-9}{3,-12}{4,-15}{5, -12}{6,-10}", SMaSP, STenSP, ISoluong, SSize, SMau, SLoaiQuan, DGiaTien);
        }
    }
}
