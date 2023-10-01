using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrununAdi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya Elması";
            product1.Stok = 10;

            Product product2 = new Product();
            product2.UrununAdi = "Karpuz";
            product2.Fiyati = 70;
            product2.Aciklama = "Diyarbakır Karpuzu";
            product2.Stok = 22;

            Product[] productList = new Product[] {product1,product2};
            //Type-Safe ---- Tip Güvenli

            foreach (Product product in productList)
            {
                Console.WriteLine("Ürünün Adı : "+product.UrununAdi);
                Console.WriteLine("Ürünün Fiyatı : " + product.Fiyati);
                Console.WriteLine("Ürünün Açıklaması : " + product.Aciklama);
                Console.WriteLine("---------------------");

            }

            Console.WriteLine("-----------METOTLAR-------------");

            // instance = örnek
            // encapsulation
            SepetManager sepetmananger = new SepetManager();
            sepetmananger.Ekle(product1);
            sepetmananger.Ekle(product2);

            sepetmananger.Ekle2("Erik","Eşek Eriği",23,10);
            sepetmananger.Ekle2("Elma", "Amasya Elması", 15,7);
            sepetmananger.Ekle2("Karpuz", "Diyarbakır Karpuzu", 70,8);



        }
    }
}
