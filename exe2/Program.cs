Console.WriteLine("enter line number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("enter column number: ");
int m = int.Parse(Console.ReadLine());
int [,] numbers = new int [5,5];
FillArrayRandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("element not found");
}
else
{
    Console.WriteLine($"value line {n} and column {m}  = {numbers[n-1,m-1]}");
}

PrintArray(numbers);

void FillArrayRandomNumbers(int[,] myarray)
{
    for (int i = 0; i < myarray.GetLength(0); i++)
        {        
            for (int j = 0; j < myarray.GetLength(1); j++)
            {
                myarray [i,j] = new Random().Next(-10,10);
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
            Console.Write(thisarray[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
} 