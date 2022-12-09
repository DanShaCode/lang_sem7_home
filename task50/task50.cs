// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void RandomFillArray (int [,] numbers)
{
    Console.WriteLine();
    Console.WriteLine("Массив создан!");
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for(int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1,11); 
        }
    }
}

void CheckMatchArray (int [,] checkArr)
{
    Console.WriteLine("Попробуйте угадать число в массиве.");
    Console.WriteLine("Введите, пожалуйста, свое число: ");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    for (int ind = 0; ind < checkArr.GetLength(0); ind++)
    {
        for (int jnd = 0; jnd < checkArr.GetLength(1); jnd++)
        {
        if (userNumber == checkArr [ind, jnd]) Console.WriteLine ("Найдено совпадение!");
        if (userNumber != checkArr [ind, jnd]) Console.WriteLine("Совпадений нет!");
        }
    }
}

void PrintArr (int [,] printArrElements)
{
    Console.WriteLine();
    Console.WriteLine("Сгенерированный массив: ");
    Console.WriteLine();
    for (int index = 0; index < printArrElements.GetLength(0); index++)
    {
        for (int jndex = 0; jndex < printArrElements.GetLength(1); jndex++)
        {
            Console.Write($"{printArrElements[index, jndex]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.Write("Введите количество строк в массиве: ");
int userDataRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int userDataCol = Convert.ToInt32(Console.ReadLine());

int [,] newArray = new int [userDataRow, userDataCol];

RandomFillArray(newArray);
CheckMatchArray(newArray);
PrintArr(newArray);