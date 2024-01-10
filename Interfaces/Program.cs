namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        //InterfacesIntro();
        ICustomerDal[] customerDals = new ICustomerDal[3]{ new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal()};
        foreach (var customerDal in customerDals)
        {
            customerDal.Add();
        }
    }

    private static void Demo()
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add(new SqlServerCustomerDal());
    }
    static void InterfacesIntro()
    {
        PersonManager manager = new PersonManager();

        Customer customer = new Customer
        {
            Id = 1,
            FirstName = "Engin",
            LastName = "Demiroğ",
            Address = "Ankara"
        };

        Student student = new Student
        {
            Id = 2,
            FirstName = "Derin",
            LastName = "Demiroğ",
            Departmant = "Compute Sciences"
        };

        manager.Add(customer);
        manager.Add(student);
    }
}


//interface - soyut nesne
interface IPerson
{
    int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

//class - somut nesne
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
    public string Departmant { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}
class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}