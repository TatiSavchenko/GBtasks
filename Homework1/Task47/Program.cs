﻿// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using MyLib;
double[,] array = Methods.GetMatrixArray(3,4);
Methods.PrintMatrixArray(array);