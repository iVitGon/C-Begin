//  Задача3. Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним,
//  второй – предпоследним и т.д.)

/*

int[] CreateArray(int size, int min, int max)
{
    int [] array = new int [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int [] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
}

int [] SortValueElementary (int [] array)
{
   int[] temp = new int[1];
   for (int i = 0; i < array.Length / 2;i++)
   {
        temp[0] = array[i];
        array [i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp[0]; 
   }
   return array;   
}


System.Console.WriteLine("Введите длину массива" );
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение границы массива");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение границы массива");
int max = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int [] array = CreateArray(size, min, max);
PrintArray(array);
System.Console.WriteLine();
int [] result = SortValueElementary(array);
PrintArray(array);

*/

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.


/*
int [] FillArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int [] array)
{
    foreach(int item in array)
    {
        System.Console.Write($"{item} ");
    }
}

int CountEvenInArray(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] % 2 ==0)
        {
            count = count + 1;
        }
    }
    return count;
}


System.Console.WriteLine("Введите длину массива" );
int size = Convert.ToInt32(Console.ReadLine());
int [] array = FillArray(size);
PrintArray(array);
System.Console.WriteLine();
int countEven = CountEvenInArray(array);
System.Console.WriteLine(countEven);



// Задача1. Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

void InputIntNumber(int number, string symb)
{
    while (true)
    {
        
        int i = 0;

        if (number % 2 != 0)
        {
            i++;
        }
        
        else
        {
            break;
        }
    }
}

 System.Console.WriteLine("Введите число ");
        int number = Convert.ToInt32(Console.ReadLine());
        string symb = Console.ReadLine();

InputIntNumber(number, symb);

