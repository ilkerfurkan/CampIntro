
Customer customer1 = new Customer { Id = 1, FirstName = "İlker Furkan", LastName = "Şahin", City = "Ardahan" };
Customer customer2 = new Customer(2, "İlker Furkan", "Şahin", "Ardahan");

Console.WriteLine(customer2.FirstName);



class Customer
{
    //default constructor: bu bloğu yazsakta yazmasakta arka planda constructor çalışır.
    //biz buraya bir constructor yazdığımızda default constructor'ı ezmiş oluruz.
    //default halinde customer1 çalışır, customer2 çalışmaz. 
    //bizim yazdığımız halinde ise customer2 çalışır, customer1 çalışmaz.
    //ikisininde çalışması için parametresiz constructor ve parametreli constructor yapılır.
    public Customer()
    {

    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }


    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}