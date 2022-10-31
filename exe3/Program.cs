Console.WriteLine("enter number of line: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("enter number of column: ");
int m = int.Parse(Console.ReadLine());
 
int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n; 
    Console.Write(avarage + "; ");
}
Console.WriteLine(); 
PrintArray(numbers);


void FillArrayRandomNumbers(int[,] myarray)
{
    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        for (int j = 0; j < myarray.GetLength(1); j++)
        {
            myarray[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] thisarray)
{

    for (int i = 0; i < thisarray.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < thisarray.GetLength(1); j++)
        {
            Console.Write(thisarray[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}