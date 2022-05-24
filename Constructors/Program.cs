namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constructors = bir classı newlediğimiz zaman çalışan bloktur yani bir class ilk kez oluştuğu zaman bir kere çalışır ve bir daha çalışmaz.

            Customer customer1 = new Customer { Id = 1, FirsName = "Engin", LastName = "Demiroğ", City = "Ankara" };//1.yazım şekli
            Customer customer2 = new Customer (2,"Derin","Demiroğ","Ankara"); // 2. yazım sekli

            Console.WriteLine(customer2.FirsName);
        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        
        
        public Customer(int id , string firstName, string lastName, string city)   //ctor yazıp tab iki kere bas ve custructors bırak.
        {
            FirsName = firstName;
            LastName = lastName;
            City = city;
            Id = id;

        }


        public int Id { get; set; }
        public string FirsName  { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}