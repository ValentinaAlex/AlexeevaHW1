// 26 Найти сумму чисел от 1 до А

System.Console.Write("Введите любое число:   ");
string writeA = Console.ReadLine();
int A = Convert.ToInt32(writeA);

int GetNumbersSum(int A)
{
    int number = 1;
    int sum = 0;
    for (int i = 0; i < A; i++)
    {
        sum = sum + number;
        number++;
    }
    return sum;
}

int NumbersSum = GetNumbersSum(A);
System.Console.WriteLine($"Сумма чисел от 1 до {A} выводит {NumbersSum}");
