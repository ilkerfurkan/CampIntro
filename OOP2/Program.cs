using OOP2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "12345";
customer1.CustomerName = "Furkan";
customer1.CustomerSurname = "Şahin";
customer1.IdentityNumber = "12345678910";

CorporateCustomer customer2 = new CorporateCustomer();
customer1.Id = 2;
customer1.CustomerNumber = "54321";
customer2.CompanyName ="IFS DEV.";
customer2.TaxNumber = "1234567890";

Customer customer3 = new IndividualCustomer();
Customer customer4 = new CorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);

// gerçek müşteri - tüzel müşteri
// SOLID