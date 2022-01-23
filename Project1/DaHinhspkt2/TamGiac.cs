using System;
using System.Collections.Generic;
using System.Text;

namespace DoHoa
{
    class TamGiac:Hinh
    {
        private double dCanhDay;
        private double dChieuCao;
        private Diem C;

        public Diem C1 { get => C; set => C = value; }
        public double CanhDay { get => dCanhDay; set => dCanhDay = value; }
        public double ChieuCao { get => dChieuCao; set => dChieuCao = value; }

        public TamGiac() : base()
        {
            this.C = new Diem();
        }
        public TamGiac(Diem a, Diem b, int mausac) : base(a,b,mausac)
        {
            this.C = C;
        }
        public TamGiac(Diem a, Diem b) : base(a, b)
        { }
        ~TamGiac()
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
            C.Nhap();
            LoaiHinh = "TG";
        }
        public override void Xuat()
        {
            Console.WriteLine("Tam giac");
            base.Xuat();
            Console.WriteLine("Diem C");
            C.Xuat();
            Hinh h = new Hinh(this.A, this.B);
            h.TinhKhoangCach();
            this.CanhDay = h.KhoangCach;
            double dt = Math.Abs((A.X - B.X) * (C.Y - A.Y) - (C.X - A.X) * (B.Y - A.Y));
            this.ChieuCao = dt / this.CanhDay;
            this.dienTich = this.CanhDay * this.ChieuCao * 0.5;
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
            this.dienTich = this.CanhDay * this.ChieuCao*0.5;
           
        }
    }
}
