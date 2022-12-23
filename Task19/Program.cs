using static System.Console;
Clear();

WriteLine("Enter x: ");
int x = int.Parse(ReadLine()!);

WriteLine("Enter y: ");
int y = int.Parse(ReadLine()!);

if(x>0)
{
    if(y>0)
    {
        WriteLine("First quarter");
        return;
    }
    if(y<0)
    {
        WriteLine("Forth quarter");
        return;
    }
}
if(x<0)
{
    if(y>0)
    {
        WriteLine("Second quarter");
        return;
    }
    if(y<0)
    {
        WriteLine("Third quarter");
        return;
    }
}
if(x==0 || y==0)
{
    WriteLine("Error");
    return;
}