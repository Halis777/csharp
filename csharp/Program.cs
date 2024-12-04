using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.50;
            double dolarBugun = 7.50;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            
            else if (dolarDun<dolarBugun) 
            {
                    Console.WriteLine("Artış Butonu");
            }
            else 
            { 
            Console.WriteLine("Eşittir Butonu");
            }

            bool sistemeGirisYapmismi = false;

            if (sistemeGirisYapmismi == true)
            {             
                Console.WriteLine("Kullanıcı ayarları butonu");
            } 
            else
            {
                Console.WriteLine("Giriş yap butonu ");
            }          
        }
    }
}
