﻿class Program
{
    public static void Main(string[] args)
    {
        string[] kurslar = new string[] 
        {
            "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya Başlangıç Temel Kurs",
            "Java",
            "Python",
            "C#"
        };

        for (int i = 0; i <kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("-------- For Bitti --------");
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("Sayfa Sonu -- FOOTER");
    }
}