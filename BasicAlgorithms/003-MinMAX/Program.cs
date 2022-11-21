// Напишите программу которая в последовательности натуральных чисел определяет минимальное число оканчивающиеся на 4
int n=4;
int min=30000;
for (int i=0;i<n;i++)
{
    int a=Convert.ToInt32(Console.ReadLine());
    if (a<min && a%10==4) min=a;
}
System.Console.WriteLine(min);