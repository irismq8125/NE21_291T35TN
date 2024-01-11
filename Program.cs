using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NE21_291T35TN
{
    internal class Program
    {
        //viet ham o day
        //viet ham hien thi ten
        protected static void HienThiTen(string ten = "a")
        {
            Console.WriteLine("Xin chao, toi ten la {0}", ten);
            return;
        }

        //protected static void HienThiTen(string ten = "a") => Console.WriteLine("Xin chao, toi ten la {0}", ten);

        private static double TinhThuong(int a, int b)
        {
            double c = (double)a / b;
            return c;
            //return (double)a / b;
        }

        private static void TinhThuong1(int a, int b, out double s) 
        {
             s = (double)a / b;
        }
        
        
        static void Main(string[] args)
        {
            //goi ham trong ham main
            //Console.Write("Nhap ho va ten: ");
            //string hoten = Console.ReadLine();
            //HienThiTen(hoten);

            Console.Write("Nhap vao so a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so b = ");
            int b = int.Parse(Console.ReadLine());

            double c = TinhThuong(a, b);
            Console.WriteLine("Thuong 2 so la {0}", c);

            Console.WriteLine("Thuong 2 so la {0}", TinhThuong1(a, b));



            //int n = 10;

            ////vi du di tu 1 den n = 10
            //for (int i = 1; i <= n; i++) Console.Write("{0}\t", i);

            //Console.WriteLine();

            ////vi du di tu n = 10 den 1
            //for (int i = n; i > 0; i--) Console.Write("{0}\t", i);



            ////Yc: tinh tong cac so le tu 1 den n
            //int tong = 0;
            //int tong1 = 0;
            //for (int i = 1; i <= n; i++) // i+=2
            //{
            //    if(i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //        tong += i; // tong = tong + i;
            //    }
            //}
            //Console.Write("Tong cac so tu 1 den {0} = {1}", n, tong);

            //Console.WriteLine();

            //for (int i = 1; i <= n; i+=2) tong1 += i;

            //Console.Write("Tong cac so tu 1 den {0} = {1}", n, tong1);

            //int i = 1;

            //while (true)
            //{
            //    Console.Write("Nhap gia tri n = ");
            //    int n = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write("{0}\t", i);
            //    }

            //    //dieu kien dung chuong trinh
            //    Console.WriteLine("Nhap N de Thoat chuong trinh!");
            //    ConsoleKeyInfo key = Console.ReadKey();
            //    if (key.Key == ConsoleKey.N) break;
            //    Console.Clear();
            //}

            //chay tu 0 -> 9
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i == 2) break;
            //    Console.WriteLine(i);
            //}

            Console.ReadKey();

        }
        //viet ham o day
    }
}