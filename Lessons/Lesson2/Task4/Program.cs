// Залача с гирями
int n = 5;
int [] arr = {12, 8, 32, 24, 16};
int i = 0;
int max = arr[0];

while (i < n)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;

}
System.Console.WriteLine(max);

max = arr[0];
for (int j = 0; j < n; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
    
}
System.Console.WriteLine(max);

max = arr[0];
foreach (int e in arr)
{
    if (e > max)         // Мы не можем обратиться по индексу, а лишь к переменной в которую поочередно копирутся
                         // элементы массива
    {
        max = e;
    }
}
System.Console.WriteLine(max);