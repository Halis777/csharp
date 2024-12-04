using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici ...";
            string kurs2 = "Programlamaya giriş....";
            string kurs3 = "Java...";
            string kurs4 = "Python";
            string kurs5 = "Csharp";



             
            string[] kurslar = new string[] { "Yazılım geliştirici ...",
                "Programlamaya giriş...."
                , "Java...","Python","Csharp" };

            foreach (string i in kurslar)
            {
                Console.WriteLine(i);
            }
            // for (int i = 0; i <kurslar.Length; i++)
            //{

                //Console.WriteLine(kurslar[i]);
            //}

            //Console.WriteLine("for bitti");
            //foreach (string kurs  in kurslar) 
            //{
             //   Console.WriteLine(kurs);

           // }
            //Console.WriteLine("sayfa sonu - footer");
            
        }
    }
}
