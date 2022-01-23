using System;
using System.Collections.Generic;
using System.Text;

namespace DoHoa
{
    class ComplexObject:Hinh
    {
        protected List<Hinh> dsHinh;
        //properties
        public List<Hinh> DSHinh
        {
            get { return this.dsHinh; }
            set { this.dsHinh = value; }
        }
        //constructor
        public ComplexObject()
        {
            this.dsHinh = new List<Hinh>();
        }
        public ComplexObject(List<Hinh>dsHinh)
        {
            this.dsHinh = dsHinh;
        }
        //finalizers
        ~ComplexObject()
        { }
        //methods
        public override void Xuat()
        {
            /*foreach (Hinh h in dsHinh)
            {
                h.Xuat();
            }*/
            base.Xuat();
        }
        public void CapNhatDiem()
        {
            int x1,y1;
            int x2,y2;
            x1 = this.dsHinh[0].DiemA.X;
            y1= this.dsHinh[0].DiemA.Y;
            x2 = this.dsHinh[0].DiemB.X;
            y2 = this.dsHinh[0].DiemB.Y;
            foreach (Hinh h in dsHinh)
            {
                if (h.DiemA.X < x1)
                    x1 = h.DiemA.X;
                if (h.DiemA.Y < y1)
                    y1 = h.DiemA.Y;
                if (h.DiemB.X < x1)
                    x1 = h.DiemB.X;
                if (h.DiemB.Y < y1)
                    y1 = h.DiemB.Y;
                if (h.DiemA.X > x2)
                    x2 = h.DiemA.X;
                if (h.DiemA.Y > y2)
                    y2 = h.DiemA.Y;
                if (h.DiemB.X > x2)
                    x2 = h.DiemB.X;
                if (h.DiemB.Y > y2)
                    y2 = h.DiemB.Y;
            }
            this.A = new Diem(x1, y1);
            this.B = new Diem(x2, y2);
        }
        public override void DoiMau(int x)
        {
            foreach(Hinh h in dsHinh)
            {
                h.DoiMau(x);
            }
        }
        public void Add(Hinh A)
        {
            this.dsHinh.Add(A);
        }
    }
}
