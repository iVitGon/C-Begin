//ДЗ!
// Задача 4. Найти и вывести все четные числа от 1 до N

/*
Console.WriteLine("Введите число от 1 до N ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 2;

if (number >= 2)
{
    while (i <= number)
    {
        if (i % 2 == 0)
        {
            System.Console.Write($"{i} ");
            i = i + 2;
        }
        else
        {
            i = i + 1;
        }

    }
    

}


else
{
    System.Console.WriteLine("Введено некорректоное число. Необходимо ввовдить числа от 1 до N");
}
*/

// ВТООРОЙ ВАРИАНТ РЕШЕНИЯ ЗАДАЧИ

// Console.WriteLine("Введите число от 1 до N ");
// int n = Convert.ToInt32(Console.ReadLine());

// while (n > 1)
// {
//     if (n % 2 == 0)
//     {
//         System.Console.Write($"{n} ");
//         n = n - 2;
//     }
//     else
//     {
//         n = n - 1;
//     }    
// }

/*using System;

public class Answer {
    static void PrintEvenNumbers(int number)
    {
      // Введите свое решение ниже
Console.WriteLine("Введите число от 1 до N ");
int n = Convert.ToInt32(Console.ReadLine());

while (n > 1)
{
    if (n % 2 == 0)
    {
        System.Console.Write($"{n} ");
        n = n - 2;
    }
    else
    {
        n = n - 1;
    }    
}

    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 6;
        }

        // Не удаляйте строки ниже
        PrintEvenNumbers(number);
    }
} // Проверяем решение
*/


//ЗАДАЧА 1. Сравнить два числа и вывести на экран "заключение"

using System;

public class Answer
{
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        Console.WriteLine("Введите первое число");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int n2 = Convert.ToInt32(Console.ReadLine());
        if (n1 == n2)
        {
            Console.WriteLine("числа равны");
        }
        if (n1 > n2)
        {
            Console.WriteLine("первое число больше");
        }
        if (n2 > n1)
        {
            Console.WriteLine("второе число больше");
        }

    }



    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int firstNumber, secondNumber;

        if (args.Length >= 2)
        {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}




