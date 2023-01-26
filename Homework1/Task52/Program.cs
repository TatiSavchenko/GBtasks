// Задача 52. Напишите программу реализующую методы, формирования двумерного массива 
// и массива средних арифметических значений каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using MyLib;
Console.Clear();

int[,] arrayMatrix = Methods.GetMatrixArray(7, 8, 1, 20);
Methods.PrintMatrixArray(arrayMatrix);

Console.WriteLine();
double [] average = GetAverageColumnArray(arrayMatrix);
Console.WriteLine($"[{String.Join(",  ", average)}] ");

double[] GetAverageColumnArray(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];

    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int j = 0;
        for (; j < inArray.GetLength(0); j++)
        {
            result[i] = result[i]+ inArray[j, i];
        }
        result[i] = Math.Round((result[i] / j), 1);
    }

    return result;
}
