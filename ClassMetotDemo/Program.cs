using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.Numarasi = 1;
            musteri1.Adi = "Yunus";
            musteri1.SoyAdi = "Demir";
            musteri1.Meslegi = "Mühendis";


            Musteri musteri2 = new Musteri();

            musteri2.Numarasi = 2;
            musteri2.Adi = "Cevat";
            musteri2.SoyAdi = "Demir";
            musteri2.Meslegi = "Esnaf";


            Musteri musteri3 = new Musteri();

            musteri3.Numarasi = 3;
            musteri3.Adi = "Vahit";
            musteri3.SoyAdi = "Demir";
            musteri3.Meslegi = "Polis";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            //foreach (var item in musteriler)
            //{
            //    Console.WriteLine(item);
            //}
            MusteriManager manager = new MusteriManager();

            manager.MusteriEkleme(musteri1);
            //manager.MusteriEkleme(musteri2);
            //manager.MusteriEkleme(musteri3);

            manager.MusteriSilme(musteri1);
            //manager.MusteriSilme(musteri2);
            //manager.MusteriSilme(musteri3);

            manager.MusteriSilme(musteri1);
            //manager.MusteriSilme(musteri2);
            //manager.MusteriSilme(musteri3);


            manager.MusteriListeleme(musteriler);

            


            Console.ReadLine();
        }
    }
}
