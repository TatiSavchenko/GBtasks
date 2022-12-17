using static System.Console;
Clear();

WriteLine("Enter a number 1: ");
int a = int.Parse(ReadLine()!);

WriteLine("Enter a number 2: ");
int b = int.Parse(ReadLine()!);

WriteLine("Enter a number 3: ");
int c = int.Parse(ReadLine()!);

int max = a;

if(b > max)
{
    max = b;
}

if(c > max)
{
    max = c;
}

Write($"Maximum is {max}");





