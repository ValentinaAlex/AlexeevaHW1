//  84 Определить являются ли введенные с клавиатуры символы правильно записью целого числа.
// Вычислить сумму цифр введенного числа
System.Console.WriteLine("Введите целое число: ");
string s = Console.ReadLine();
int sum = 0;
for (int i = 0; i < s.Length; i++)

    if (char.IsDigit(s[i]))
        sum = sum + (int)(char.GetNumericValue(s[i]));
    else
    {
        System.Console.WriteLine("Введеное число не является целым!");
        sum = 0;

        break;
    }
if (sum != 0) System.Console.WriteLine(sum);