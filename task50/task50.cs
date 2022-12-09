// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


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

void SearchElement (int [,] elSearch)
{
    Console.WriteLine();
    Console.WriteLine("Введите поочередно данные позиции элемента.");
    Console.WriteLine();
    Console.Write("Введите индекс строки: ");
    var Row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    var Col = Convert.ToInt32(Console.ReadLine());
    for (int ind = 0; ind < elSearch.GetLength(0); ind++)
    {
        if (Row < 0 
          | Row > elSearch.GetLength(0)
          | Row == elSearch.GetLength(0) 
          | Col < 0 
          | Col > elSearch.GetLength(1)
          | Col == elSearch.GetLength(1)) 
          {
            Console.WriteLine();
            Console.WriteLine("Такого элемента в массиве нет!");
            break;
          }
        for (int jnd = 0; jnd < elSearch.GetLength(1); jnd++)
        {
            if(ind == Row && jnd == Col)
            {
                Console.WriteLine();
                Console.WriteLine($"Значение элемента: {elSearch[ind, jnd]}");
                break;
            }
            else
            {
                continue;
            }
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
Console.WriteLine("Данная программа принимает на вход позиции элемента в двумерном массиве,"); 
Console.WriteLine("и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine();
Console.WriteLine("Для начала создайте массив.");
Console.WriteLine();
Console.Write("Введите количество строк в массиве: ");
int userDataRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int userDataCol = Convert.ToInt32(Console.ReadLine());
if (userDataRow == 0 | userDataCol == 0)
{
    Console.WriteLine();
    Console.WriteLine("Ошибка ввода. Массив не может быть создан с параметрами равными нулю.");
}
else
{
    int [,] newArray = new int [userDataRow, userDataCol];
    RandomFillArray(newArray);
    SearchElement(newArray);
    PrintArr(newArray);
}