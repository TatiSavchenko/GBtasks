// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.Clear();
// Console.WriteLine("Input a number: ");
// int num10 = Convert.ToInt32(Console.ReadLine());

int num = AskUserForNumber("Input a number: ");
Console.WriteLine($"{System2(num)}");


// int [] array = System2(num10);
// Console.WriteLine($"[{String.Join(",",array)}]");
// int [] array2 = ReverseSystem2(array);

// Console.WriteLine($"[{String.Join(",",array2)}]");



string System2 (int numberin10)
{
    if(numberin10==0) return "0";

    string result = string.Empty;
    
   
        while(numberin10 >0)
    {
        int res= numberin10%2;
        numberin10 = numberin10/2;
        
        // numberin10 = numberin10/2; 
        
        result = res.ToString()+result;
        // result = result + numberin10.ToString();
    }
    return result;
}

// int[] ReverseSystem2 (int[] reverse)
// {
//     int[] rever = new int[reverse.Length];

//     for(int i=0; i<reverse.Length/2; i++)
//     {
//         rever[i] = rever[reverse.Length-1-i];
//     }
//     return rever;
// }

int AskUserForNumber( string A)
{
    int resultNum = 0;
    string userInput = " ";
    while(!int.TryParse(userInput, out resultNum))
    {
        Console.Write(A);
        userInput = Console.ReadLine()!;
    }
    return resultNum;
}