using Methotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        string urununAdi = "elma";
        double fiyati = 15;
        string aciklama = "amasya elması";

        string[] meyveler = new string[] { };

        Urun urun1 = new Urun();
        urun1.Adi = "elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "amasya elması";

        Urun urun2 = new Urun();
        urun2.Adi = "karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "diyarbakır karpuzu";

        Urun[] urunler = new Urun[] {urun1,urun2,};

        //type safe -- tip güvenli
        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("-----------------");
        }
        Console.WriteLine("------------Methotlar------------");

        //instance -- class örneği oluşturmak,
        //encapsulation
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);

        sepetManager.Ekle2("armut","yeşil armut", 12,10);
        sepetManager.Ekle2("elma", "yeşil elma", 12,9);
        sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 12,8);

    }
}