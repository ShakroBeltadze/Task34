// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 != 0)
{
    number--;
}

int i = 2;

while (i <= number)
{
    if (i == number)
    {
        Console.WriteLine(i);
    }
    else
    {
        Console.Write(Convert.ToString(i) + ", ");
    }

    i += 2;
}
Console.WriteLine(" ");