
Console.WriteLine("\nWelcome to learning about break and continue keyword in C#.\n");

// break keyword
int i = 0;
while (i < 10)
{
    if (i == 5)
        break;
    Console.WriteLine($"Iteration {i}.");
    i++;
}


// continue keyword
Console.WriteLine();
int j = 0;
while (j < 10)
{
    if (j == 5)
    {
        j++;
        continue;
    }
    Console.WriteLine($"Iteration {j}.");
    j++;
}
