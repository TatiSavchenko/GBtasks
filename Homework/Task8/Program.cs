using static System.Console;
Clear();

Write("Enter a number: ");
int N = int.Parse(ReadLine()!);
int a = 1;

while(a < N)
{
    a+=1;

    if(a%2==0)
    {
        Write($" {a} ");
    };
}


