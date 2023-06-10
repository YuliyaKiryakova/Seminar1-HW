/* Программа, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
a = 5 b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите число а: ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int numB = int.Parse(Console.ReadLine()!);
if (numA == numB)
    Console.WriteLine("Числа равны");
else if (numA > numB)
    Console.WriteLine($"Максимум {numA}, минимум {numB}");
else
    Console.WriteLine($"Максимум {numB}, минимум {numA}");
