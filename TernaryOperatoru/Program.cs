namespace TernaryOperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ternary Operatörü Kullanımı: koşul? doğru ise burası : yanlış ise burası çalışsın
            //ternary kullanımı

            Console.WriteLine("[1-10] arasında sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());

            string cevap = "";

            cevap += sayi == 7 ? "Tebrikler Dogru Bildiniz" : "Yanlıs Cevap"; //koşul? doğru ise burası : yanlış ise burası

            Console.WriteLine(cevap);

            //Coalescing kullanımı
            // Coalescing Kullanımı : değişkenimiz ?? varsayılan değerimiz
            Console.Write("Lütfen yaşınızı giriniz :");
            string yasiniz = Console.ReadLine();
            string sonuc = "";
            //Burada iki operatörü birarada kullanmış olduk 
            //Ternary kullanma amaçımız kullanıcı direkt boş geçerse stringlerde boş değer bir karakter olduğudan
            //Coalescing de bildiğiniz gibi null değer gelirse varsayılan değeri yazdırır.
            sonuc = (yasiniz == "" ? null : yasiniz) ?? "Boş geçildi.";
            Console.WriteLine("Yaşınız :" + sonuc);

        }
    }
}