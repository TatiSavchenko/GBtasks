using static System.Console;
Clear();

Write("Enter a number: ");
int.TryParse(ReadLine(),out int N);

int a = 0;
while(a <= N)
{
    Write($"{Math.Pow(a,3)} | ");
    a++;
}
