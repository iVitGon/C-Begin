//Напишите программу, которая принимает на вход трёхзначное целое число и на выходе показывает сумму
//первой и последней цифры этого числа.
//456 => 10
//782 => 9
//918 => 17

System.Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 100 && num <= 999)
{
    int ed = num % 10;
    int hund = num / 100;
    System.Console.WriteLine($"{num} -> {ed+hund}");

}

else
{
    System.Console.WriteLine("Вы ввели неверное число");
}
