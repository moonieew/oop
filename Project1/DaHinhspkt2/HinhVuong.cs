using System;
using System.Collections.Generic;
using System.Text;

namespace DoHoa
{
    class HinhVuong:Hinh
    {
        private double chieuDai;

        public double ChieuDai { get => chieuDai; set => chieuDai = value; }

        public HinhVuong() : base()
        { }
        public HinhVuong(Diem a, Diem b, int mausac) : base(a, b, mausac)
        {
        }
        public HinhVuong(Diem a, Diem b) : base(a, b)
        { }
        ~HinhVuong()
        { }
        public override void Ve(Diem a, Diem b, int mausac)
        {
            base.Ve(a, b, mausac);
        }
        public override void Ve(Diem a, Diem b)
        {
            base.Ve(a, b);
        }
        public override void Ve()
        {
            base.Ve();
            LoaiHinh = "HV";
        }
        public override void Xuat()
        {
            Console.WriteLine("Hinh Vuong");
            base.Xuat();
            Hinh h = new Hinh(A, B);
            h.TinhKhoangCach();
            this.dienTich = h.KhoangCach * h.KhoangCach;
            Console.WriteLine("dien tich : " + this.dienTich);
        }
        public override void DiChuyen()
        {
            base.DiChuyen();
        }
        public override void DiChuyen(Diem A, Diem B)
        {
            base.DiChuyen(A, B);
            TinhDienTich();
        }
        public override void DoiMau()
        {
            base.DoiMau();
        }
        public override void DoiMau(int x)
        {
            base.DoiMau(x);
        }
        /*public void tinhDoDai()
        {

            Hinh h = new Hinh(this.A, this.B);
            h.TinhKhoangCach();
            Console.WriteLine(h.KhoangCach);
            this.ChieuDai = h.KhoangCach;
        }*/
        public override void TinhDienTich()
        {
            this.dienTich = this.ChieuDai * this.ChieuDai;
            
           
        }
    }
}
