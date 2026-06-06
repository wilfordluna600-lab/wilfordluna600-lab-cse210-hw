using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("654 Elm Drive", "Portland", "Oregon", "USA");
        Customer customer1 = new Customer("David Wilson", address1);
        List<Product> products1 = new List<Product>();
        products1.Add(new Product("Phone Charger", 462516, 5, 3));
        products1.Add(new Product("Jacket", 315486, 25, 2));
        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("458 Ica Street", "Chimbote", "Ancash", "Peru");
        Customer customer2 = new Customer("Sofia Ramirez", address2);
        List<Product> products2 = new List<Product>();
        products2.Add(new Product("USB Flash Drive", 215786, 15, 4));
        products2.Add(new Product("Backpack", 315498, 20, 1));
        Order order2 = new Order(customer2, products2);

        List<Order> ordersAll = new List<Order>();
        ordersAll.Add(order1);
        ordersAll.Add(order2);



    }
}