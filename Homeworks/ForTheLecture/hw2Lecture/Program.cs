// Создать функции FillArray, PrintArray, GetSumOfElements, GetProductOfElements

using System.Data;
using System.Reflection;

void FillArray(int [] array)
{
    int i = 0;
    while(i < array.Length)
    {
        array[i] = i + 1;
        i = i + 1;
    }
}

void PrintArray(int [] array)
{
    
    foreach (int e in array)
    {
        System.Console.Write($"{e} ");
    }
}

int GetSumOfElements (int [] array)
{
    int i = 0;
    int sum = 0;
    {
        while (i < array.Length)
        {
            sum = sum + array[i];
            i = i + 1;            
        }
        return sum;
    }
}

int GetProductOfElements(int [] array)
{
    int product = 1;
    for (int i = 0; i < array.Length; i++)// очевидно, что если в значении массива, есть 0, то при его перемножении мы получим 0
    {
        product = product * array[i];

    }
    return product;
}
int n = 10;
int[] array = new int [n];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int sum = GetSumOfElements(array);
int product = GetProductOfElements(array);

System.Console.WriteLine(sum);
System.Console.WriteLine(product);