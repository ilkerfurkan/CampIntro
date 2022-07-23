using Methods;

string ProductName = "Elma";
double ProductPrice = 15;
string ProductDescription = "Amasya Elması";

Product product1 = new Product();
product1.Name = "Elma";
product1.Price = 20;
product1.Description = "Amasya Elması";

Product product2 = new Product();
product2.Name = "Karpuz";
product2.Price = 80;
product2.Description = "Diyarbakır Karpuzu";

Product[] products = new Product[]
{
                product1, product2
};

//type safe -- tip güvenli
foreach (Product product in products)
{
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Description);
    Console.WriteLine("---------------");
}

Console.WriteLine("--------Metotlar--------");

//instance - örnek
//ENCAPSULATION - Kapsülleme: Ayrı ayrı yazacağın ve düzensiz olacak yapıyı bir düzenin(kapsülün) içine sokuyoruz.
CartManager cartmanager = new CartManager();
cartmanager.Add(product1);
cartmanager.Add(product2);


// Böyle de yapılabilir ama önerilmiyor.
//sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 200);
//sepetManager.Ekle2("Elma", "Kırmızı Elma", 15, 300);
//sepetManager.Ekle2("Kayısı", "Malaty Kayısısı", 24, 500);


// Do not repeat yourself - Clean Code - Best Practice
