namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //array - dizi

            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç İçin Temel Kurs","Java" };

            for (int i = 0; i < kurslar.Length; i++)   //length eleman sayısını verir.
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar) //dizi temelli yapıları tek tek dönmeye yerıyor
            {
                Console.WriteLine(kurs);
            }
           
            Console.WriteLine("Sayfa Sonu");
        }
    }
}