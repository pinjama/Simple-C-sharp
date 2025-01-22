Console.WriteLine("Oletko tekemässä yhteen- vai vähennyslaskua? (+/-)");
var Lasku = Console.ReadLine();
if (Lasku == "+")
{
    Console.WriteLine("Anna luku 1");
    double luku1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Anna luku 2");
    double luku2 = Convert.ToDouble(Console.ReadLine());
    double luku3 = luku1+luku2;
    Console.WriteLine("Summa on: " + luku3);
}
else if (Lasku == "-")
{
    Console.WriteLine("Anna luku 1");
    double luku1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Anna luku 2");
    double luku2 = Convert.ToDouble(Console.ReadLine());
    double luku3 = luku1 - luku2;
    Console.WriteLine("Summa on: " + luku3);
}
