using System;
using System.Collections.Generic;
using System.Text;

namespace DoHoa
{
    class Diem
    {
        //fields
        private int x;
        private int y;
        //properties
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        //constructors
        public Diem()
        { }
        public Diem(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //finalizers
        ~Diem()
        { }
        //method
        public void Nhap()
        {
            Console.Write("Nhap X:");
            this.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap Y:");
            this.y = Convert.ToInt32(Console.ReadLine());
        }
        public void Nhap(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Xuat()
        {
            Console.WriteLine("X= " + this.x);
            Console.WriteLine("Y= " + this.y);
        }
    }
}
