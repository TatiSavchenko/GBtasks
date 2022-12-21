using static System.Console;
Clear();
WriteLine("Enter a number of the day of the week: ");
int day = Convert.ToInt32(ReadLine());

if(day<=7 && day>=1)
{
    WriteLine(day==7 || day==6? "Weekend!":"Work day!");
}
else
{
    WriteLine("Enter a number corresponding to the condition!");
}
