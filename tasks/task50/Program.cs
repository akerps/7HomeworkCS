/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном 
массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет   */

int[,] GenerateArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void printArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j]);
            if (j < arrayToPrint.GetLength(1) - 1)
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
int[,] array = GenerateArray(row, column);
printArray(array);

int[] convertArray(int[,] array)   
{
    int[] convArray = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            convArray[index] = array[i, j];
            index++;
        }
    }
    return convArray;
}

int[] convertationArray = convertArray(array);

Console.Write("Введите позицию искомого элемента (от нуля): ");
int numberIndex = Convert.ToInt32(Console.ReadLine());

int findElement(int[] array)
{
    if (numberIndex >= array.Length)
    {
        Console.WriteLine($"{numberIndex} -> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"{numberIndex} -> {array[numberIndex]}");
    }
    return array[numberIndex];
}
int result = findElement(convertationArray);