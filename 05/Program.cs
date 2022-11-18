// 5 С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine(max);







