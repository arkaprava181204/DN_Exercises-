using System;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {ProductId}, Name: {ProductName}, Category: {Category}");
    }
}

class Program
{
   
    static Product LinearSearch(Product[] products, int id)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == id)
                return product;
        }
        return null;
    }

    // Binary Search
    static Product BinarySearch(Product[] products, int id)
    {
        int low = 0;
        int high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (products[mid].ProductId == id)
                return products[mid];

            if (products[mid].ProductId < id)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }

    static void Main(string[] args)
    {
 
        Product[] products =
        {
            new Product(105, "Laptop", "Electronics"),
            new Product(101, "Shoes", "Fashion"),
            new Product(103, "Phone", "Electronics"),
            new Product(102, "Watch", "Accessories"),
            new Product(104, "Bag", "Fashion")
        };

   
        Product[] sortedProducts =
        {
            new Product(101, "Shoes", "Fashion"),
            new Product(102, "Watch", "Accessories"),
            new Product(103, "Phone", "Electronics"),
            new Product(104, "Bag", "Fashion"),
            new Product(105, "Laptop", "Electronics")
        };

        Console.Write("Enter Product ID to search: ");
        int searchId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n--- Linear Search ---");
        Product result1 = LinearSearch(products, searchId);

        if (result1 != null)
            result1.Display();
        else
            Console.WriteLine("Product not found.");

        Console.WriteLine("\n--- Binary Search ---");
        Product result2 = BinarySearch(sortedProducts, searchId);

        if (result2 != null)
            result2.Display();
        else
            Console.WriteLine("Product not found.");
    }
}