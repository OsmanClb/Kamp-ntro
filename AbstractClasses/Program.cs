namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MevzuatBase mevzuatBase = new Amevzuat();
            MevzuatBase mevzuatBase1 = new Bmevzuat();

            mevzuatBase.Degerlendir();
            mevzuatBase1.Degerlendir();



        }
    }
}