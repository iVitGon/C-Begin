void ZeroEvenElemets(int[] array)
{


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array[i] = 0;
        }

    }
}

void PrintArray(int [] array)
{
    foreach (int e in array)
    {
        Console.Write($"{e} ");
    }
}

int [] arr = {1,2,3,4,5};
ZeroEvenElemets(arr); // при передаче параметров тип данных не указываем
PrintArray(arr);