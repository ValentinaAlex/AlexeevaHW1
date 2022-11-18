// 4 По заданному с клавиатуры номеру дня недели вывести его название
Console.WriteLine ("Введите номер дня недели");
int a=Convert.ToInt32(Console.ReadLine());
    if (a  == 1)
{
Console.WriteLine ("Понедельник-рабочий день");
}
else if
(a == 2)
{
    Console.WriteLine ("Вторник-рабочий день");
}
else if
(a == 3)
{
    Console.WriteLine ("Среда-рабочий день");
}

else if
(a  == 4)
{
Console.WriteLine ("Четверг-рабочий день");
}
else if
(a == 5)
{
Console.WriteLine ("Пятница-ура,почти выходной,но он рабочий");
}
else if
(a == 6)
{
Console.WriteLine ("Суббота-Выходной день");
}
else if
(a == 7)
{
Console.WriteLine ("Воскресенье-эх,выходной,но завтра на работу");
}
else 
{
  Console.WriteLine ("Такого дня недели не существует");  
}
