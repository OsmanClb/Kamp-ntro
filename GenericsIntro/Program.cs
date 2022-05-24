namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();  // string veri tipini kendimiz belirledik.

            isimler.Add("Engin");
            isimler.Add("Osman");
           

            Console.WriteLine(isimler.Count);


            //List<string> liste = new List<string> { "Osman", "Ali", "Mehmet" };

            //Console.WriteLine(liste[1]);




        }
    }
}