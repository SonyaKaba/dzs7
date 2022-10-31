Console.WriteLine("enter m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("enter n: ");
int n = int.Parse(Console.ReadLine());

double[,] GetArray(int m, int n)

{
    double[,] myarray = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        for (int j = 0; j < myarray.GetLength(1); j++)
        {
            myarray[i, j] = new Random().Next(-10,10);
        }
    }
    return myarray;
}

void PrintArray(double[,] thisarray)
{
    for (int i = 0; i < thisarray.GetLength(0); i++)
    {
        for (int j = 0; j < thisarray.GetLength(1); j++)
        {
           Console.Write($"{thisarray[i,j]} ");
        }
       Console.WriteLine();
    } 

}
PrintArray(GetArray(m,n)); 