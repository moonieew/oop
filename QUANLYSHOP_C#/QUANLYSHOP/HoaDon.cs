using System;
using System.Collections.Generic;
using System.Text;

namespace QUANLYSHOP
{
    public class HoaDon
    {
        private string id;
        private DateTime date;
        private NhanVien manv;
        private double tongtien;

        private List<SanPham> lSanphammua;

        public int[] soluongmua;

        public string Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public NhanVien Manv { get => manv; set => manv = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
        public List<SanPham> LSanphammua { get => lSanphammua; set => lSanphammua = value; }

        public HoaDon(string id, DateTime date)
        {
            this.lSanphammua = new List<SanPham>();
            this.soluongmua = new int[100];

            this.id = id;
            this.date = date;
            this.tongtien = 0;
        }
        public HoaDon()
        {
            this.lSanphammua = new List<SanPham>();
            this.soluongmua = new int[100];
        }
        


    }
   
    

}
