int numberA = new Random().Next(1, 100);//1 2 3 4...7
Console.WriteLine($"Число {numberA}");
int vtoroechislo = (numberA % 10);
int pervoechislo = (numberA / 10);
Console.WriteLine($"первое число {pervoechislo}, второе число {vtoroechislo}");
Console.WriteLine("Max: " + Math.Max(pervoechislo, vtoroechislo));
