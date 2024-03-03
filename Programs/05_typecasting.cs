

Console.WriteLine("\nWelcome to learning about typecasting in C#.\n");

/*
    There are two types of casting:
    
    1. Implicit casting (automatically) : converting a smaller type to a larger type size
        char ==> int ==> long ==> float ==> double
    
    2. Explicit casting (manually) : converting a larger type to a smaller type
        double ==> float ==> long ==> int ==> char

*/

// Implicit casting
int myintNum = 9;
Console.WriteLine($"Before Implicit casting\t:   {myintNum}");
double mydoubleNum = myintNum;
Console.WriteLine($"After Implicit casting\t:   {mydoubleNum}\n");

// Explicit casting
double mydoubleNum2 = 9.78;
Console.WriteLine($"Before Explicit casting\t:   {mydoubleNum2}");
int myintNum2 = (int)mydoubleNum2;
Console.WriteLine($"After Explicit casting\t:     {myintNum2}\n");

// Type conversion
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;
Console.WriteLine($"Type conversion of Int to String\t:     {Convert.ToString(myInt)}");
Console.WriteLine($"Type conversion of Double to Int\t:     {Convert.ToDouble(myInt)}");
Console.WriteLine($"Type conversion of Int to Double\t:      {Convert.ToInt32(myDouble)}");
Console.WriteLine($"Type conversion of Bool to String\t:    {Convert.ToString(myBool)}\n");
