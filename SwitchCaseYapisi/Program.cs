namespace SwitchCaseYapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Sayıyı Giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2.Sayıyı Giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen İşlem Türü Giriniz: ");
            Console.WriteLine("toplama=1, çıkarma=2, çarpma=3, bölme=4");
            int islem = int.Parse(Console.ReadLine());

            // switch yapısında int deger kontrol edilir

            switch (islem)
            {
                case 1 : Console.WriteLine("Cevap: " + (sayi1 + sayi2)); break;
                case 2 : Console.WriteLine("Cevap: " + (sayi1 - sayi2)); break;
                case 3 : Console.WriteLine("Cevap: " + (sayi1 * sayi2)); break;
                case 4 : Console.WriteLine("Cevap: " + (sayi1 / sayi2)); break;

                default: Console.WriteLine("Yanlış Deger Girdiniz...");
                break;
            }



        }
    }
}