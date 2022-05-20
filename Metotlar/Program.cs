namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // metotlar tekrar tekrar kullanılabilirliği sağlayan kod bloklarıdır.
            //dont repeat yourself - kendini tekrar etme

            Urun  urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Acıklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Acıklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            //type-safe -- tip güvenliği
            foreach (Urun  urun in urunler)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Acıklama);
            
            }

            Console.WriteLine("--------Metotlar----------");

            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 15);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 20);

        }
    }
}