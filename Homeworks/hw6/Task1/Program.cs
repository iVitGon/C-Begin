// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.



char [,] SymbolMatrix (int row, int column)
{
    char [,] sMatrix = new char[row, column];
    
    for (int i = 0; i < sMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sMatrix.GetLength(1); j++)
        {
            System.Console.Write($"Введите букву , расположенную на позиции [{i},{j}]");
            sMatrix[i,j] = Convert.ToChar(Console.ReadLine());
        }
    }
    return sMatrix;
}

void PrintMatrix(char[,] sMatrix)
{
    for (int i = 0; i < sMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sMatrix.GetLength(1); j++)
        {
            System.Console.Write(sMatrix[i,j]);
        }
        System.Console.WriteLine();
    }
    
}

string MakeStringsOfLetters(char[,] sMatrix)
{
    string str = "";
     for (int i = 0; i < sMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < sMatrix.GetLength(1); j++)
        {
            str = str + sMatrix[i,j];
            
        }
        
    }
    return str;

}

System.Console.Write($"Введите количество строк");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());

char[,] symbolMatrix = SymbolMatrix(row,column);
PrintMatrix(symbolMatrix);
string str = MakeStringsOfLetters(symbolMatrix);
System.Console.WriteLine(str);

