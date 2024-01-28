using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NE21_291T35TN
{
    public class ConNguoi
    {
        private int NamSinh;
        private string GioiTinh;
        public string HoTen {  get; set; }

        public ConNguoi()
        {
            
        }

        public ConNguoi(string HoTen)
        {
            this.HoTen = HoTen;
            NamSinh = 2024;
            GioiTinh = "GioiTinh???";
        }

        public void setNamSinh(int NamSinh)
        {
             this.NamSinh = NamSinh;
        }
        public int getNamSinh()
        {
            return this.NamSinh;
        }

        public void HienThiTen()
        {
            Console.WriteLine("Ho ten cua toi la: {0}", HoTen);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var conNguoi = new ConNguoi();

            conNguoi.HoTen = "Nguyen Van A";
            conNguoi.setNamSinh(2000);

            conNguoi.HienThiTen();
            Console.WriteLine("Nam sinh la: {0}", conNguoi.getNamSinh());

            Console.ReadKey();
        }
    }
}