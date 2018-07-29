/*
Shopping Spree
Create two classes: class Person and class Product. Each person should have a name, money and a bag of products.
Each product should have name and cost. Name cannot be an empty string. Money cannot be a negative number.
Create a program in which each command corresponds to a person buying a product. If the person can afford a
product add it to his bag. If a person doesn’t have enough money, print an appropriate message (&quot;[Person name]
can&#39;t afford [Product name]&quot;).
On the first two lines you are given all people and all products. After all purchases print every person in the order
of appearance and all products that he has bought also in order of appearance. If nothing is bought, print the name
of the person followed by &quot;Nothing bought&quot;.
In case of invalid input (negative money exception message: &quot;Money cannot be negative&quot;) or empty name (empty
name exception message: &quot;Name cannot be empty&quot;) break the program with an appropriate message.
*/


using System;
using System.Linq;
using System.Collections.Generic;

namespace ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<Person> persons = GetPersons();
                List<Product> products = GetProducts();
                Buying(persons, products);

                foreach (var personResultInfo in persons)
                {
                    Console.Write($"{personResultInfo.Name} - ");
                    if (personResultInfo.Products.Count() == 0)
                    {
                        Console.WriteLine("Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine(string.Join(", ", personResultInfo.Products));
                    }
                }

            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.Message);
            }            
        }

        private static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            string[] productsInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in productsInput)
            {
                string[] productArgs = product.Split('=');
                products.Add(new Product(productArgs[0], decimal.Parse(productArgs[1])));
            }

            return products;
        }

        private static List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();

            string[] personsInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var person in personsInput)
            {
                string[] personArgs = person.Split('=');
                persons.Add(new Person(personArgs[0], decimal.Parse(personArgs[1])));
            }

            return persons;
        }

        private static void Buying(List<Person> persons, List<Product> products)
        {
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArgs[0];
                string productToBuy = cmdArgs[1];

                persons.First(p => p.Name == name).BuyingProducts(products.First(p => p.Name == productToBuy));
            }
        }
    }
}