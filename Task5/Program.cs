﻿using static System.Console;

Write("Enter a number: ");
int a = int.Parse(ReadLine()!);
int n = -a;

while (n <= a)
{
    Write( $" {n} ");
    n = n + 1;
}       