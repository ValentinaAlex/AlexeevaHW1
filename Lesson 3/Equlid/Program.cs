// алгоритм Евклида
int k = 0;
int GCD(int a, int b)
{
    while (a != b)
    {
        k++;
        if (a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}
System.Console.WriteLine(GCD(1, 5000));
System.Console.WriteLine(k);
