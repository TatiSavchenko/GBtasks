using static System.Console;
Clear();

WriteLine("Enter a number: ");
int number = Convert.ToInt32(ReadLine());


while(number>999)
{    
    number = number/10; //продолжаем делить на 10
    

}

WriteLine(number<100?"Third digil does not exist":$"{number%10}");


