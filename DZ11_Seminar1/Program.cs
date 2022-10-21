Console.Write("Введите первое число:");
double pervoeChislo = double.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число:");
double vtoroeChislo = double.Parse(Console.ReadLine() ?? "0");
double ostatok = (pervoeChislo % vtoroeChislo);
if (  pervoeChislo % vtoroeChislo == 0)
{
    Console.WriteLine("Число кратно");
}
else
{
    Console.WriteLine($"Остаток от деления {ostatok}");
}