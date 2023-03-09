using System;

namespace YazilimGelistiriciYetistirmeKampi2.GunEngindemirog
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety - tip güvenliği
            // alias - değertutucu

            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35, dolarBugun = 7.45;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("sabit");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);

        }
    }
}
