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
            ////cach 1:
            //int[] array1 = new int[5];
            //array1[0] = 10;
            //array1[1] = 20;
            //array1[2] = 30;
            //array1[3] = 40;
            //array1[4] = 50;

            //int sum1 = 0;

            //for (int i = 0; i < array1.Length; i++) sum1 += array1[i];
            ////su dung them ham while
            //Console.WriteLine("Sum1 = {0}",sum1);

            ////cach 2:
            //int[] array2 = new int[] { 10, 20, 30, 40, 50 };

            //int sum2 = 0;

            //foreach (var item in array2) sum2 += item;

            //Console.WriteLine("Sum2 = {0}", sum2);

            ////cach 3:
            //int[] array3 = { 10, 20, 30, 40, 50 };

            //Console.WriteLine("Sum3 = {0}", array3.Max());

            //Console.Write("Nhap so luong phan tu n = ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array = new int[n];

            ////nhap phan tu cho mang
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write("Nhap vao phan tu thu {0} = ", i);
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine();
            ////xuat mang - duyet mang
            //Console.WriteLine("Mang vua nhap la:");
            //foreach (var item in array)
            //{
            //    Console.Write("{0}\t", item);
            //}

            ////sap xep tang dan
            ////Array.Sort(array);
            //Console.WriteLine();
            //Console.WriteLine();
            ////xuat mang - duyet mang
            //Console.WriteLine("Mang vua sap xep la:");
            //foreach (var item in array)
            //{
            //    Console.Write("{0}\t", item);
            //}
            //Console.WriteLine();

            //Console.WriteLine("Gia tri bat dau = {0}", array[0]);
            //Console.WriteLine();
            ////xuat mang - duyet mang
            //Console.WriteLine("Mang giam dan:");
            //for (int i = array.Length - 1; i >= 0 ; i--)
            //{
            //    Console.Write("{0}\t", array[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Gia tri bat dau = {0}", array[0]);
            //Array.Reverse(array);
            ////xuat mang - duyet mang
            //Console.WriteLine("Mang giam dan:");
            //foreach (var item in array)
            //{
            //    Console.Write("{0}\t", item);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Gia tri bat dau = {0}", array[0]);

            Console.Write("Nhap vao so hang n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao so cot m = ");
            int m = int.Parse(Console.ReadLine());

            int[,] matran = new int[n,m];

            //xu ly nhap cho ma tran
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Nhap phan tu thu {0}x{1} = ",i,j);
                    matran[i,j] = int.Parse(Console.ReadLine());
                }
            }

            //xu ly xuat cho ma tran
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", matran[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}