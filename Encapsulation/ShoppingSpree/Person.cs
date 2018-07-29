using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private decimal money;
    List<Product> listOfProducts;

    public string Name
    {
        get { return name; }
    }
    
    public decimal Money
    {
        get { return money; }
    }

    public List<Product> Products
    {
        get { return listOfProducts; }
    }

    public Person(string name, decimal money)
    {
        if (!string.IsNullOrWhiteSpace(name)) this.name = name;
        else throw new ArgumentException("Name cannot be empty");
        if (money >= 0) this.money = money;
        else throw new ArgumentException("Money cannot be negative");
        listOfProducts = new List<Product>();
    }

    public void BuyingProducts(Product product)
    {
        if (Money < product.Cost)
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
        else
        {
            this.money -= product.Cost;
            listOfProducts.Add(product);
            Console.WriteLine($"{Name} bought {product.Name}");
        }
    }
}
