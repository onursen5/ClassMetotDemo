using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Kaydınız oluşturuldu"+musteri.MusteriAd+musteri.MusteriSoyad);
        }
        public void Sil(Musteri musteri2)
        {
            Console.WriteLine("Kaydınız Silindi"+musteri2);
        }
    }
}
