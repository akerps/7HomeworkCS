/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9   */

double [,] GenerateArray (int rowNumber, int colNumber)
{
    double[,] result = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i,j] = new Random().NextDouble()*20 - 10;
        }
    }
    return result;
}

void printArray(double [,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
       for (int j = 0; j < arrayToPrint.GetLength(1); j++)
       {
        Console.Write(Math.Round(arrayToPrint[i,j],1)); 
        if (j < arrayToPrint.GetLength(1) -1)
        {
            Console.Write("\t");
        }
       }
       Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] array = GenerateArray(row, column);
printArray(array);
