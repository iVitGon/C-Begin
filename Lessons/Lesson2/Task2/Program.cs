int n = 10;
int[] arr = new int[n];
int i = 0;

while(i < arr.length) // для заполнения используем цикл
{
    arr[i] = i + 1;
    System.Console.Write(arr[i]);
    System.Console.Write(" ");
    i = i + 1;
}
