// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива"
// или "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

int[,] CreateMatrix(int row, int columns)
{
    int[,] matrix = new int[row, columns];
    return matrix;
}

int[,] FillMatrixRandom(int[,] createdMatrix, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < createdMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < createdMatrix.GetLength(1); j++)
        {

            createdMatrix[i, j] = rnd.Next(min, max);
        }
    }
    return createdMatrix;
}

void PrintMatrix(int[,] filledMatrix)
{
    for (int i = 0; i < filledMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < filledMatrix.GetLength(1); j++)
        {
            System.Console.Write(filledMatrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void CallElement(int[,] filledMatrix, int x, int y, int row, int column)
{
    if (x >= row)
    {
        System.Console.WriteLine("Позиция по рядам выходит за пределы массива");

    }
    if (y >= column)
    {
        System.Console.WriteLine("Позиция по колонкам выходит за пределы массива");

    }
    if (x < row && y < column)
    {
        int a = 0;
        int b = 0;
        for (int i = 0; i < filledMatrix.GetLength(0); i++)
        {
            if (i == x)
            {
                a = i;
            }

            for (int j = 0; j < filledMatrix.GetLength(1); j++)
            {
                if (j == y)
                {
                    b = j;
                }
            }
        }
        System.Console.WriteLine(filledMatrix[a, b]);
    }   
}


System.Console.WriteLine("Введите количество строк в массиве ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов в массиве ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] createdMatrix = CreateMatrix(row, columns);
System.Console.WriteLine();
System.Console.WriteLine("Введите минимальное значение для матрицы ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение для матрицы ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] filledMatrix = FillMatrixRandom(createdMatrix, min, max);
PrintMatrix(filledMatrix);

System.Console.WriteLine("Введите номер элемента по ряду матрицы (Х) ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер элемента по колонке матрицы (Y) ");
int y = Convert.ToInt32(Console.ReadLine());

CallElement(filledMatrix, x, y, row, columns);



