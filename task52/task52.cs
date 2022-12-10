// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

 void RandomFillArray (int [,] num)
 {
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = new Random().Next(1,10);
            Console.Write($"{num[i, j]} ");
        }
        Console.WriteLine();
    }
 }

Console.WriteLine();
Console.WriteLine("Задайте параметры массива.");
Console.WriteLine();
Console.Write("Введите количество строк: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int userCol = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [userRow, userCol];
Console.WriteLine();
Console.WriteLine("Массив успешно создан!"); 
Console.WriteLine();
RandomFillArray(numbers);