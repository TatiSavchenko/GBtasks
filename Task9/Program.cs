using static System.Console;
Clear();
int number=new Random().Next(10, 100);
WriteLine(number);

WriteLine(number%2==0?"Even":"Odd"); // проверка на четность с тернарным оператором

int max = number/10 > number%10?number/10:number%10; // тернарный оператор int max=a1>a2?a1:a2; избавились от переменных

WriteLine(max); // WriteLine(a1>a2?a1:a2);

// if(a1>a2)
// {
//    WriteLine(a1);
// }
// else
// {
//    WriteLine(a2);
//}
