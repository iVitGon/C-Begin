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