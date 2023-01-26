using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Başlangıç Kampı";
            string kurs3 = "Java Kampı";
            string kurs4 = "Python";
            string kurs5 = "JavaScript";

            string[] kurslar = new string[]
            {
                "Yazılım Geliştirici Kampı",
                "Programlamaya Başlangıç Kampı ",
                "Java Kampı",
                "Python",
                "JavaScript",
                "C#"
            };
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("--For Bitti--");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("--Sayfa Sonu--");
            
        }
    }
}