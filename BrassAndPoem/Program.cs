
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trumbone",
        Price = 15.00M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "Jabberwocky",
        Price = 10.00M,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "Cornet",
        Price = 17.00M,
        ProductTypeId = 1,
    },
    new Product()
    {
        Name = "The Raven",
        Price = 19.00M,
        ProductTypeId = 2,
    },
    new Product()
    {
        Name = "Mellophone",
        Price = 16.00M,
        ProductTypeId = 1,
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
       Title = "Brass",
       Id = 1,
    },
    new ProductType()
    {
       Title = "Poem",
       Id = 2,
    }
};
//put your greeting here
Console.WriteLine("Welcome to the one and only Brass and Poem store");

//implement your loop her
string choice = null;
while (choice != "5")
{
    DisplayMenu();
    choice = Console.ReadLine();
    if (choice == "1")
    {
        DisplayAllProducts(products, productTypes);
    }
    else if (choice == "2")
    {
        DeleteProduct(products, productTypes);
    }
    else if (choice == "3")
    {
        AddProduct(products, productTypes);
    }
    else if (choice == "4")
    {
        UpdateProduct(products, productTypes);
    }
    else if (choice == "5")
    {
        Console.WriteLine("Goodbye!");
    }
}
void DisplayMenu()
{
    Console.WriteLine(@"Please choose an option:
                        1. Display all products
                        2. Delete a product
                        3. Add a product
                        4. Update a product
                        5. Exit");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("All Products:");

    for (int i = 0; i < products.Count; i++)
    {
        Product product = products[i];
        ProductType productType = productTypes.FirstOrDefault(pt => pt.Id == product.ProductTypeId);

        Console.WriteLine($"{i + 1}. {product.Name} - ${product.Price} ({productType?.Title})");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Select a product to delete:");

    for (int i = 0;i < products.Count;i++)
    {
        Product product = products[i];
        Console.WriteLine($"{i + 1}. {product.Name} - ${product.Price}");
    }

    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= products.Count)
    {
        products.RemoveAt(index - 1);
        Console.WriteLine("Product deleted successfully.");
    }
    else 
    {
        Console.WriteLine("Invalid input. No product deleted.");
    }
}

static void DisplayProductTypes(List<ProductType> productTypes)
{
    Console.WriteLine("Available Product Types:");
    foreach (var productType in productTypes)
    {
        Console.WriteLine($"{productType.Id}. {productType.Title}");
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Enter the name of the new product:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter the price of the new product:");
    if (decimal.TryParse(Console.ReadLine(), out decimal price))
    {
        Console.WriteLine("Select a product type for the new product:");
        DisplayProductTypes(productTypes);

        if (int.TryParse(Console.ReadLine(), out int typeId) && productTypes.Any(pt => pt.Id == typeId))
        {
            Product newProduct = new Product
            {
                Name = name,
                Price = price,
                ProductTypeId = typeId
            };

            products.Add(newProduct);
            Console.WriteLine("Product added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid product type. No product added.");
        }
    }
    else
    {
        Console.WriteLine("Invalid price. No product added.");
    }
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Select a product to update:");
    DisplayAllProducts(products, new List<ProductType>());

    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= products.Count)
    {
        var product = products[index - 1];

        Console.WriteLine("Enter the updated name (press Enter to keep it unchanged):");
        string updatedName = Console.ReadLine();
        if (!string.IsNullOrEmpty(updatedName))
        {
            product.Name = updatedName;
        }

        Console.WriteLine("Enter the updated price (press Enter to keep it unchanged):");
        if (decimal.TryParse(Console.ReadLine(), out decimal updatedPrice))
        {
            product.Price = updatedPrice;
        }

        Console.WriteLine("Select the updated product type (press Enter to keep it unchanged):");
        DisplayProductTypes(productTypes);
        if (int.TryParse(Console.ReadLine(), out int updatedTypeId) && productTypes.Any(pt => pt.Id == updatedTypeId))
        {
            product.ProductTypeId = updatedTypeId;
        }

        Console.WriteLine("Product updated successfully.");
    }
    else
    {
        Console.WriteLine("Invalid input. No product updated.");
    }
}

// don't move or change this!
public partial class Program { }