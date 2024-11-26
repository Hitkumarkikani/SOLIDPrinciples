using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Item {  get; set; }
    }
   
    public class TotalPrice
    {
        public int Totalprice(Customer customer)
        {
            return customer.Item * 1500;
        }
    }

    public class CustomerRepo
    {
        public void save(Customer customer)
        {
            Console.WriteLine($"Customer {customer.Name} saved to database.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 :- Single Reponibility Principle :->");
            Console.WriteLine("");
            Customer customer = new Customer
            {
                Name = "Heet",
                City = "Surat",
                Item = 5,
            };
            Console.WriteLine("Customer Detail:->");
            Console.Write($"Customer Name :- {customer.Name} \nCustomer City Name :- {customer.City} \nTotal Item :-  {customer.Item}\n");

            TotalPrice price = new TotalPrice();
            int Total = price.Totalprice(customer);
            Console.WriteLine($"Total Price :- {Total}");
            Console.WriteLine("");

            CustomerRepo customerRepo = new CustomerRepo();
            customerRepo.save(customer);

            Console.WriteLine("");

        }
    }
}