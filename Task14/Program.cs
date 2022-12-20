using static System.Console;
Clear();

WriteLine("Enter a number: ");
int number = Convert.ToInt32(ReadLine());

WriteLine(number%7==0 && number%23==0?"Multiple":"NO");


