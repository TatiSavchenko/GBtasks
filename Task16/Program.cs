using static System.Console;
Clear();

WriteLine("Enter a number 1: ");
int number1 = Convert.ToInt32(ReadLine());

WriteLine("Enter a number 2: ");
int number2 = Convert.ToInt32(ReadLine());

WriteLine(number1 == number2*number2?$"{number1} is a square of {number2}": 
number2==number1*number1?$"{number2} is a square of {number1}":"NO");
