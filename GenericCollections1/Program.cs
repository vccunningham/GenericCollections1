using System;
using System.Collections.Generic;

namespace GenericCollections1 {
    class Program {
        static void Main(string[] args) {
            var ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints) {
                Console.Write($" {anInt} ");
            }

            ints.Remove(2);
            Console.WriteLine($"Number of ints is {ints.Count}");
            foreach (var anInt in ints) {
                Console.Write($" {anInt} ");

            }
            {
                //generic array of names
                var studentnames = new List<string>(12);
                studentnames.Add("Vaughn");
                studentnames.Add("Armon");
                studentnames.Add("Robby");
                studentnames.Add("Danae");
                studentnames.Add("Traci");
                studentnames.Add("Minesh");
                studentnames.Add("Sarah");
                studentnames.Add("David");
                studentnames.Add("Laura");
                studentnames.Add("Ian");
                studentnames.Add("George");
                studentnames.Add("Parker");

                foreach (var name in studentnames) {


                    Console.Write($" {name} ");
                }
                //generic array of strings
                var customers = new List<Customer>();
                var Amazon = new Customer(1, "Amazon", true);
                var pg = new Customer(2, "P&G", true);
                var Nike = new Customer(3, "Nike", true);
                var Apple = new Customer(4, "Apple", true);
                var Target = new Customer { Id = 5, Name = "Target" };
                var Microsoft = new Customer(6, "Microsoft", false);

                customers.Add(Amazon);
                customers.Add(pg);
                var custArray = new Customer[] { Target, Nike, Apple, Microsoft };
                customers.AddRange(custArray);
                {

                    foreach (var customer in customers) {
                        if (customer.Active == true) {
                            Console.Write($"{customer.Id}, {customer.Name}, {customer.Active} ");
                        }
                        //if(customers.Active == false) {
                        //        continue;
                        //}
                        //Console.Write($"{customers.Id}, {customers.Name}, {customers.Active}");

                    }

                }
                var custDictionary = new Dictionary<int, Customer>();
                custDictionary.Add(Amazon.Id, Amazon);
                custDictionary.Add(Target.Id, Target);
                custDictionary.Add(pg.Id, pg);
                custDictionary.Add(Nike.Id, Nike);
                custDictionary.Add(Apple.Id, Apple);
                custDictionary.Add(Microsoft.Id, Microsoft);

                var cust2 = custDictionary[2];
                Console.WriteLine($"Customer id 2 is {cust2.Name}");

                cust2 = custDictionary[3];
                Console.WriteLine($"Customer id 3 is {cust2.Name}");

                Console.WriteLine($"Customer id 4 is {custDictionary[4].Name}");

                foreach(var key in custDictionary.Keys) {
                    //keys gives you a collection of data
                    var customer = custDictionary[key];
                    Console.WriteLine($"{customer.Name}");

                   
    }
            }
        } 
        
        
    }
    }

