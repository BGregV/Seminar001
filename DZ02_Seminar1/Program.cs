Console.WriteLine("Введите номер дня от 1 до 7");
int DenNedeli = int.Parse(Console.ReadLine()?? "0");
if (DenNedeli <= 7)
switch (DenNedeli){
    case 1:
    Console.WriteLine("Понедельник");
    break;
    case 2:
    Console.WriteLine("Вторник");
    break;
    case 3:
    Console.WriteLine("Среда");
    break;
    case 4:
    Console.WriteLine("Четверг");
    break;
    case 5:
    Console.WriteLine("Пятница");
    break;
    case 6:
    Console.WriteLine("Суббота");
    break;
    case 7:
    Console.WriteLine("Воскресенье");
    break;
}
else
{
Console.WriteLine ("Такого дня не существует");
}