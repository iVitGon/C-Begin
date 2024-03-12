
 int[] arr  = new int [5];// создаем говый массив с выделением памяти для 5 элементов
                         // если нужен был массив из вещественных чисел, тип данных double или float
arr [0] = 5;// Заполняем массив, обращаясь к кажой ячейки по индексу
arr [1] = 7;
arr [2] = 5;
arr [3] = 4;
arr [4] = 3;

System.Console.WriteLine(arr[0]);
System.Console.WriteLine(arr[1]);
System.Console.WriteLine(arr[2]);
System.Console.WriteLine(arr[3]);
System.Console.WriteLine(arr[4]);

int[] arr2 = new int[5]{1,2,3,4,5}; // создание с заполнением массива

int [] arr3 = {1,2,3,4,5};// упрощенный вариант создания массива, когда известно количество элементовсв
