using static System.Console;
Clear();

WriteLine("Enter a number of the day of week: ");
int day = int.Parse(ReadLine()!);

switch(day)
{
    case 1:
    {
        WriteLine("Monday");
        break;
    }
    case 2:
    {
        WriteLine("Tuesday");
        break;
    }
    case 3:
    {
        WriteLine("Wednesday");
        break;
    }
    case 4:
    {
        WriteLine("Thursday");
        break;
    }
    case 5:
    {
        WriteLine("Friday");
        break;
    }
    case 6:
    {
        WriteLine("Saturday");
        break;
    }
    case 7:
    {
        WriteLine("Sunday");
        break;
    }
    default:
    {
        WriteLine("Error");
        break;
    }
}
