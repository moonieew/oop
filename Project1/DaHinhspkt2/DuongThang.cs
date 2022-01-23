using System;
using System.Collections.Generic;
using System.Text;

namespace DoHoa
{
    class DuongThang:Hinh
    {
        public DuongThang():base()
        { }
        public DuongThang(Diem A, Diem B) : base(A, B)
        {

        }
        public DuongThang(Diem A,Diem B,int mauSac):base(A,B,mauSac)
        {

        }
        ~DuongThang()
        { }
        public override void Ve(Diem a, Diem b)
        {
            base.Ve(a,b);
        }
        public override void Ve(Diem a, Diem b, int mausac)
        {
            base.Ve(a, b, mausac);
        }
        public override void Ve()
        {
            base.Ve();
            LoaiHinh = "DT";
        }
        public override void Xuat()
        {
            Console.WriteLine("Duong thang:");
            base.Xuat();
        }
        public override void DiChuyen()
        {
            base.DiChuyen();
        }
        public override void DiChuyen(Diem A, Diem B)
        {
            base.DiChuyen(A, B);
        }
        public override void DoiMau()
        {
            base.DoiMau();
        }
        public override void DoiMau(int x)
        {
            base.DoiMau(x);
        }
    }
}
