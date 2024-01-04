using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NE21_291T35TN
{
    //viet code ngoai class
    internal class Program
    {
        //viet code ngoai ham main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //bat dau viet code o day
            //Console.Write("Xin chào, đây là chương trình đầu tiên!. Write");
            //Console.WriteLine("Xin chào, đây là chương trình đầu tiên! WriteLine");
            //Console.Write("Xin chào, đây là chương trình đầu tiên!. Write");

            //Console.Write("Nhap ho ten: ");
            //string ten = Console.ReadLine();

            //Console.WriteLine("Nhap ho ten: ");
            //string tenLine = Console.ReadLine();
            //int t = 10;
            //long l = 10;
            //ushort tuoi = 18; // dấu = được gọi là phép gán
            //ulong a = 10;
            //uint b = 20;

            //float sothuc = 3.14f;
            //double sothuc1 = 3.14D;

            //char c = 'a';
            //string hoten = "Nguyen Van A";

            //bool yes = true; //false

            const int tuoi = 30;
            Console.WriteLine("Năm nay tôi " + tuoi);

            tuoi = 19;
            Console.WriteLine("Năm sau tôi được {0} {1} {2} tuoi", tuoi, tuoi + 1, tuoi + 2);

            tuoi = tuoi + 10;
            Console.WriteLine("10 năm sau tôi được " + tuoi + " tuổi");

            Console.ReadKey();
        }
        //viet code o day
    }
    //viet code o day
}