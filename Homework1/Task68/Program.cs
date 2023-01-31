// Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int resAkk = Akkerman(2,3);
Console.WriteLine(resAkk);
Console.WriteLine();
int resAkk1 = Akkerman(3,2);
Console.WriteLine(resAkk1);


int Akkerman (int m, int n)
{
    if(m==0) return n+1;
    else
    {
        if(m!=0 && n==0)
        {
            return Akkerman(m-1,1);
        }
        else
        {
            return Akkerman(m-1, Akkerman(m,n-1));
        }   
    }
}














