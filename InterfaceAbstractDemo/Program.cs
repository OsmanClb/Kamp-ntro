using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            Customer customer = new Customer();

            customer.FirstName = "Osman";
            customer.LastName = "Çelebi";
            customer.DateOfBirth = new DateTime(1000,5,29);
            customer.Id = 123;
            customer.NationalityId = "30046860040";

            customerManager.Save(customer);
            Console.ReadLine();

        }
    }
}