// 093 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, заданы 2 массива:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//и 1 5 8 5
//4 9 4 2
//7 2 2 6
//2 3 4 7
//Их произведение будет равно следующему массиву:
//1 20 56 10
//20 81 8 6
//56 8 4 24
//10 6 24 49

int[,] CreateMatrix(int lenRows, int lenColumns, int minLimit, int maxLimit) //задаем массив
{
    int[,] matrix = new int[lenRows, lenColumns];
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // генерация строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // генерация столбцов
        {
            matrix[i, j] = random.Next(minLimit, maxLimit); // задали вывод случайных, целых элементов массива
        }
    }
    return matrix; // вернули двумерный массив
}

void PrintMatrix(int[,] matrix) // вывод на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine(); // переход на следующую строку
    }
}

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int rows = Prompt("введите количество строк первой матрицы - > ");
int columns = Prompt("введите количество столбцов первой матрицы- > ");
int rows2 = Prompt("введите количество строк второй матрицы - > ");
int columns2 = Prompt("введите количество столбцов второй матрицы- > ");
int min = Prompt("введите минимальное значение диапазона чисел - > ");
int max = Prompt("ввелите максимальное значение диапазона чисел  - > ");


int[,] matrix1 = CreateMatrix(rows, columns, min, max);
int[,] matrix2 = CreateMatrix(rows2, columns2, min, max);

PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();


if (matrix2.GetLength(0) != matrix1.GetLength(1))
{
    Console.WriteLine(" произведение двух матриц выполнить нельзя ");
    return;
}

int[,] ResultMatrix()
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        int[,] resultArray = new int[rows, columns2];
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            resultArray[i, j] += matrix2[i, matrix1.GetLength(1)] * matrix1[matrix1.GetLength(0), matrix1.GetLength(1) + 1];
        }
    }
    return resultArray;
}

int[,] resMatrix = ResultMatrix(rows, columns2);

PrintMatrix(resMatrix);