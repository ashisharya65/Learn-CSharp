
Console.WriteLine("\nWelcome to learning about arrays in C#.\n");

// Single dimensional array
int[] myarray = new int[3] { 34, 12, 60 };

int count = 0;
foreach (int arr in myarray)
{
    Console.WriteLine($"element at {count} index - {arr}");
    count++;
}
Console.WriteLine();

// Multidimensional array
Console.WriteLine("Multidimensional Array elements -\n");
int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write($"{numbers[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
