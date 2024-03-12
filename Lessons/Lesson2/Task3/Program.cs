int n = 10;
int[] arr = {1,4,6,8,45,34,44,56,2,15};
int i = 0;

while(i < arr.Length)// мохно испольховать i < nc
{
    if (arr[i] % 2 == 0)
    {
        Console.Write ($"{arr[i]} ");
        
    }
    i = i + 1;
}