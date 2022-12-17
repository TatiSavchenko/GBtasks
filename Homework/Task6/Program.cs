using static System.Console;
Clear();

Write("Enter a number: ");
int n = int.Parse(ReadLine()!);

if(n%2 == 0)
{
    WriteLine("YES, the number is even");
}
else
WriteLine("NO");
