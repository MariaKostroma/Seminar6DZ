// Задача 41. Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 он ввёл.

Console.Write("ВВедите числа через пробел: ");
string str = Console.ReadLine();

var arrayStr = str.Split(" ");

int[] array = Array.ConvertAll(arrayStr, int.Parse);
int count = 0;

for (int i = 0; i < array.Length; i++)
{
  if (array[i] > 0)
  {
    count++;
  }
}

Console.WriteLine($"Количество чисел больше нуля: {count}");


//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значение В1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение K1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение В2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение K2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения двух прямых: ({x};{y})");
Console.ReadLine();