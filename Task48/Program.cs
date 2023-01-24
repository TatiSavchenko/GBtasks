// **Задача 48:** Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Clear();
Console.Write("Input a size of matrix: ");
string [] parameters = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] arrayMatrix = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));
PrintMatrixArray(arrayMatrix);

int[,] GetMatrixArray(int rows, int columns)
{
    int[,] resultArray = new int[rows, columns];
    for(int i=0; i<resultArray.GetLength(0); i++)
    {
        for(int j=0; j<resultArray.GetLength(1); j++)
        {
            resultArray[i,j] = i+j;
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j],3} ");
        }
        Console.WriteLine();
    }
}