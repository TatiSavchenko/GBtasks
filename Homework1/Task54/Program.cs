// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using MyLib;

int[,] ArrayMatrix = Methods.GetMatrixArray(3,4,1,10);
Methods.PrintMatrixArray(ArrayMatrix);
Console.WriteLine();

NewMatrixArray(ArrayMatrix);
Methods.PrintMatrixArray(ArrayMatrix);

void NewMatrixArray (int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    { 
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            for(int z=0; z<inArray.GetLength(1)-1; z++)
            {
                if(inArray[i,z] < inArray[i,z+1])
                {
                    int temp = 0;
                    temp = inArray[i,z];
                    inArray[i,z] = inArray[i,z+1];
                    inArray[i,z+1] = temp; 
                }
            }
        }  
    }
}