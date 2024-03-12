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

/*
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

*/

//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
// 645 ->6,4,5    8->8    4567 ->4,5,6,7

void SeparationOfNumber (int num)
{
if (num >= 0 && num <= 9 )
{
    System.Console.WriteLine($"{num}");
}
if (num >= 10 && num <= 99)
{
    int a = num % 10;
    int b = num / 10;
    System.Console.WriteLine($"{num} -> {b},{a}");
}
if (num >= 100 && num <= 999)
{
    int a = num % 10;
    int b = num % 100 / 10;
    int c = num / 100;
    System.Console.WriteLine($"{num} -> {c},{b},{a}");
}
if (num >= 1000 && num <= 9999)
{
    int a = num % 10;
    int b = num % 100 / 10;
    int c = num % 1000 /100;
    int d = num / 1000;
    System.Console.WriteLine($"{num} -> {d},{c},{b},{a}");
}
if (num >= 10000 && num <= 99999)
{
    int a = num % 10;
    int b = num % 100 / 10;
    int c = num % 1000 /100;
    int d = num % 10000 / 1000;
    int e = num / 10000;
    System.Console.WriteLine($"{num} -> {e},{d},{c},{b},{a}");
}
if (num >= 100000 && num <= 999999)
{
    int a = num % 10;
    int b = num % 100 / 10;
    int c = num % 1000 /100;
    int d = num % 10000 / 1000;
    int e = num % 100000 / 10000;
    int f = num / 100000;
    System.Console.WriteLine($"{num} -> {f},{e},{d},{c},{b},{a}");
}

}

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

SeparationOfNumber(number);