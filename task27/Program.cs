/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Input nubmer");
int N = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (int i = N; i > 0; i = i / 10)
{
    N = i % 10;
    count = count + N;
}
Console.WriteLine($"result = " + count);