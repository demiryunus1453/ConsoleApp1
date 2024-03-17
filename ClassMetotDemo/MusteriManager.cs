
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager // müşteri ile ilgili işlemler yapan sınıf
    {
        public void MusteriEkleme(Musteri musteri) 
        {
            Console.WriteLine("Müşteri Ekleme Bölümü");

            Console.WriteLine(musteri.Numarasi );
            Console.WriteLine(musteri.Adi );
            Console.WriteLine(musteri.SoyAdi );
            Console.WriteLine(musteri.Meslegi );

        }

        public void MusteriListeleme(Musteri[] musteriler) 
        {
            foreach (var item in musteriler)
            {  
                Console.WriteLine("Müşteri Listeleme Bölümü");
                Console.WriteLine(item.Numarasi );
                Console.WriteLine("***********************");
                Console.WriteLine(item.Adi );
                Console.WriteLine("***********************");
                Console.WriteLine(item.SoyAdi);
                Console.WriteLine("***********************");
                Console.WriteLine(item.Meslegi);
                Console.WriteLine("***********************");

            }
        }

        public void MusteriSilme(Musteri musteri)
        {   
            Console.WriteLine("Müşteri Silme Bölümü");
            Console.WriteLine(musteri.Numarasi );
            Console.WriteLine(musteri.Adi );
            Console.WriteLine(musteri.SoyAdi );
            Console.WriteLine(musteri.Meslegi );
        }
    }
}
