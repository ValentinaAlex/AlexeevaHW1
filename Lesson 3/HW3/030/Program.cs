// 30 Написать программу вычисления произведения чисел от 1 до N



	System.Console.Write("Введи любое число:   ");
	string writeN = Console.ReadLine();
	int N = Convert.ToInt32(writeN);

	int GetNumbersComposition(int x)
	{
	    int comp = 1;
	    for (int num = 1; num <= x; num++)
	    {
	        comp = comp * num;
	    }
	    return comp;
	}
	System.Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetNumbersComposition(N)}");

