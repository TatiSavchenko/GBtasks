using static System.Console;
Clear();

Write("Enter a number from 1 to N: ");
int.TryParse(ReadLine(),out int N);
int a = 0;

while(a <= N)
{
    Write($"{Math.Pow(a,2)} | ");
    a = a+1;
}
