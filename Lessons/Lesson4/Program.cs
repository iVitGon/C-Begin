
/*
int [,] matrix = new int [3,5]; // выделить память на три строки и пять элементов

Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) // GetLength (0) запрашиваем количество строк в двухмерном массиве
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        //Random rnd = new Random(); - операция "ресурсоемкая", поэтому внутри цикла лучше не использовать
        matrix[i, j] = rnd.Next(1, 11);
    }
}

for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}

System.Console.WriteLine();

int [,] CreareMatrix (int rowCount, int columnCount)
{
    int [,] matrix = new int [rowCount, columnCount];

    Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) // GetLength (0) запрашиваем количество строк в двухмерном массиве
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        //Random rnd = new Random(); - операция "ресурсоемкая", поэтому внутри цикла лучше не использовать
        matrix[i, j] = rnd.Next(1, 11);
    }
}
return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

int [,] matrixNew = CreareMatrix (4, 5);
PrintMatrix(matrixNew);

*/


// Интересный массив
/*

int[,] CreareMatrix(int rowCount, int columnCount)
{
    int[,] matrix = new int[rowCount, columnCount];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // GetLength (0) запрашиваем количество строк в двухмерном массиве
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Random rnd = new Random(); - операция "ресурсоемкая", поэтому внутри цикла лучше не использовать
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

int[,] matrix = CreareMatrix(3, 4);
PrintMatrix(matrix);

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.WriteLine($"{e} ");
    }
}

bool IsInteresting(int value)
{
    int sumOfDigit = GetSumOfDigits(value);
    if (sumOfDigit % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}

*/



// Создать строку, состоящую из букв, приняв на вход чисельно - буквенные символы

/* Этапы решения
1. string - это массив char. Т.е. каждая буква в строке лежит под в ячейке род своим индексом
string str = "Hello, World";
System.Console.WriteLine(str[11]); ---> d
2. Создане строк (3 варианта)
 - string s1 = "Hello";
 - char [] ch_array ={'H','e','l','l','o'};
 - string s2 = new String (ch_array);

3. принять строку
4. проход по каждому элементу
5. Буква или нет
6. Если буква, то дописать (конкатенация, т.е. к концу одной строки преписывает начало другой)
Конкатиеация - оператор "+"

*/
string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAskiiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}


string str = Console.ReadLine();
string result = GetLettersFromString(str);
System.Console.WriteLine(result);


