// See https://aka.ms/new-console-template for more information
string[] students = new string[3];
students[0] = "Engin";
students[1] = "Derin";
students[2] = "Salih";

string[] students2 = new[] { "Engin", "Derin", "Salih" };
//or
//string[] students2 = new string[3]{"Engin", "Derin", "Salih"};
//or
//string[] students2 = {"Engin", "Derin", "Salih"};

foreach (var student in students2)
{
    Console.WriteLine(student);
}

//string[,] regions = new string[7,3];
//regions[0, 0] = "İstanbul";

string[,] regions = new string[5, 3]{
 {"İstanbul", "İzmit", "Balıkesir"},
 {"Ankara", "Konya", "Kırıkkale"},
 {"Antalya", "Adana", "Mersin"},
 {"Rize", "Trabzon", "Samsun"},
 {"İzmir", "Muğla", "Manisa"}
};


for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }

}