

//Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.



int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
/*
System.Console.WriteLine("Введите Количество строк матрицы");
int sizeRow = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов матрицы");
int sizeColumn = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение матрицы");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение матрицы");
int maxValue = Convert.ToInt32(Console.ReadLine());
*/
// PrintMatrix(CreateMatrix(sizeRow, sizeColumn, minValue, maxValue));



// Задайте двухмерный массив. Найдите элементы у которых оба идекса четные. Замените их значения квадратами значений.

int[,] SortMatrixToEven(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j = j + 2)
        {
            matrix [i,j] = matrix [i,j] * matrix [i,j];
        }
        
    }
    return matrix;
}   



// Задайте двухмерный массив и найдите сумму элементов, находящихся на его главной диагонали 
   // [0,0], [1,1], [2,2]


int SumOfDiag(int [,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + matrix[i,j];
            }

        }
        
    }
    return sum;
}

// Задайте двухмерный массив и создайте одномерный массив, сформированный из средних арифметических значений
// строк, двухмерного массива

double [] GetArrayArMean (int [,] matrix)
{
    
    double[] array = new double [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        double sum = 0;// т.е. будет обнуляться при каждой итерации внешнего цикла
        for (int j = 0; j < matrix.GetLength(1); j++)
        {         
            
            sum = sum + matrix[i,j];
            
        }
        array[i] = sum / matrix.GetLength(1);// т.к. i - это количество строк, первая строка - первое срАрифм и т.д.        
    }
    return array;
}

void PrintArray (double [] array)
{
    foreach (double r in array)
    {
        System.Console.Write(r + " ");
    }
}

System.Console.WriteLine("Введите Количество строк матрицы");
int sizeRow = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов матрицы");
int sizeColumn = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное значение матрицы");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение матрицы");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] matrix = CreateMatrix (sizeRow, sizeColumn, minValue, maxValue);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintArray(GetArrayArMean(matrix));