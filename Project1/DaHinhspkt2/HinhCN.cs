using System;
using System.Collections.Generic;
using System.Text;

namespace DoHoa
{
    class HinhCN : Hinh
    {
        private double dDai;
        private double dRong;
        private Diem C;

        public Diem C1 { get => C; set => C = value; }
        public double Dai { get => dDai; set => dDai = value; }
        public double Rong { get => dRong; set => dRong = value; }

        public HinhCN() : base()
        {
            this.C = new Diem();
        }
        public HinhCN(Diem A,Diem B) : base(A,B)
        { }
        public HinhCN(Diem A, Diem B, Diem C,int mauSac) : base(A, B,mauSac)
        {
            this.C = C;
        }
        ~HinhCN()
        { }
        public override void Ve(Diem a, Diem b)
        {
            base.Ve(a, b);
        }
        public override void Ve(Diem a, Diem b,int mausac)
        {
            base.Ve(a, b, mausac);
        }
        public override void Ve()
        {
            base.Ve();
            C.Nhap();
            LoaiHinh = "HCN";
        }
        public override void Xuat()
        {
            Console.WriteLine("Hinh chu nhat");
            base.Xuat();
            Console.WriteLine("Diem C");
            C.Xuat();
            Hinh h1 = new Hinh(A, B);
            Hinh h2 = new Hinh(A, C);
            h1.TinhKhoangCach();
            h2.TinhKhoangCach();
            this.Dai = h1.KhoangCach;
            this.Rong = h2.KhoangCach;
            this.dienTich = this.Dai * this.Rong;
            Console.WriteLine("Dien tich: " + this.dienTich);
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
        public override void TinhDienTich()
        {
            this.dienTich = this.Dai * this.Rong;
            
        }
    }
}
