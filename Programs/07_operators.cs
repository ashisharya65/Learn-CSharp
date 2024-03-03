

Console.WriteLine("\nWelcome to learning about operators in C#.\n");

// Arithmetic operators
Console.WriteLine("=================================================================");
Console.WriteLine("\t\t\tArithmetic Operators");
Console.WriteLine("=================================================================");
Console.WriteLine($"Addition operator (10 + 5) \t   : \t{10 + 5}");
Console.WriteLine($"Subtraction operator (10 - 5) \t   : \t{10 - 5}");
Console.WriteLine($"Multiplication operator (10 * 5)   : \t{10 * 5}");
Console.WriteLine($"Division operator (10 / 5) \t   : \t{10 / 5}");
Console.WriteLine($"Modulo operator (10 % 5) \t   : \t{10 % 5}");
int x = 5, y = 10;
Console.WriteLine($"Increment operator (x++) \t   :  \t{x++}");
Console.WriteLine($"Decrement operator (y--) \t   : \t{y--}");

// Assignment Operators
Console.WriteLine("\n=================================================================");
Console.WriteLine("\t\t\tAssignment Operators");
Console.WriteLine("=================================================================");
int z = 20;
Console.WriteLine($"Add assignment (z += 10)\t   :  \t{z += 10}");
Console.WriteLine($"Multiply assignment (z *= 5)\t   :  \t{z *= 4}");
Console.WriteLine($"Module assignment (z %= 7)\t   :  \t{z %= 7}");
Console.WriteLine($"Bitwise And assignment (z &= 10)   :  \t{z &= 10}");
Console.WriteLine($"Bitwise OR assignment (z ^= 12)    :  \t{z ^= 12}");
Console.WriteLine($"RightShift assignment (z >> 3)\t   :  \t{z >> 3}");

// Compzrison Operators
Console.WriteLine("\n=================================================================");
Console.WriteLine("\t\t\tComparison Operators");
Console.WriteLine("=================================================================");
int a = 10, b = 20;
Console.WriteLine($"Equal to operator (a == b)\t\t\t: \t{a == b}");
Console.WriteLine($"Not equal to operator (a != b)\t\t\t: \t{a != b}");
Console.WriteLine($"Greater than operator (a > b)\t\t\t: \t{a > b}");
Console.WriteLine($"Greater than or equal to operator (a >=b)\t:\t{a >= b}");
Console.WriteLine($"Less than operator (a < b)\t\t\t: \t{a < b}");
Console.WriteLine($"Lesser than or Equal to operator (a <= b)\t:\t{a <= b}");

// Logical Operators
Console.WriteLine("\n=================================================================");
Console.WriteLine("\t\t\tLogical Operators");
Console.WriteLine("=================================================================");
int c = 15, d = 10;
Console.WriteLine($"Logical And operator (&&) : {(c <= d) && (c > 10)}");
Console.WriteLine($"Logical OR operator (||) : {(c >= d) || (c < 10)}");
Console.WriteLine($"Not operator (!) : {!((c > y) || (d < 5))}");

