

int [,] CreateMatrix(int sizeRow, int sizeColumn)
{
    int [,] matrix = new int [sizeRow, sizeColumn];
    return matrix;
}


int [,] FillMatrix (int [,] matrix, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(minValue, maxValue);
        }
    }
    return matrix;
}

void PrintMatrix (int [,] fillMatrix)
{
    for (int i = 0; i < fillMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fillMatrix.GetLength(1); j++)
        {
            System.Console.Write(fillMatrix[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    
}

/*
int SumSideSquareI0 (int [,] fillMatrix)
{
    int sumSqI0 = 0;
    

    for (int i = 0; i < fillMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fillMatrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                sumSqI0 = sumSqI0 + fillMatrix[i,j];
            }
        }
    }
    return sumSqI0;
}

int SumSideSquareJ0 (int [,] fillMatrix)
{
   
    int sumSqJ0 = 0;

    for (int i = 0; i < fillMatrix.GetLength(0); i++)//
    {
        for (int j = 0; j < fillMatrix.GetLength(1); j++)
        {
            if (j == 0)
            {
                sumSqJ0 = sumSqJ0 + fillMatrix[i,j];
            }
        }
    }
    return sumSqJ0;
}

int SumSideSquareJLength (int [,] fillMatrix, int sizeColumn)
{
    
    int sumSqJLength = 0;
    

    for (int i = 0; i < fillMatrix.GetLength(0); i++)//
    {
        for (int j = 0; j < fillMatrix.GetLength(1); j++)
        {
            if (j == sizeColumn - 1)
            {
                sumSqJLength = sumSqJLength + fillMatrix[i,j];
            }
        }
    }
    return sumSqJLength;
}

int SumSideSquareILength (int [,] fillMatrix, int sizeRow)
{
    
    int sumSqILength = 0; 

    for (int i = 0; i < fillMatrix.GetLength(0); i++)//
    {
        for (int j = 0; j < fillMatrix.GetLength(1); j++)
        {
            if (i == sizeRow - 1)
            {
                sumSqILength = sumSqILength + fillMatrix[i,j];
            }
        }
    }
    return sumSqILength;
}


*/
int [] SumRowInMatrix (int [,] array)
{
    int [] arr = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        arr[i] = sum;
    }
    return arr;
}  

void PrintArray (int [] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
}

int FindIndexMinValue(int [] array)
{
    int min = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            index = i;
        }
        
    }
    return index;
}

System.Console.WriteLine("Введите Количество строк матрицы");
int sizeRow = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов матрицы");
int sizeColumn = Convert.ToInt32(Console.ReadLine());

int [,] matrix = CreateMatrix(sizeRow, sizeColumn);

System.Console.WriteLine("Введите минимальное значение матрицы");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное значение матрицы");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] fillMatrix = FillMatrix(matrix, minValue, maxValue);
PrintMatrix(fillMatrix);
System.Console.WriteLine();

int[] array = SumRowInMatrix(fillMatrix); 
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(FindIndexMinValue(array));




/*
int sumSq1 = SumSideSquareI0(fillMatrix);
System.Console.WriteLine($"Верхняя сторона прямоугольника равна {sumSq1}");

int sumSq2 = SumSideSquareJ0(fillMatrix);
System.Console.WriteLine($"Левая сторона прямоугольника равна {sumSq2}");

int sumSqJLength = SumSideSquareJLength(fillMatrix, sizeColumn);
System.Console.WriteLine($"Правая сторона прямоугольника равна {sumSqJLength}");

int sumSqILength = SumSideSquareILength(fillMatrix, sizeRow);
System.Console.WriteLine($"Нижняя сторона прямоугольника равна {sumSqILength}");

*/