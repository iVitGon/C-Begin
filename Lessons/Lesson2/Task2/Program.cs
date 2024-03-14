int n = 10;
int[] arr = new int[n];
int i = 0;
int j = 11;
while(i < n ) // для заполнения используем цикл
{
    arr[i] = j;//В теле цикла cформируем очередной элемент массива i+1, поместим его на позицию i
    System.Console.Write(arr[i]); // выведем на экран
    System.Console.Write(" ");
    j = j + 11;
    i = i + 1; // Перейдём к следующему значению переменной-счётчика, увеличив её на 1.
}
 System.Console.WriteLine();
int k = 1;
while(k < arr.Length)// мохно испольховать i < nc
{
    if (arr[k] % 2 == 0)
    {
        Console.Write ($"{arr[k]} ");        
    }
    k = k + 1;
}