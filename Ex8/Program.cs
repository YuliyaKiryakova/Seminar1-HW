/* Программа, которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N
5 -> 2,4
8 -> 2,4,6,8
*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int start = 1;
while (start <= num)
{
    if (start % 2 == 0)
        Console.Write(start + ", ");
    start++;
}