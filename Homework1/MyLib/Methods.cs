namespace MyLib;
public class Methods
{
    ///<summary>
    ///Method 1
    ///</summary>
    public static int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int [,]ArrayMatrix = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j=0; j<columns; j++)          
        {
            ArrayMatrix[i,j] = rnd.Next(minValue, maxValue+1);
        }
    }
    return ArrayMatrix;
}


    ///<summary>
    ///Method 2 MatrixArrayDouble
    ///</summary>
    public static double[,] GetMatrixArray(int rows, int columns)
{
    Random rnd = new Random();
    double [,]ArrayMatrix = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j=0; j<columns; j++)          
        {
            ArrayMatrix[i,j] = rnd.NextDouble()*100;
        }
    }
    return ArrayMatrix;
}
 
 
    ///<summary>
    ///Method Double PrintMatrixArray
    ///</summary>
    public static void PrintMatrixArray(double[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j],8:f2} ");
        }
        Console.WriteLine();
    }
    
}
    
    
    ///<summary>
    ///Method PrintMatrixArray
    ///</summary>
public static void PrintMatrixArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j],5} ");
        }
        Console.WriteLine();
    }
    
}



}
