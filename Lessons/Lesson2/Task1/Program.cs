﻿
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


// int [] - именно так обозначается массив, содержащий целочисленные переменные
// массив должен иметь имя, чтобы к нему обращаться, напримеп, array( arr или как-то еще)
// int [] array - массив содержащий целочисленные элеменнты с именем array
// new - оператор выделения памяти для нового
// new int [] - выделение памяти для нового массива на [] элементов
// new int [5] - выделение памяти для нового массива на 5 элементов
// int [] array = new int [10] - создадим новый  массив array, содержащий целочисленные элементы,
//                               и выделим память на 10 элементов

int n = 10; // создадим целочисленную переменную n и зададим ей значение 10
int[] array = new int[n];// создадим массив, содержащий целочисленные элементы, выделим память на n элементов

int i = 0;    //Создадим переменную-счётчик i, равную 0.
while (i < n ) // Создадим цикл while c условием i<n.

{
    
    array[i] = i + 1;
    System.Console.Write($"{array[i]}, ");
    i = i + 1;
    
}

