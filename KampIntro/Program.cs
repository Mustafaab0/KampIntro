using System;

namespace KampIntro
{

    class Program
    {


        static void Main(string[] args)
        {
            String kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");    
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            
            
        }
    }
}