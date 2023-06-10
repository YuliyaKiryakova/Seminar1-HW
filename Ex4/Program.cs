/* Программа, которая на вход принимает три числа и выдает максимальное из них
2,3,7 -> 7
44,5,78 -> 78
22,3,9 -> 22
*/

Console.Write("Введите число а: ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int numB = int.Parse(Console.ReadLine()!);
Console.Write("Введите число c: ");
int numC = int.Parse(Console.ReadLine()!);
if (numA > numB)
    if (numA > numC)
        Console.WriteLine($"Максимум {numA}");
    else
        Console.WriteLine($"Максимум {numC}");
else
    if (numB > numC)
    Console.WriteLine($"Максимум {numB}");
    else
    Console.WriteLine($"Максимум {numC}");
