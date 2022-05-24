namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*
           1)Distionary sınıfı içinde sizin belirliyeceğiniz bir key'e uygun olarak değer saklar
           zorunluluğu var
           2)key türünü belirlemeniz şart (string, int, vs...)
            */
                      //key türü
            Dictionary<string,int> bilgi = new Dictionary<string,int>();

            bilgi.Add("Osman" , 21);  // veri ekliyoruz
            bilgi.Add("Mahmut", 18);
            bilgi.Add("Davut", 55);

            int i = 0;   
            foreach (var item in bilgi) //degerleri ekrana yazdırma
            {
                i++;
                Console.WriteLine(i + ".Kişi Bilgileri : " + item);

            }

            Console.WriteLine("eleman sayısı : " + bilgi.Count);  //deger sayma özl

            bilgi.Remove("Mahmut"); // içinde Mahmut yazan veriyi silicek
            i= 0;   
            foreach (var item in bilgi) //degerleri ekrana yazdırma
            {
                i++;
                Console.WriteLine(i + ".Kişi Bilgileri : " + item);

            }
        }
    }
}