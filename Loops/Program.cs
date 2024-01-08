namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        //FoorLoop();
        //WhileLoop();
        //DoWhileLoop();
        //ForEachLoop();
        Console.WriteLine(IsPrimeNumber(6));
    }


    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                result = false;
                i = number;  //do this trick
                //or use break,continue;
            }
        }
        return result;
    }
    private static void ForEachLoop()
    {
        string[] students = new string[3] { "Engin", "Derin", "Salih" };

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
    private static void DoWhileLoop()
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number >= 0);
    }
    private static void WhileLoop()
    {
        int number = 100;
        while (number <= 0)
        {
            Console.WriteLine(number);
            number--;
        }
    }
    private static void FoorLoop()
    {
        for (int i = 100; i >= 0; i -= 2)
        {
            Console.WriteLine(i);
        }
    }
}
