using System;
using System.Collections.Generic;
using System.Text;

namespace DoHoa
{
    class HinhTron:Hinh
    {
        private double banKinh;

        public double BanKinh { get => banKinh; set => banKinh = value; }

        public HinhTron() : base()
        { }
        public HinhTron(Diem a, Diem b, int mausac) : base(a, b, mausac)
        {
            this.tinhBanKinh();
        }
        public HinhTron(Diem a, Diem b) : base(a, b)
        { }
        ~HinhTron()
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
            LoaiHinh = "HT";
        }
        public override void Xuat()
        {
            Console.WriteLine("Hinh Tron");
            base.Xuat();
            Hinh h = new Hinh(A, B);
            h.TinhKhoangCach();
            this.dienTich = h.KhoangCach * h.KhoangCach*3.14;
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
        public void tinhBanKinh()
        {
            Hinh h = new Hinh(this.A, this.B);
            h.TinhKhoangCach();
            this.BanKinh = h.KhoangCach;
        }
        public override void TinhDienTich()
        {
            this.dienTich = this.BanKinh * this.BanKinh * 3.14;
        }
            
    }
}

