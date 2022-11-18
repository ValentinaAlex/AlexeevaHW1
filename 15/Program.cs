// 15 С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
int n=Convert.ToInt32(Console.ReadLine());
n=System.Math.Abs(n);
if (n<100) System.Console.WriteLine ("Nо");
else 
System.Console.WriteLine(n/100%10);