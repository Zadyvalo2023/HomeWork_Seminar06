// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
class Program 
{
    static void Main() 
    {
        Console.Write("Введите количество чисел:");

        int M = int.Parse(Console.ReadLine());

        int countPositiveNumbers = 0;

        for (int i = 0; i < M; i++)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                countPositiveNumbers++;
            }
        }
        Console.WriteLine("Количество чисел больше 0: " + countPositiveNumbers);
    }
}