namespace Methods;

class Program
{
    static void Main(string[] args)
    {


        //Add();
        //var result = Add2();


        /*
        int number1 = 20;
        int number2 = 100;
        var result = Add3(ref number1, number2);
        Console.WriteLine(result);
        Console.WriteLine(number1);
        */

        /*
        int number1; // out-ref => set a variable is not required in out
        int number2 = 100;
        var result = Add4(out number1, number2);
        Console.WriteLine(result);
        Console.WriteLine(number1);
        */

        /*
        Console.WriteLine(Multiply(2,4));
        Console.WriteLine(Multiply(2,4,8));
        */

        Console.WriteLine(Add5(1,2,3,4,5,6));
    }


    static void Add()
    {
        Console.WriteLine("Added");
    }
    // Set defaults to params
    static int Add2(int number1 = 20, int number2 = 30)
    {
        return number1 + number2;
    }

    static int Add3(ref int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;
    }

    static int Add4(out int number1, int number2)
    {
        //set variable in scope when using out
        number1 = 30;
        return number1 + number2;
    }

    static int Multiply(int number1, int number2) {
        return number1 * number2;
    }

    // en => Method overloading
    // tr =>  Aşırı yükleme

    static int Multiply(int number1, int number2, int number3) {
        return number1 * number2 * number3;
    }

    static int Add5(params int[] numbers) {
        return numbers.Sum();
    }

}
