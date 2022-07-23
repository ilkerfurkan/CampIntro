using LoopsPractice;

Product product1 = new Product();
product1.ProductName = "Apple iPhone 13 Pro";
product1.ProductPrice = 36740;
product1.ProductComments = 326;

Product product2 = new Product();
product2.ProductName = "Huawei Mate 40 Pro";
product2.ProductPrice = 32178;
product2.ProductComments = 149;

Product product3 = new Product();
product3.ProductName = "Samsung Galaxy S22";
product3.ProductPrice = 26278;
product3.ProductComments = 243;

Product[] products = new Product[]
{
                product1, product2, product3
};

Console.WriteLine("--- For ile Yazdırma ---");
for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].ProductName);
}

Console.WriteLine("--- Foreach ile Yazdırma ---");
foreach (Product product in products)
{
    Console.WriteLine(product.ProductName);
}

Console.WriteLine("--- While ile Yazdırma ---");
int p = 0;
while (p < products.Length)
{
    Console.WriteLine(products[p].ProductName);
    p++;
}