﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
    internal class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler.sepete eklendi!" + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int StokAdedi)
        {
            Console.WriteLine("Tebrikler.sepete eklendi!" + urunAdi);
        }
    }
}