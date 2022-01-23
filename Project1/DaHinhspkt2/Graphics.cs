using System;
using System.Collections.Generic;
using System.Text;

namespace DoHoa
{
    class Graphics
    {
        protected List<Hinh> dsHinh;
        //properties
        public List<Hinh>DSHinh
        {
            get { return this.dsHinh; }
            set { this.dsHinh = value; }
        }
        //constructor
        public Graphics()
        {
            this.dsHinh = new List<Hinh>();
        }
        public Graphics(List<Hinh>dsHinh)
        {
            this.dsHinh = dsHinh;
        }
        //finalizers
        ~Graphics()
        { }
        //methods
        public void Nhap()
        {
            HinhCN hcn = new HinhCN();
            hcn.Ve();
            hcn.TinhDienTich();
            this.dsHinh.Add(hcn);
            /*HinhCN hcn1 = new HinhCN();
            hcn1.Ve();
            hcn1.TinhDienTich();
            this.dsHinh.Add(hcn1);
            HinhCN hcn2 = new HinhCN();
            hcn2.Ve();
            hcn2.TinhDienTich();
            this.dsHinh.Add(hcn2);*/
            TamGiac tg = new TamGiac();
            tg.Ve();
            tg.TinhDienTich();
            this.dsHinh.Add(tg);
            DuongThang dt = new DuongThang();
            dt.Ve();
            this.dsHinh.Add(dt);
        }
        public void Merge()
        {
            Chon t = new Chon(0);
            List<Chon> dsChon=new List<Chon>();
            Console.WriteLine("Chon:(-1 la ngung chon)");
            while(t.GetT!=-1)
            {
                t = new Chon();
                int temp = Convert.ToInt32(Console.ReadLine());
                if (temp == -1)
                    break;
                t.chon(temp);
                dsChon.Add(t);
            }
            ComplexObject hinh = new ComplexObject();
            foreach(Chon h in dsChon)
            {
                hinh.Add(this.dsHinh[h.GetT]);
            }
            hinh.CapNhatDiem();
            this.dsHinh.Add(hinh);
            foreach (Hinh h in hinh.DSHinh)
            {
                this.dsHinh.Remove(h);
            }
        }
        public void Devide()
        {
            Chon t = new Chon();
            t.chon();
            try {
                ComplexObject ds = (ComplexObject)this.dsHinh[t.GetT];
                foreach (Hinh h in ds.DSHinh)
                {
                    this.dsHinh.Add(h);
                }
                this.dsHinh.Remove(ds);
            }
            catch(Exception loi)
            {
                Console.WriteLine("Khong tach hinh duoc");
                Console.WriteLine(loi.Message);
            }  
        }
        public void Xuat()
        {
            foreach(Hinh h in dsHinh)
            {
                h.Xuat();
            }
        }
    }
    class Chon
    {
        private int t;
        public int GetT
        {
            get { return this.t; }
            set { this.t = value; }
        }
        public Chon()
        {

        }
        public Chon(int t)
        {
            this.t = t;
        }
        ~Chon() { }
        public void chon()
        {
            Console.WriteLine("Chon hinh");
            this.t = Convert.ToInt32(Console.ReadLine());
        }
        public void chon(int t)
        {
            this.t = t;
        }
    }
}
