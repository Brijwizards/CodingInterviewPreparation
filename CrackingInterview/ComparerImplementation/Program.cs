using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ComparerImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { ID = 1, Name = "Brijesh", Salary = 10000 });
            customers.Add(new Customer { ID = 2, Name = "Namrta", Salary = 20000 });
            customers.Add(new Customer { ID = 3, Name = "Deetya", Salary = 30000 });
            //customers.Sort();

            Console.WriteLine("Salary before sorting.");
            foreach (var item in customers)
            {
                Console.WriteLine(item.Salary);
            }

            // Sorting using IComparable.
            customers.Sort();
            Console.WriteLine("Salary after sorting.");
            foreach (var item in customers)
            {
                Console.WriteLine(item.Salary);
            }

            // Sorting using IComparer.
            SortByName sortByName = new SortByName();
            customers.Sort(sortByName);
            Console.WriteLine("Name after sorting.");
            foreach (var item in customers)
            {
                Console.WriteLine(item.Name);
            }


            // Sorting using Comparison delegate. 
            Comparison<Customer> customerCompare = new Comparison<Customer>(Customer.CompareCustomer);
            //SortByName sortByName = new SortByName();
            customers.Sort(customerCompare);
            Console.WriteLine("ID after sorting.");
            foreach (var item in customers)
            {
                Console.WriteLine(item.ID);
            }

            // Sorting using Comparison delegate- Simplified version using lamda expression.
            customers.Sort((x, y) => x.ID.CompareTo(y.ID));
        }


    }

    public class Customer : IComparable<Customer>
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Salary { get; set; }

        int IComparable<Customer>.CompareTo(Customer other)
        {
            //return this.Salary.CompareTo(other.Salary);
            return other.Salary.CompareTo(this.Salary);
        }

        public static int CompareCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }

    public class SortByName : IComparer<Customer>
    {
        int IComparer<Customer>.Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
