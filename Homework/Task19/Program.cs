using static System.Console;
Clear();

WriteLine("Enter a five-digit number: ");
int.TryParse(ReadLine(),out int N);

if(N <= 99999 && N >=10000)
{
    int a = N%100; int b = N/1000;
    
    Write(a/10 == b%10 && a%10 == b/10?"Yes, the number is Palindrome":"NO, the number is not Palindrome");
}
else
{
    WriteLine("Enter a five-digit number!");
}

