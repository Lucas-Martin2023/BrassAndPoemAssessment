
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

//implement your loop here
string choice = null;
while (choice != "5")
{
    Console.WriteLine(@"Please choose an option:
                        1. Display all products
                        2. Delete a product
                        3. Add a product
                        4. Update a product
                        5. Exit");
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
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }