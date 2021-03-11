using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
                        //KULLANIM ŞEKİLLERİ
                        //1. Kullanım
            Customer customer1 = new Customer {Id=1, FirstName="Soner", LastName="ATEŞ", City="Antalya" };
                        //2. Kullanım
            Customer customer2 = new Customer ( 2, "Murat", "ATICI", "İstanbul" );
            Console.WriteLine("ID :" +customer2.Id);
            Console.WriteLine("İSİM :" +customer2.FirstName);
            Console.WriteLine("SOYAD :" + customer2.LastName);
            Console.WriteLine("ŞEHİR :" + customer2.City);


        }
    }
    class Customer
    {
                    //2. Kullanım Parametresi
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
                    //1. Kullanım Parametresi
        //default Constructor
        public Customer()
        {
           
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
