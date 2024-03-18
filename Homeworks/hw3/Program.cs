// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов 
// массива, значения которых лежат в отрезке [20,90]. 

/*

void FillArray(int [] array)
{
    Random rnd = new Random(); // выделение памяти для переменной rnd  типа данных Random

    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 100);        
    }

}

void PrintArray(int [] array)
{
    foreach (int e in array)
    {
        System.Console.Write($"{e} ");
    }

}

int SortArray20to90(int [] array)
{
    int sum = 0; // счетчик, отражающий количество подходящих под параметры элементов
    int nsum = 0;// счетчик остальных элементов
    int i = 0;// счетчик для элементов массива
    while (i < array.Length)
    {
        if (array[i] >= 20 && array[i] <= 90)
        {
            sum = sum + 1;
            i = i + 1;
        }
        else
        {
            nsum = nsum + 1;
            i = i + 1;
        }      
              
    }
    return sum;
}

int size = 10; // Длина массива
int[] arr = new int[size];// Выделим память под новый массив размером size

FillArray(arr);
PrintArray(arr);
System.Console.WriteLine();
int result = SortArray20to90(arr);

System.Console.WriteLine(result);

*/



// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет 
// количество чётных чисел в массиве.

void FillRandomArray (int [] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 1000); 
    }

}

void PrintArray(int [] array)
{
    foreach (int e in array)
    {
        System.Console.Write($"{e} ");
    }
}

int SortOfEvenArray(int [] array)
{
    int even = 0;
    int notEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even = even + 1;

        }
        else
        {
            notEven = notEven + 1;
        }
    }
    return even;
}

int size = 10;
int [] arr = new int[size];

FillRandomArray(arr);
PrintArray(arr);
System.Console.WriteLine();
int result = SortOfEvenArray(arr);

System.Console.WriteLine(result);


