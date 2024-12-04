using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 43;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Halis Durmuş";
            kurs1.IzlenmeOrani =43;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Durmuş";
            kurs2.IzlenmeOrani = 63;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berk";
            kurs3.IzlenmeOrani = 53;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "SQL";
            kurs4.Egitmen = "Mert";
            kurs4.IzlenmeOrani = 103;
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + "   ;   " + kurs.Egitmen +  "  :  "  + kurs.IzlenmeOrani);
            }
            {

            }
        }
    }
    class  Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
