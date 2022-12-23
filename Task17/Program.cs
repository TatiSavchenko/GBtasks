using static System.Console;
Clear();

WriteLine("Enter a quarter number: ");
int i = int.Parse(ReadLine()!);

switch(i)
{
    case 1:
    {
        WriteLine("x>0, y>0");
        break;
    }
    case 2:
    {
        WriteLine("x<0, y >0");
        break;
    }
    case 3:
    {
        WriteLine("x<0, y<0");
        break;
    }
    case 4:
    {
        WriteLine("x>0, y<0");
        break;
    }
    default:  //если не выполняется ни одно значение вызывается default
    {
        WriteLine("Error!");
        break;
    }
}


// if(i<1 || i>4)
// {
//    WriteLine("Error!");
//    return; // досрочно завершится программа
// }
// if (i == 1)
// {
//    WriteLine("x>0, y>0");
//}
// if (i == 2)
// {
//    WriteLine("x<0, y >0");
// }
//if(i == 3)
// {
//    WriteLine("x<0, y<0");
// }
// if(i == 4)
// {
//    WriteLine("x>0, y<0");
// }