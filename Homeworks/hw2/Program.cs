/*
 1. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

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

// 2.  Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
/*

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
*/

// 3. Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.


void DecOrEd(int num)
{
    if(num >= 10 && num <= 99)
    {
        int dec = num / 10;
        int ed = num % 10;
        if (dec > ed)
        {
            System.Console.WriteLine($"{num} -> {dec}");

        }
        else
        {
            System.Console.WriteLine($"{num} -> {ed}");

        }

    }
    else
    {
        System.Console.WriteLine("Введено некорректное число");
    }
}
System.Console.WriteLine("Определение наибольшей цифры в числе");
System.Console.WriteLine("Введите число от 10 до 99");
int number = Convert.ToInt32(Console.ReadLine());


DecOrEd(number);