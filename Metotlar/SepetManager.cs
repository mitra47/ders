using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {


            Console.WriteLine("Tebrikler Sepete Eklendi : " + urun.Adi + " : " + urun.Fiyati);

        }

        public void Ekle2(string urunAdi,string urunAciklamasi,int urunFiyati,int urunStokAdedi)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi : " + urunAdi + " : " + urunAciklamasi + " : " + urunFiyati + " : " + urunStokAdedi);
        }
    }
}
