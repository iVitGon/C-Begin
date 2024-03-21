/*
считать с консоли символы, содержащие цифры и латинские буквы.
сформировать массив, состоящий из цифр из введенной строки
Например, 123dfg34 -> [1 2 3 3 4]
Разделить логику алгоритма на функции
Память под массив выделять необходимого размера (не больше, чем количество элементов массива)

*/
int GetNumbersFromString (string symbol)
{
    int countSize = 0;
    string digit = "";
    foreach (char symb in symbol)
    {
        if (char.IsAsciiDigit(symb) == true)
        {
            digit = digit + 1;
            countSize = countSize + 1;
        }
  
    }
    return countSize;

} 

string GetDigitFromString (string symbol)
{
    string letter = "";
    string digit = "";
    foreach (char symb in symbol)
    {
        if (char.IsAsciiLetter(symb) == true)
        {
            letter = letter + symb;
            
        }
        else
        {
            digit = digit + symb;
        }
  
    }
    return digit;

} 

int [] FillArray (int[] array, int digits) 
{
    for (int j = 0; j < array.Length; j++)
    {
        if (digits > 0)
        {
            array[j] = digits % 10;
            digits = digits /10;
        }
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

int [] ReverseArray(int [] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
    return arr;
}

System.Console.WriteLine("Введите символы ");
string symbol = Console.ReadLine();

int size = GetNumbersFromString(symbol);
System.Console.WriteLine(size);
string digit = GetDigitFromString(symbol);
System.Console.WriteLine(digit);
int[] array = new int [size];
int digits = Convert.ToInt32(digit);
int [] arr = FillArray(array,digits);
PrintArray(arr);
System.Console.WriteLine();
int [] reverseArr = ReverseArray(arr);
PrintArray(reverseArr);
