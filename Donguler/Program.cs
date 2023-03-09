using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım kursu";
            string kurs2 = "programlama baslangıc";
            string kurs3 = "java";
            string kurs4 = "python";


            string[] kurslar = new string[] {
            "yazılım kursu","programlama baslangıc",
            "java","python"
            };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa  sonu - footer");
        }
    }
}
