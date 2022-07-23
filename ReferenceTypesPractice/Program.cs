int number1 = 10;
int number2 = 20;

number1 = number2;
number2 = 100;

// Sayı 1 20 olacaktır.
Console.WriteLine("Sayı 1: " + number1);


int[] numbers1 = new int[] { 1, 2, 3 };
int[] numbers2 = new int[] { 10, 20, 30 };

numbers1 = numbers2;
numbers2[0] = 1000;

//Numbers 1'in 0'ıncı elemanı 1000 olacaktır.
Console.WriteLine("Sayılar1[0]: " + numbers1[0]);

Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "İlker";
person2 = person1;
person1.FirstName = "Furkan";
Console.WriteLine(person2.FirstName);

Customer customer1 = new Customer();
customer1.FirstName = "Salih";
customer1.CreditCardNumber = "4564541564";
Employee employee = new Employee();
employee.FirstName = "Veli";
Person person3 = customer1;
Console.WriteLine(person3.FirstName);

customer1.FirstName = "Ahmet";
Console.WriteLine(((Customer)person3).CreditCardNumber);


PersonManager personManager = new PersonManager();
personManager.Add(employee);

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}

//base class : Person -- ebeveyn
class Customer : Person
{
    public string CreditCardNumber { get; set; }
}
class Employee : Person
{
    public string EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    } 
}

//inheritance