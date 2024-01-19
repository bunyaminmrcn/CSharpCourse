using System.Collections;

namespace Collections;

class Program
{
    static void Main(string[] args)
    {
        //ArrayList();
        //List();
        Dictionary<string, string> dictionay = new Dictionary<string, string>();
        dictionay.Add("book", "kitap");
        dictionay.Add("table", "tablo");
        dictionay.Add("computer", "bilgisayar");

        foreach (var item in dictionay)
        {
            Console.WriteLine(item.Value);
        }
        //Console.WriteLine(dictionay["table"]);


        Console.WriteLine(dictionay.ContainsKey("glass"));
    }

    private static void List()
    {
        List<string> cities = new List<string>();
        cities.Add("Ankara");
        cities.Add("İstanbul");

        //Console.WriteLine(cities.Contains("Ankara"));
        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }

        /*
        List<Customer> customers = new List<Customer>();
        customers.Add(new Customer{ Id = 1, FirstName = "Engin"});
        customers.Add(new Customer { Id = 2,  FirstName = "Derin"});
        */
        List<Customer> customers = new List<Customer>
        {
            new Customer{ Id = 1, FirstName = "Engin"},
            new Customer { Id = 2,  FirstName = "Derin"}
        };

        var customer2 = new Customer
        {
            Id = 3,
            FirstName = "Salih"
        };

        customers.Add(customer2);
        customers.AddRange(new Customer[2]{
            new Customer { Id = 4, FirstName = "Ali"},
            new Customer { Id= 5, FirstName= "Ayşe"}
        });
        customers.Contains(customer2);

        //customers.Clear();


        var index = customers.IndexOf(customer2);
        Console.WriteLine("Index : {0}", index);

        customers.Add(customer2);
        var index2 = customers.LastIndexOf(customer2);
        Console.WriteLine("LastIndex : {0}", index2);

        customers.Insert(0, customer2);
        //customers.Remove(customer2);
        //
        customers.RemoveAll(c => c.FirstName == "Salih");
        foreach (var customer in customers)
        {
            Console.WriteLine(customer.FirstName);
        }
        var count = customers.Count;
        Console.WriteLine("Count is {0}", count);
    }
    private static void ArrayList()
    {
        ArrayList cities = new ArrayList();
        cities.Add("Ankara");
        cities.Add("Adana");

        foreach (var city in cities)
        {
            Console.WriteLine(city);
        }
    }
}


class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
}