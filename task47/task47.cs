// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void RandomFillArray (double [,] newArray)
{
    Console.Write("Полученный двумерный массив:");
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(1,10);
            Console.Write($" {newArray[i, j]} ");
        }
    }
}

int userDataM = Convert.ToInt32(Console.ReadLine());
int userDataN = Convert.ToInt32(Console.ReadLine());

double [,] myArray =  new double [userDataM, userDataN];

RandomFillArray(myArray);