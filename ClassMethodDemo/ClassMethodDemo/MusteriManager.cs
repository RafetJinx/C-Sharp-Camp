using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi." + musteri.ToString());
            
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi." + musteri.ToString());
        }

        public void MusterileriListele(Musteri[] musteriler)
        {
            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri);
                Console.WriteLine("---------------------");
            }
        }
    }
}
