// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using MyLib;

int[,] arrayA = Methods.GetMatrixArray(2,3,1,10);
Methods.PrintMatrixArray(arrayA);

Console.WriteLine();
int[,] arrayB = Methods.GetMatrixArray(3,2,1,10);
Methods.PrintMatrixArray(arrayB);

Console.WriteLine();
int[,] arrayC = MultiMatrix(arrayA, arrayB);
Methods.PrintMatrixArray(arrayC);

int[,] MultiMatrix (int[,] inArrayA, int[,] inArrayB)
{
    int[,] arrayMulti = new int[inArrayA.GetLength(0), inArrayB.GetLength(1)];
    
    if(inArrayA.GetLength(0) == inArrayB.GetLength(1))
    {
        for(int i=0; i<arrayMulti.GetLength(0); i++)
        {
            for(int j=0; j<arrayMulti.GetLength(1); j++)
            {
                for(int z=0; z<inArrayA.GetLength(1); z++)
                {
                    {
                        arrayMulti[i,j] = arrayMulti[i,j] + (inArrayA[i,z]*inArrayB[z,j]);
                    }
                }
            }
        }
    }
    else
    {
        Console.WriteLine("It can not be multiplicated because of the sizes");
    }

    return arrayMulti;
}