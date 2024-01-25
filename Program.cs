using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NE21_291T35TN
{
    public class Demo
    {
        public int LCB { get; set; }
    }
    public class ConNguoi : Demo
    {
        public string Hoten { get; set; }
        //private int Tuoi { get; set;}
    }
    public class SinhVien
    {
        private float DiemTrungBinh;
        public float setDiemTrungBinh(float dtb)
        {
            return DiemTrungBinh  = dtb;
        }
        public void HienThiDiem()
        {
            Console.WriteLine("Hien thi diem");
        }
    }
    public class GiaoVien : ConNguoi
    {
        public float HSL { get; set; } = 1.0f;

        //contructor - ham khoi tao
        public GiaoVien() { }   //mac dinh

        public GiaoVien(float hSL)    //co tham
        {
            HSL = hSL;
        }

    }


    public abstract class Person
    {
        private string Name { get; set; }
        //public abstract string Title { get; set; }
        //public abstract string setName(string name);
        //public abstract string getName();
        public void HienThiName(string name)
        {
            Console.WriteLine("Hien thi ten {0}", name);
        }

        public abstract void HienThiTuoi(int age);
    }

    public class UsePerson : Person
    {
        //public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void HienThiTuoi(int age)
        {
            Console.WriteLine("Hien thi tuoi {0}", age);
        }
    }

    public interface IDemoInterface1
    {
        void HenThiTen(string name);
        int TinhTong(int a, int b);
    }

    public interface IDemoInterface2
    {
        void HenThiTen(string name);
        int TinhTong2(int a, int b);
    }

    public class UseInterface : ConNguoi, IDemoInterface1, IDemoInterface2
    {
        public void HenThiTen(string name)
        {
            Console.WriteLine("Hien thi ten {0}", name);
        }

        public void HenThiTen2(string name)
        {
            throw new NotImplementedException();
        }

        public int TinhTong(int a, int b)
        {
            return a + b;   
        }

        public int TinhTong2(int a, int b)
        {
            throw new NotImplementedException();
        }
    }



    internal class Program
    {
        public static int TinhTong(int a, int b) => a + b;
        public static int TinhTong(int a, int b, int c) => a + b + c;
        public static int TinhTong(int a, int b, int c, int d) => a + b + c + d;

        static void Main(string[] args)
        {
            UseInterface us = new UseInterface();
            us.HenThiTen("ABCD");

            //var gv1 = new GiaoVien();
            //gv1.Hoten = "Nguyen Van A";
            //gv1.LCB = 1000000;

            //Console.WriteLine("{0} - {1} - {2} - {3}", gv1.Hoten, gv1.HSL, gv1.LCB, gv1.LCB * gv1.HSL);

            //var gv2 = new GiaoVien(2.0f);
            //gv2.Hoten = "Nguyen Van B";
            //gv2.LCB = 1000000;

            //Console.WriteLine("{0} - {1} - {2} - {3}", gv2.Hoten, gv2.HSL, gv2.LCB, gv2.LCB * gv2.HSL);

            Console.ReadKey();
        }
    }
}