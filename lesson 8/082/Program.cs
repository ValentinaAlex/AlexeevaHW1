// 082 C клавиатуры вводится строка разделенная точкой.
// Подсчитать количество символов до точки

System.Console.Write("Введите строку: ");
 string? str = Console.ReadLine();
 System.Console.WriteLine(str);

  Tochka(str);

 void Tochka (string a)
 {
     int count = 0;
     for(int i=0; i < a.Length; i++)
     {


         if (a[i] != '.')
             {

                 //System.Console.Write(a[i]); проверял правильно считывает символы
                 count++;


             }

         else
             break;

     }
      System.Console.Write($"Количество символов до точки {count}");
 }