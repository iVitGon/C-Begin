//Задайте массив символов (тип char []). Создайте строку из символов этого массива.
//Указание
//Конструктор строки вида string(char []) не использовать.

/*

Тот самы вариант, который по указанию к заданию является недопустимым.


// char[] chars = {'a', 'b', 'c', 'd', 'e','f'};//т.е. это одномерный массив, заполненный символами
// string result = new string(chars); // один из методов создать строку 
// System.Console.WriteLine(result);

*/


/*
// Вар1
string CharsArrayToString(char [] chars)
{
    string result = ""; // "" обозначает пустую строку, т.е. память выделена, но значением незаполнена
    for (int i = 0; i < chars.Length; i++)
    {
        result = result + chars[i];
    }
    return result;
}

//Вар2
char[] InputCharArr(int n) // напишем метод, который принимает значения char от пользователя. В таком случае для метода нужна длина массива
{
    char[] chars = new char[n];
    for (int i = 0; i < n; i++)
    {
        chars[i] = Convert.ToChar(Console.ReadLine());   
    }
    return chars;

}

void PrintCharArray(char [] array)
{
    foreach (char item in array)
    {
        System.Console.Write(item);
    }
}

// для варианта 1
char[] chars = {'a', 'b', 'c', 'd', 'e','f'};
System.Console.WriteLine(CharsArrayToString(chars));

//Для варианта 2
char[] charsNew = InputCharArr(10);
PrintCharArray(charsNew);



*/


//На основе символов строки (тип string) сформировать массивсимволов (тип char[]). Вывести массив на экран.
//Указание
//Метод строки ToCharArray() не использовать

/*

char [] MyToCharArray(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < chars.Length; i++)
    {
       chars[i] = str[i]; 
    }
    return chars;
}

void PrintCharArray(char [] array)
{
    foreach (char item in array)
    {
        System.Console.Write(item + " ");
    }
}

System.Console.WriteLine("Введите строку");
string str = Console.ReadLine();
PrintCharArray(MyToCharArray(str));


*/


// Считать строку с консоли, состоящую из латинских
//букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.
//Пример
//“hello” => 2
//“world” => 1


int FindVowelInString(string str)
{
    char[] chars = {'a', 'e', 'y', 'u', 'e','o'};
    int count = 0;
    for (int i = 0; i < chars.Length; i++)
    {
        
        foreach (char item in str)
        {
            if (item == chars[i])
            {
                count = count + 1;
            }
        }
    }
    return count;
}

System.Console.WriteLine("Введите строку");
string str = Console.ReadLine();

System.Console.WriteLine(FindVowelInString(str));

