
Console.WriteLine("\nWelcome to learning about if-else statements in C#.\n");

int x = 5;
if (x == 10)
{
    Console.WriteLine("x value equals to 10");
}
else if (x > 10)
{
    Console.WriteLine("x is greater than 10");
}
else
{
    Console.WriteLine("x value is less than 10");
}

// ternary operator
int a = 5, b = 20;
string result = (a > b) ? "a is greater b" : "a is less than b";
Console.WriteLine(result);
