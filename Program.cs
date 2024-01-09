using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NE21_291T35TN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hien thi cac so tu 1 den 1000;

            //int a = 5;
            ////int b = a++;

            //int b = ++a;

            //Console.WriteLine(b);
            //Console.WriteLine(a);
            //tinh tong cac so chia het cho 5 hoac chia het cho 7???
            int tong = 0;
            for (int i = 1; i <= 100; i = i + 2)
            {
                if(i % 5 == 0 || i % 7 == 0)
                {
                    Console.WriteLine(i);
                    tong += i;
                }
                //tong = tong + i;
            }
            Console.WriteLine("Tong day so chan la {0}", tong);

            //menu chuc nang
            //1. cho phep nhap thong tin
            //2. cho phep xoa thong tin
            //3. cho phep sua thong tin
            //4. cho phep tim kiem thong tin
            //5. cho phep hien thi danh sach thong tin
            //Moi chon chuc nang: 5

            //Yc: nhap vao thang bat ky, hien thi so ngay trong thang vua nhap.
            //thang 2: 28 29 ngay
            //thang 4 6 9 12: 30 ngay
            //thang 1 3 5 7 8 11: 31 ngay
            //int thang = 2;

            //if (thang == 2) Console.Write("Co 28 hoac 29 ngay");
            //if (thang == 4 || thang == 6 || thang == 9 || thang == 12) Console.Write("Co 30 ngay");
            //if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 11) Console.Write("Co 31 ngay");

            //switch (thang)
            //{
            //    case 1: case 3: case 5: case 7: case 8: case 11:
            //        Console.Write("Co 31 ngay");
            //        break;
            //    case 2:
            //        Console.Write("Co 28 hoac 29 ngay");
            //        break;
            //    default:
            //        Console.Write("Co 30 ngay");
            //        break;
            //}

            //Console.Write("Moi nhap so nguyen n = ");
            //int n = int.Parse(Console.ReadLine());

            //switch (n)
            //{
            //    case 3:
            //    //Console.Write("Hinh tam giac");
            //    //break;
            //    case 4:
            //        Console.Write("Hinh tu giac");
            //        break;
            //    default:
            //        Console.Write("Gia tri khong hop le");
            //        break;
            //}
            //if (n == 3) Console.Write("Hinh tam giac");
            //if (n == 4) Console.Write("Hinh tu giac");
            //if (n == 3 || n == 4) Console.Write("Hinh tu giac");


            //dieu kien if loai 1
            //dieu kien la n >= 0
            //if (n >= 0)
            //{ //danh dau bat dau khoi lenh
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //    Console.WriteLine("Gia tri vua nhap vao lon hon 0");
            //} //danh dau ket thuc khoi lenh
            //if (n >= 0) Console.WriteLine("Gia tri vua nhap vao lon hon 0"); 

            //Console.WriteLine("Gia tri vua nhap vao lon hon 0");

            //dieu kien if loai 2 hay if day du
            //DK1: n >= 0
            //DK2: n chia het cho 2 hay khong? 4 % 2 = 0
            //if (n >= 0 && n % 2 == 0)
            //{
            //    if (n % 2 == 0) //DK chia het cho 2
            //    {
            //        Console.WriteLine("Gia tri vua nhap vao lon hon 0 va chia het cho 2");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Gia tri vua nhap vao lon hon 0 va khong chia het cho 2");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Gia tri vua nhap vao nho hon 0");
            //}
            //int a = 10;
            //int b = 20;
            //int c = --a + b--; // --a = a = a - 1, b-- = b = b - 1
            //////chuyen if loai 2 ve if loai 1
            //string noidung = "Gia tri vua nhap vao lon hon 0";
            //if (n < 0) noidung = "Gia tri vua nhap vao nho hon 0";
            //Console.WriteLine(noidung);

            //Console.WriteLine( n >= 0 ? "Gia tri vua nhap vao lon hon 0" : "Gia tri vua nhap vao nho hon 0");
            //Console.WriteLine(noidung ?? "Gia tri vua nhap vao lon hon 0");

            //if(noidung is null)
            //{
            //    noidung = "Gia tri vua nhap vao lon hon 0";
            //}
            //else
            //{
            //    noidung = noidung;
            //}

            Console.ReadKey();
        }
    }
}