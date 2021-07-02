using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(1,"Rafet","Ersoy",21,2000);
            Musteri musteri2 = new Musteri(2,"Salih","SS",20,2001);
            Musteri musteri3 = new Musteri(3,"Berkay","BB",21,2000);

            Musteri[] musteriler = { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine();
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine();
            musteriManager.MusteriEkle(musteri3);
            Console.WriteLine();
            
            musteriManager.MusterileriListele(musteriler);

            musteriManager.MusteriSil(musteri1);

        }
    }

}
