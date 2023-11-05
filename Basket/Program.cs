using System;

class Product
{
    public string Name { get; }
    public decimal Price { get; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public void Print()
    {
        Console.WriteLine($"{Name}: {Price} руб.");
    }
}

class Basket
{
    private Product[] products;

    public Basket()
    {
        products = new Product[0];
    }

    public void AddProduct(Product product)
    {
        Array.Resize(ref products, products.Length + 1);
        products[products.Length - 1] = product;
    }

    public void RemoveProduct(Product product)
    {
        int index = Array.IndexOf(products, product);
        if (index >= 0)
        {
            for (int i = index; i < products.Length - 1; i++)
            {
                products[i] = products[i + 1];
            }
            Array.Resize(ref products, products.Length - 1);
        }
    }

    public void ListProducts()
    {
        Console.WriteLine("Содержимое корзины:");
        foreach (var product in products)
        {
            product.Print();
        }
    }

    public decimal CalculateTotalPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in products)
        {
            totalPrice += product.Price;
        }
        return totalPrice;
    }
}

class Program
{
    static void Main()
    {
       
        Product product1 = new Product("Молоко", 50);
        Product product2 = new Product("Хлеб", 30);
        Product product3 = new Product("Яблоки", 80);

        
        Basket basket = new Basket();
        basket.AddProduct(product1);
        basket.AddProduct(product2);
        basket.AddProduct(product3);

        
        basket.ListProducts();

 
        decimal totalPrice = basket.CalculateTotalPrice();
        Console.WriteLine($"Суммарная стоимость продуктов в корзине: {totalPrice} руб.");

        basket.RemoveProduct(product2);

        totalPrice = basket.CalculateTotalPrice();
        Console.WriteLine($"Суммарная стоимость продуктов в корзине после удаления: {totalPrice} руб.");
    }
}



