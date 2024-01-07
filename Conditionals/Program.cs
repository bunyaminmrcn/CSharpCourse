// See https://aka.ms/new-console-template for more information


var number = 10;
if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 11)
{
    Console.WriteLine("Number is 11");
}
else
{
    Console.WriteLine("Number is not 10 or 11");
}

Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10"); // single line if

switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 11:
        Console.WriteLine("Number is 11");
        break;
    default:
        Console.WriteLine("Number is not 10 or 11");
        break;
}

var number1 = 201;
if (number1 >= 0 && number1 <= 100)
{
    Console.WriteLine("Number is betweeen 0-100");
}
else if (number1 >= 100 && number1 <= 200)
{
    Console.WriteLine("Number is betweeen 100-200");
} else {
    Console.WriteLine("Number is greater than 200 or less than 0");
}