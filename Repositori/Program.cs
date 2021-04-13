using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiprogram3338
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            header();

            Karyawan karyawan1 = new Karyawan("20113338", "Paijo", 50000000);
            Console.Write("1. ");
            karyawan1.CetakGaji();

            //membuat objek Karyawan2
            Karyawan karyawan2 = new Karyawan("20113339", "Jono", 3000000);
            Console.Write("2. ");
            karyawan2.CetakGaji();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Asik ada kenaikan gaji 10% ");
            Console.WriteLine();
            header();
            Console.Write("1. ");
            karyawan1.CetakKenaikan();
            Console.Write("2. ");
            karyawan2.CetakKenaikan();


        }
        static void header()
        {
            Console.WriteLine("NIK/Nama                 Gaji");
            Console.WriteLine("--------------------------------");
        }
    }
}
