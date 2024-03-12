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

