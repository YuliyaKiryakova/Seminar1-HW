/* Программа, которая на вход принимает число и выдает, является ли оно четным
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
bool check = num % 2 == 0;
Console.WriteLine(check);