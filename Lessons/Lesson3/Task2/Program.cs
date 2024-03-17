void PrintSquare (int limit)
{
    int i = 1;
    while (i <= limit)
    {
        System.Console.Write($"{i*i} ");
        i = i + 1; // i++
    }
}

PrintSquare(5);
PrintSquare(10);
PrintSquare(15);