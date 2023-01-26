// Задача 50. Напишите программу реализующую метод,
// принимающий позиции элемента в двумерном массиве,
//  и возвращающий значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using MyLib;
Console.Clear();

int[,] array = Methods.GetMatrixArray(6, 8, 1, 20);
Methods.PrintMatrixArray(array);

Console.WriteLine();
Console.WriteLine("Input values i and j of element separated by ; : ");

string [] parameters = Console.ReadLine()!.Split(";", StringSplitOptions.RemoveEmptyEntries);
int element = ValueElement(array, int.Parse(parameters[0]), int.Parse(parameters[1]));

Console.WriteLine(element);

int ValueElement(int[,] inArray, int i, int j)
{
    int value = 0;
    if(i<inArray.GetLength(0) && j<inArray.GetLength(1))
    {
        value=value+inArray[i,j];
    }
    else
    {
        Console.WriteLine($"The element does not exist in the current array!");
    }
    
    return value;
}