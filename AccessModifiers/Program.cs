namespace AccessModifiers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Customer
{
    // used in inherited class which extends this class
    //protected int Id { get; set; }

}

class Student : Customer
{
    public void Save()
    {
        
    }
}


//use internal - default value of a class definetion is internal 
public  class Course 
{
    public string Name { get; set; }

    /*
    private class NestedClass {

    }
    */

}
