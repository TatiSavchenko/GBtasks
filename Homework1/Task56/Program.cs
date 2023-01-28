// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using MyLib;

int[,] ArrayMatrix = Methods.GetMatrixArray(3,4,1,10);
Methods.PrintMatrixArray(ArrayMatrix);
Console.WriteLine();
int [] result = SumElements(ArrayMatrix);
 
Console.WriteLine($"Results of calculing: {String.Join(",  ", result)} ");
Console.WriteLine();
int minValueResult = MinSum(result);
Console.WriteLine($"Number of line with min value:{minValueResult+1} ");



///Methods below///

int MinSum (int[] inArray)
{
    int count = 0;
    int min = inArray[0];
    for(int i=0; i<inArray.Length; i++)
    {
        if(inArray[i] < min)
        {
            min = inArray[i];
            count = i;
        }

    }
    return count; 
}


int[] SumElements (int[,] inArray)
{
    int[] sum = new int[inArray.GetLength(0)];
    for(int j=0; j<inArray.GetLength(1); j++ )
    {
        int i=0;
        for(; i<inArray.GetLength(0); i++)
        {
            sum[i] = sum[i] + inArray[i,j]; 
        }
    }
    return sum;
}