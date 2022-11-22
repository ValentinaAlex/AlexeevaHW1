// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.WriteLine("ВВЕДИТЕ ЧИСЛО:");

int day = Convert.ToInt32(Console.ReadLine());
string[] Days = { "ПОНЕДЕЛЬНИК", "ВТОРНИК", "СРЕДА", "ЧЕТВЕРГ", "ПЯТНИЦА", "СУББОТА", "ВОСКРЕСЕНЬЕ" };
string txtResult = "";

if (day > 5 && day < 8)
{
    txtResult = $". УРА! УРА! ВЫХОДНОЙ!";
    System.Console.WriteLine($"{day}   {Days[day - 1]}{txtResult}");
}
else
if (day > 0 && day < 6)
{
    txtResult = $". РАБОЧИЙ ДЕНЬ.";
    System.Console.WriteLine($"{day}   {Days[day - 1]}{txtResult}");
}
else
{
    txtResult = $". Нет такого дня";
    System.Console.WriteLine($"{day} {txtResult}");
}
