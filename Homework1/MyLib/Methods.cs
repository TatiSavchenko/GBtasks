namespace MyLib;
public class Methods
{
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
}
