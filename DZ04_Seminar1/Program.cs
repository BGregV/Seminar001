Console.Write("Введите целое число:");
int pervoeChislo = int.Parse(Console.ReadLine()?? "0");
if (pervoeChislo% 2==1)
{
    Console.WriteLine ("Число НЕ чётное");
}
else
{
   Console.WriteLine ("Число чётное");
}
