using static System.Console;
Clear();

WriteLine("Enter a three-digit numbrer: ");
int number = Convert.ToInt32(ReadLine());

WriteLine(number>100 && number <1000?number/10%10:
"Enter other number corresponding to the condition");

// if(number >100 && number <1000)
// {
//    WriteLine($"{number/10%10}");
// }
// else
// {
//    WriteLine("Enter other number corresponding to the condition!");
//}

