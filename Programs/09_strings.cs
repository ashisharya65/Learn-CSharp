
Console.WriteLine("\nWelcome to learning about Strings in C#.\n");

// Printing the string to the console
string Greeting = "Hello";
Console.WriteLine($"{Greeting} Ashish Arya.");

// Finding String length
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine($"Length of the string : {txt.Length}");

// Changing the string characters to Uppercase & lowercase
string txt2 = "Hello World";
Console.WriteLine($"string in uppercase : {txt2.ToUpper()}");
Console.WriteLine($"string in lowercase : {txt2.ToLower()}");

// string concatenation
string firstname = "Ravi", lastname = "Kumar";
Console.WriteLine($"Concatenated string : {firstname + " " + lastname}");

// string interpolation
string fname = "Ashish", lname = "Arya";
Console.WriteLine($"Interpolated String : {fname} {lname}");
