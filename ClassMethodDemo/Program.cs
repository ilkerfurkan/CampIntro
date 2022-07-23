using ClassMethodDemo;

Customer customer1 = new Customer();
customer1.CustomerName = "İlker Furkan";
customer1.CustomerSurname = "ŞAHİN";
customer1.CustomerBirthPlace = "Kartal";
Customer customer2 = new Customer();
customer2.CustomerName = "Mete";
customer2.CustomerSurname = "KAYACAN";
customer2.CustomerBirthPlace = "Muş";
Customer customer3 = new Customer();
customer3.CustomerName = "Samet";
customer3.CustomerSurname = "TURGUT";
customer3.CustomerBirthPlace = "Gebze";

Customer[] customers = new Customer[]
{
                customer1, customer2, customer3
};

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);

foreach (Customer customer in customers)
{
    customerManager.List(customer);
}

customerManager.Delete(customer2);