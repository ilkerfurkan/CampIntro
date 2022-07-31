
// Aşağıdaki gibi bir kullanım yapacaksak Interface kullanmamız daha mantıklıdır.
//  Çünkü Interface'ler her ne kadar Inheritance olmasa da Inheritance mantığıyla kullanılabiliyor.

// Abstract sınıflar Inheritance anlamında çok önemli bir yer teşkil eder.

// EĞER INTERFACE KULLANABİLİYORSAK VE INHERITANCE'A İHTİYACIMIZ YOKSA INTERFACE KULLANMALIYIZ.



Person[] persons = new Person[3]
{
    new Customer{FirstName="İlker"}, new Student{FirstName="Furkan"}, new Person{FirstName="Şahin"}
};
foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}



class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
// bir class'a ikinci bir baba(inheritance) atanamaz.
class Customer : Person
{
    public string City { get; set; }
}
class Student : Person
{
    public string Department { get; set; }
}

