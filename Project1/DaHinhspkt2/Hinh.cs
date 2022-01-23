using System;
using System.Collections.Generic;
using System.Text;

namespace DoHoa
{
    class Hinh
    {
        //fields
        private List<Hinh> lHinh;
        private string loaiHinh;
        protected Diem A;
        protected Diem B;
        protected int mauSac;
        protected double dienTich;
        private double dKhoangCach;
        //properties
        public Diem DiemA
        {
            get { return this.A; }
            set{ this.A = value; }
        }
        public Diem DiemB
        {
            get { return this.B; }
            set { this.B = value; }
        }
        public int MauSac
        {
            get { return this.mauSac; }
            set { this.mauSac = value; }
        }
        public double DienTich
        {
            get { return this.dienTich; }
            set { this.dienTich = value; }
        }

        public List<Hinh> LHinh { get => lHinh; set => lHinh = value; }
        public string LoaiHinh { get => loaiHinh; set => loaiHinh = value; }
        public double KhoangCach { get => dKhoangCach; set => dKhoangCach = value; }

        //constructors
        public Hinh()
        {

        }
        public Hinh(Diem A,Diem B)
        {
            this.A = A;
            this.B = B;
           
        }
        public Hinh(Diem A, Diem B,int MauSac)
        {
            this.A = A;
            this.B = B;
            this.mauSac = MauSac;
        }
        //finalizers
        ~Hinh()
        { }
        //methods
        public virtual void Ve()
        {
            
            A = new Diem();
            A.Nhap();
            Console.WriteLine(this.A.X + "   " + this.A.Y);
            B = new Diem();
            B.Nhap();
            Console.Write("Nhap mau sac: ");
            mauSac = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Ve(Diem a, Diem b)
        {
            this.A = a;
            this.B = b;
        }
        public virtual void Ve(Diem a, Diem b,int mausac)
        {
            this.A = a;
            this.B = b;
            this.mauSac = mausac;
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Loai hinh " + LoaiHinh);
            Console.WriteLine("Diem A");
            A.Xuat();
            Console.WriteLine("Diem B");
            B.Xuat();
            Console.WriteLine("Mau sac: "+this.mauSac);
            
            
        }
        public virtual void TinhDienTich()
        {
            
        }
        public virtual void DiChuyen()
        {
            Console.WriteLine("Thay doi toa do");
            //this.A = new Diem();
            this.A.Nhap();
            //this.B = new Diem();
            this.B.Nhap();
        }
        public virtual void DiChuyen(Diem A,Diem B)
        {
            this.A = A;
            this.B = B;
        }
        public virtual void DoiMau()
        {
            Console.WriteLine("Nhap mau");
            this.mauSac = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void DoiMau(int x)
        {
            this.mauSac = x;
        }
        public void  TinhKhoangCach()
        {
            this.KhoangCach = Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }
    }
}
