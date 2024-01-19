namespace RecapDemo2;

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.logger = new DatabaseLogger();
        customerManager.Add();
    }
}

class CustomerManager
{
    public ILogger logger { get; set; }
    public void Add()
    {
        logger.Log();
        Console.WriteLine("Customer added!");
    }
}

class DatabaseLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to database!");
    }
}

class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file!");
    }
}

class SmsLogger : ILogger
{
    public void  Log()
    {
        Console.WriteLine("Logged to sms!");
    }
}
interface ILogger 
{
    void Log();
}