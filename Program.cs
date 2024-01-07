using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NE21_291T35TN
{
    internal class Program
    {
        //khoi tao the sinh vien
        struct ThongTinHocSinh
        {
            public string HoTen { get; set; }
            public string DiaChi { get; set; }
            public float DTB { get; set; }

            //public ThongTinHocSinh() { }
            //duoc goi la ham khoi tao
            public ThongTinHocSinh(string hoten, string diachi, float dtb) //tham so
            {
                this.HoTen = hoten;
                this.DiaChi = diachi;
                this.DTB = dtb;
            }
        }
        static void Main(string[] args)
        {
            //int tuoi = 18;
            //Console.WriteLine("Tuoi {0}", tuoi);
            ////tuoi = tuoi - 10; // 18 + 10 == 28
            ////tuoi += 10; // tuoi = tuoi % 10

            //tuoi += 1;
            //tuoi -= 1;
            //tuoi *= 1;
            //tuoi /= 1;
            //tuoi %= 1;
            //Console.WriteLine("Tuoi {0}", tuoi);

            //tuoi++; // tuoi += 1; tuoi = tuoi + 1;
            //tuoi--;

            //++tuoi;
            //--tuoi;

            //int bienA = 10;
            //int bienB = 3; //3.000000000

            //string A = "1";

            //int bienC = int.Parse(A) / bienB; //phep lay phan nguyen
            //Console.WriteLine("Bien C = {0}", bienC);

            //int bienD = bienA % bienB; //phep lay phan du
            //Console.WriteLine("Bien D = {0}", bienD);

            //double bienE =  bienA / (float)bienB; // float/int = float; int/float = float;
            //Console.WriteLine("Bien E = {0}", bienE);

            ////int * float|double = float|double
            //double bienF =  bienA / (bienB * 1.0); // float/int = float; int/float = float;
            //Console.WriteLine("Bien F = {0}", bienF);

            //Console.Write("Nhap vao so nguyen A = ");
            //int soNguyenA = int.Parse(Console.ReadLine());

            //Console.Write("Nhap vao so nguyen B = ");
            //int soNguyenB = int.Parse(Console.ReadLine());

            //int tong = soNguyenA + soNguyenB;
            //Console.WriteLine("Tong 2 so la {0}", tong);
            //Console.WriteLine("Tong 2 so {0} + {1} = {2}", soNguyenA, soNguyenB, soNguyenA + soNguyenB);

            //float thuong = (float)soNguyenA / soNguyenB;
            //Console.WriteLine("Thuong 2 so la {0}", thuong);
            //Console.WriteLine("Thuong 2 so {0} / {1} = {2}", soNguyenA, soNguyenB, (double)soNguyenA / soNguyenB);
            //Console.WriteLine("So nguyen A vua nhap la {0}", soNguyenA);
            //Console.WriteLine("So nguyen B vua nhap la {0}", soNguyenB);

            //int a = 10; //bien
            //const int b = 10; //hang
            //ThongTinHocSinh hocSinh1 = new ThongTinHocSinh(); //Object - doi tuong
            //hocSinh1.HoTen = "Nguyen Van A";
            //hocSinh1.DiaChi = "HCM";
            //hocSinh1.DTB = 7.6f;

            //ThongTinHocSinh hocSinh2 = new ThongTinHocSinh("Nguyen Van A","HCM",9.6f);

            //Console.WriteLine("DTB cua HS1: {0}", hocSinh1.DTB);
            //Console.WriteLine("DTB cua HS2: {0}", hocSinh2.DTB);

            double y = Math.Pow(2, 2);

            string op = "abc";
            
            Console.WriteLine("Gia tri cua y = {0}", y);
            Console.WriteLine("Do dai cua op = {0}", op.Length);

            Console.ReadKey();
        }
    }
}