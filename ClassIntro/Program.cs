internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        Kurs kurs1 = new Kurs();
        
        kurs1.KursAdi = "c#";
        kurs1.Egitmen = "Engin Demirog";
        kurs1.IzlenmeOrani = 68;

        Kurs kurs2 = new Kurs();

        kurs2.KursAdi = "java";
        kurs2.Egitmen = "Kerem Varis";
        kurs2.IzlenmeOrani = 64;

        Kurs kurs3 = new Kurs();

        kurs3.KursAdi = "python";
        kurs3.Egitmen = "Berkay Bilgin";
        kurs3.IzlenmeOrani = 80;

        //Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmen);

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }
        
        public int IzlenmeOrani { get; set; }


    }

}