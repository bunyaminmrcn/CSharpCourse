namespace Exceptions;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Find();
        }
        catch (RecordNotFoundException exception)
        {
            Console.WriteLine(exception.Message);

        }

        HandleException(() =>
        {
            Find();
        });
    }

    private static void HandleException(Action action)
    {
        try
        {
            action.Invoke();
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);

        }
    }

    private static void Find()
    {
        List<string> students = new List<string> { "Engin", "Derin", "Salih" };
        if (!students.Contains("Ahmet"))
        {
            throw new RecordNotFoundException("Record Not Found!");
        }
    }
    private static void ExceptionIntro()
    {
        try
        {
            string[] students = new string[] { "Engin", "Derin", "Salih" };
            students[3] = "Ahmet";
        }
        catch (IndexOutOfRangeException exception)
        {
            Console.WriteLine(exception.Message);
        }

        catch (DivideByZeroException exception)
        {
            Console.WriteLine(exception.Message);
        }

        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}
