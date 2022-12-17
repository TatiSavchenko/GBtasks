using static System.Console;
Clear();

Write("Enter number 1: ");
int n1 = int.Parse(ReadLine()!);

Write("Enter number 2: ");
int n2 = int.Parse(ReadLine()!);

if(n1 > n2)
{
    Write($"Max {n1} ");

    Write($"Min {n2} ");
}

if(n1 < n2)
{
    Write($"Max {n2} ");

    Write($"Min {n1} ");
}
else
{
    Write($"{n1} = {n2}");
}

