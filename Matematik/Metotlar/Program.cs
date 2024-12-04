using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
                     
            Urun urun1 = new Urun ();
            urun1.Adi = "Elma";
            urun1.fiyati = 15; 
            urun1.aciklama = "Amasya elması";
            urun1.StokAdedi = 131;

            Urun urun2= new Urun ();
            urun2.Adi = "Karpuz";
            urun2.fiyati = 70;
            urun2.aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 431;

            Urun urun3 = new Urun ();
            urun3.Adi = "Çilek";
            urun3.fiyati = 42;
            urun3.aciklama = "İthal Çilek";
            urun3.StokAdedi = 552;

            Urun urun4 = new Urun ();
            urun4.Adi = "Kayısı";
            urun4.fiyati = 23;
            urun4.aciklama = "Malatya Kayısı";
            urun4.StokAdedi = 833;


            Urun[] urunler = new Urun[] {urun1 , urun2, urun3, urun4,};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Meyve:" + urun.Adi); 
                Console.WriteLine("Fiyatı:" +urun.fiyati);
                Console.WriteLine ("Açıklama:" + urun.aciklama);
                Console.WriteLine("Stok: "+urun.StokAdedi);
                Console.WriteLine("-----------------");
                          
            }


            Console.WriteLine("-------METOTLAR----------");
            sepetmanager sepetmanager = new sepetmanager();

            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
            sepetmanager.Ekle(urun3);
            sepetmanager.Ekle(urun4);
            sepetmanager.Ekle(urun4);
            sepetmanager.Ekle2("kayısı", "yeşil", 21);
            sepetmanager.Ekle2("karpuz", "yok", 13);




















        }
    }
}
