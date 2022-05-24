namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            My_Dictionary<string,int> myDictionary = new My_Dictionary<string,int>();

            
            myDictionary.Add("Osman",21);  // veri ekleme işlemi
            myDictionary.Add("Mehmet",22);
            myDictionary.Add("Ali",32);
            myDictionary.Add("Veli",54);

            for(int i = 0; i < myDictionary.Array.Length; i++)
            {
                Console.WriteLine(myDictionary.Array[i]);
                Console.WriteLine(myDictionary.Array2[i]);
            }


        }
    }
}