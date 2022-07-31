using Prac_Interfaces;

ICustomerDal[] customerDals = new ICustomerDal[2] { new SqlServerCustomerDal(), new OracleCustomerDal() };
foreach (var customerDal in customerDals) { customerDal.Add(); }

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new SqlServerCustomerDal());



PersonManager personManager = new PersonManager();
Customer customer = new Customer
{
    Id = 1,
    FirstName = "Furkan",
    LastName = "Şahin",
    Address = "İzmit"
};
Student student = new Student
{
    Id = 1,
    FirstName = "Mete",
    LastName = "Kayacan",
    Department = "İktisat"
};
personManager.Add(student);
personManager.Add(customer);


interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Department { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}