using System;
using System.Collections.Generic;
using System.Text;

namespace Week3
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : "+ product.UrununAdi);
        }
        public void Ekle2(string urunadi,string urunaciklamasi,double urunfiyat,int stokadeti)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : "+ urunadi);
        }
    }
}
