// See https://aka.ms/new-console-template for more information

if (4.Equals((int)Days.Friday)) {
    Console.WriteLine("Enum type verified");
}


double number5 = 10.4;
decimal number6 = 10.4M; // or 10.4m
char character = 'A';
string city = "Ankara";
bool condition = true;
byte number4 = 255; // holds 8bit register
short number3 = -32768;
int number1 = 2147483647; //holds 32bit register
long number2 = 9223372036854775807; //holds 64bit register

var number7 = 10;
number7 = 'A';

Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);
Console.WriteLine("Condition is {0}", condition);
Console.WriteLine("Character is {0}, represent as ascii is {1}", character, (int)character);
Console.WriteLine("String is {0}", city);

Console.WriteLine("Var is {0}", number7);
