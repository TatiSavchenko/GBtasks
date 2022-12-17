using static System.Console;
Clear();
WriteLine("Enter a number: ");
int number = int.Parse(ReadLine()!);

if(number >=100 && number < 1000)
{
    Write("The last digit is: ");
    Write(number%10);
}
else
{
    WriteLine("Enter other number of xxx");
    return;
}