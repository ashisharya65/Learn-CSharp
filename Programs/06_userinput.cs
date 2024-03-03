
Console.WriteLine("\nWelcome to learning about userinput in C#.\n");

Console.Write("Enter the username: ");
var name = Console.ReadLine();

// Console.ReadLine() method always returns a string. So you need to convert string to any other type explicitly.
Console.Write("Enter your age: ");
var age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"\nMy name is {name} and I am {age} years old.\n");
