// Выяснить является ли число чётным.
Console.WriteLine("Привет, напиши любое число");
int x = Convert.ToInt32(Console.ReadLine());
double x_2 = x % 2;
if (x_2 == 0)
    Console.WriteLine("число четное");
else
    Console.WriteLine("Число нечетное");

