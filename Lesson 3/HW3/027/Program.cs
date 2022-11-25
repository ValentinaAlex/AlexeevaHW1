// 027 Возведите число А в натуральную степень B используя цикл

int number = 4;
int exponent = 2;
int count = 1;
int result = number;


while (count < exponent)
{
    result = result * number;
    count++;
}
System.Console.WriteLine($"{number} ^ {exponent} = {result}");

