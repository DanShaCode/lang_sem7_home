// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void CreateRandomArray (double [,] newArray)
{
    Console.WriteLine("Полученный двумерный массив:");
    Console.WriteLine();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().NextDouble() * 10;
            Console.Write($" {Math.Round(newArray[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
Console.WriteLine("Задайте двумерный массив размером M*N, заполненный случайными вещественными числами.");
Console.WriteLine();
Console.Write("Введите число M: ");
int userDataM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userDataN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double [,] myArray =  new double [userDataM, userDataN];

CreateRandomArray(myArray);