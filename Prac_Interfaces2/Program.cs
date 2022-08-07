
// interface new'lenemez.

//IPersonManager customerManager = new CustomerManager();
//customerManager.Add();

//IPersonManager employeeManager = new EmployeeManager();
//employeeManager.Add();

ProjectManager projectManager = new ProjectManager();
projectManager.Add(new InternManager());


class PersonManager
{
    // implemented operation: tamamlanmış operasyon
    // bu şekilde yapılırsa içerisine yazdığımız kod her yerde ortak demektir.
    public void Add()
    {
        Console.WriteLine("Eklendi.");
    }
}

// -------------------------------------------------

interface IPersonManager
{
    // unimplemented operation
    // burda ise imza aynı olabilir ama müşteri için ekleme ayrı, personel için ekleme ayrı olabilir.
    void Add();
    void Update();
}
// inherits - class -------------- implements - interface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        // müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi.");
    }
    public void Update()
    {
        // müşteri ekleme kodları
        Console.WriteLine("Müşteri güncellendi.");
    }
}
class EmployeeManager : IPersonManager
{
    public void Add()
    {
        // personel ekleme kodları
        Console.WriteLine("Personel eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Personel güncellendi.");
    }
}
class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer güncellendi.");
    }
}

class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}