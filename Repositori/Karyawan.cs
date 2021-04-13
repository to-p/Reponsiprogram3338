using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsiprogram3338
{
    class Karyawan
    {
        public Karyawan(string nik, string nama, int gajibulanan)
        {
            if (gajibulanan < 0)
            {
                gajibulanan = 0;
            }
            else
            {
                gajibulanan = gajibulanan;
            }

            Nik = nik;

            Nama = nama;

            GajiBulanan = gajibulanan;

            int kenaikan = gajibulanan * 10 / 100;
            int gaji = kenaikan + gajibulanan;

            Gaji = gaji;
        }
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public int Gaji { get; set; }

        public void CetakGaji()
        {
            Console.WriteLine("{0} {1}       {2}", Nik, Nama, GajiBulanan);

        }
        public void CetakKenaikan()
        {
            Console.WriteLine("{0} {1}       {2}", Nik, Nama, Gaji);
        }
    }
}
