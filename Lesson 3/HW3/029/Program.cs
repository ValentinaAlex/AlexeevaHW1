// 29 Подсчитать сумму цифр в числе. Сделать подпрограмму.
int number = new Random().Next(1, 1000);
int sumDigit = 0;
System.Console.Write($"Сумма цифр числа {number} равна ");
while (number > 0)
{
    int digit = number % 10;
    sumDigit = sumDigit + digit;
    number = number / 10;
}
System.Console.WriteLine(sumDigit);

