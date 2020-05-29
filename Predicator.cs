using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.Models;

namespace LeetCode
{
    public class Predicator
    {
        public static void Predicate1()
        {
            var customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Joydip", LastName = "Kanjilal", State = "Telengana", City = "Hyderabad", Address = "Begumpet", Country = "India" });
            customers.Add(new Customer { Id = 2, FirstName = "Steve", LastName = "Jones", State = "OA", City = "New York", Address = "Lake Avenue", Country = "US" });
            Predicate<Customer> condition = x => x.Id == 1;
            Func<Customer, bool> whereCondition = x => x.Id == 1;
            var firstCustomer = customers.Find(condition);
            var firstCustomerUsingWhere = customers.Where(whereCondition).First();
            Console.WriteLine(firstCustomer.FirstName);
            Console.WriteLine(firstCustomerUsingWhere.FirstName);
        }
    }
}