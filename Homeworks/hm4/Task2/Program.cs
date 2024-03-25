// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int [,] CreateMatrix (int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    return matrix;
    
}

int [,] FillMatrix(int [,] matrix, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix; 
}

void PrintMatrix ( int [,] FillMatrix)
{
    for (int i = 0; i < FillMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < FillMatrix.GetLength(1); j++)
        {
           System.Console.Write(FillMatrix[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

int [,] ChangeRowsInMatrix (int [,] matrix)
{
    int [] tempArray = new int [matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                tempArray[j] = matrix[i,j];
            }
            if (i == matrix.GetLength(0) - 1)
            {
                matrix [0,j] = matrix[matrix.GetLength(0) - 1,j];
            }

        }
    } 
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == matrix.GetLength(0) - 1)
            {
                matrix [i,j] = tempArray[j];
            }

        }
    } 
    return matrix; 
}




System.Console.WriteLine("Введите количество строк в массиве");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов в массиве");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());




int [,] newMatrix = CreateMatrix(rows, columns);
int [,] matrix = FillMatrix(newMatrix, min, max);
PrintMatrix(FillMatrix(newMatrix, min, max));
System.Console.WriteLine();
int [,] changeMatrix = ChangeRowsInMatrix(matrix);
PrintMatrix(changeMatrix);
