using static System.Console;
Clear();

WriteLine("Enter a number 1: ");
int number1 = int.Parse(ReadLine()!);

WriteLine("Enter a number2: ");
int number2 = int.Parse(ReadLine()!);


WriteLine(number1%number2==0?"Multiple":$"Not multiple, remainder is {number1%number2}");

WriteLine(number1==number2?"=":number1>number2? ">":"<");







