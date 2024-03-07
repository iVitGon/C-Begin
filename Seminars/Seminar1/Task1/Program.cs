﻿// Напишите программу, которая на вход принимает два целых числа и проверяет: является ли превое число квадратом второго
// Агоритм решения:
// 1. Принить от пользователя значение числа а
// 2. Принять от пользователя значение числа b
// 3. Создаем условный алгоритм (Логика: если   , то     , иначе    )
//    3.1. Если а * а == b, тогда выводим в терминал сообщение, что число b является квадратом числа а
//    3.2. если а * а != b, тогда выводим в терминал сообщение, что число b не является квадратом числа а

Console.WriteLine ("Проверка двух чисел, где первое число предположительно является квадратом второго");
Console.WriteLine ("Введите число первое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите число второе число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a * a == b)
{
    Console.WriteLine ($"Введенное число {b}, является квадратом числа {a} ");
}
else 
{
    Console.WriteLine ($"Введенное число {b}, НЕ является квадратом числа {a} ");
}
