using static System.Console;

WriteLine("Enter number a: ");
int a = int.Parse(ReadLine()!);

WriteLine("Enter number b: ");
int b = int.Parse(ReadLine()!);

if(a == b*b)
{
    WriteLine("YES");
}
else
{
    WriteLine("NO");
}
