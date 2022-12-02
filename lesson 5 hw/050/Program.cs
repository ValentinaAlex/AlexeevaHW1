// 50 Выяснить являются ли три числа сторонами треугольника

bool CheckTriangle(int a,int b,int c)
{
    return a+b>c && a+c>b && b+c>a;
}

int a=8,b=6,c=12;

if (CheckTriangle(a,b,c)) System.Console.WriteLine("YES"); else System.Console.WriteLine("NO");

