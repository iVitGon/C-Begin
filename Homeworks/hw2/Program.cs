/*
 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void NumMultiplicity23And7 (int a)
{
    if (a % 7 == 0 && a % 23 == 0)
    {
        System.Console.WriteLine($"Число {a} кратно 7 и 23");
    }
    else
    {
        System.Console.WriteLine($"Чмсло {a} НЕкратно 7 и 23");
    }
}


System.Console.WriteLine("Кратность числа 7 и 23");
System.Console.WriteLine();
System.Console.WriteLine("Введите число для проверки");
int number = Convert.ToInt32(Console.ReadLine());

NumMultiplicity23And7(number); // void метод

*/

//  Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

void OnlyQuarter (int x, int y)
{
    if (x != 0 && y != 0)
    {
        if (x > 0 && y > 0)
        {
            System.Console.WriteLine("Первая четверть");
        }
        if (x < 0 && y > 0)
        {
            System.Console.WriteLine("Вторая четверть");
        }
        if (x < 0 && y < 0)
        {
            System.Console.WriteLine("Третья четверть");
        }
        if (x > 0 && y < 0)
        {
            System.Console.WriteLine("Четвертая четверть");
        }
    }
    else
    {
        System.Console.WriteLine($"Введенные значеня x({x}), y({y}) не соответствуют условию (не равно нулю)");
    }
}   

System.Console.WriteLine("Для определения четверти на координатной плоскости введите значения для x и y, где x и y должны быть отличны 0");
System.Console.WriteLine("Введите значение x");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y");
int y1 = Convert.ToInt32(Console.ReadLine());

OnlyQuarter(x1, y1);