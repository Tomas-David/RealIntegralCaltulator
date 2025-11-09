using RealIntegralCaltulator;

Console.WriteLine("Kalkulačka plochy pomocí reálného integrálu");
Console.WriteLine("--------------------------------------------");

Console.WriteLine("Zadejte hodnotu n (např. 2 nebo 0,5 nebo -1):");
string n = Console.ReadLine();
double nValue;
while (!double.TryParse(n, out nValue))
{
    Console.WriteLine("Neplatná hodnota. Zadejte prosím platné číslo pro n:");
    n = Console.ReadLine();
}


Console.WriteLine("Zadejte hodnotu A (dolní mez intervalu):");
string a = Console.ReadLine();
double aValue;
while (!double.TryParse(a, out aValue))
{
    Console.WriteLine("Neplatná hodnota. Zadejte prosím platné číslo pro A:");
    a = Console.ReadLine();
}


Console.WriteLine("Zadejte hodnotu B (horní mez intervalu):");
string b = Console.ReadLine();
double bValue;
while (!double.TryParse(b, out bValue))
{
    Console.WriteLine("Neplatná hodnota. Zadejte prosím platné číslo pro B:");
    b = Console.ReadLine();
}


Console.WriteLine("Zadejte hodnotu kroku výpočtu pro dolní a horní součet (např. 0,1):");
string step = Console.ReadLine();
double stepValue;
while (!double.TryParse(step, out stepValue) || stepValue <= 0)
{
    Console.WriteLine("Neplatná hodnota. Zadejte prosím kladné číslo pro krok:");
    step = Console.ReadLine();
}


AreaCalculator calc = new AreaCalculator(nValue, aValue, bValue, stepValue);


Console.WriteLine();
Console.WriteLine(calc.ToString());
Console.WriteLine();

Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení programu.");
Console.ReadKey();