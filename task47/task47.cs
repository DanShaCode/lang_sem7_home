// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void RandomFillArray (double [,] fillRndArr)
{
    for (int i = 0; i < fillRndArr.GetLength(0); i++)
    {
        for (int j = 0; j < fillRndArr.GetLength(1); j++)
        {
            fillRndArr[i, j] = new Random().NextDouble() * 10;
        }
    }
}

void PrintArray (double [,] printArr)
{
    Console.WriteLine("Полученный двумерный массив:");
    Console.WriteLine();
    for (int index = 0; index < printArr.GetLength(0); index++)
    {
        for (int jndex = 0; jndex < printArr.GetLength(1); jndex++)
        {
            Console.Write($" {Math.Round(printArr[index, jndex], 1)} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
Console.WriteLine("Задайте двумерный массив размером M*N, который заполнится случайными вещественными числами.");
Console.WriteLine();
Console.Write("Введите число M: ");
int userDataM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userDataN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double [,] myArray =  new double [userDataM, userDataN];

RandomFillArray(myArray);
PrintArray(myArray);

// Протестировано 12.12.2022 13:24