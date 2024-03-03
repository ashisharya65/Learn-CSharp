
Console.WriteLine("\nWelcome to learning about datatypes in C#.");

int myintNum = 3;
double myDoubleNum = 3.99D;
char mycharLetter = 'A';
bool mybool = true;
string mystring = "Ashish Arya";

/*  
     _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _
    | Data Type |     Size    |                            Description                                             |
    | - - - - - | - - - - - - |- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - |
    |    int	|  4 bytes    |	           Stores whole numbers from -2,147,483,648 to 2,147,483,647               |
    |                         |                                                                                    |
    |   long	|  8 bytes    |	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  |
    |           |             |                                                                                    |  
    |   float	|  4 bytes    |	     Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits       |
    |           |             |                                                                                    | 
    |   double	|  8 bytes    |	        Stores fractional numbers. Sufficient for storing 15 decimal digits        |
    |           |             |                                                                                    |
    |   bool	|  1 bit	  |                        Stores true or false values                                 |
    |           |             |                                                                                    |
    |   char	|  2 bytes    |            Stores a single character/letter, surrounded by single quotes           |
    |           |             |                                                                                    |
    |  string	| 2 bytes per |            Stores a sequence of characters, surrounded by double quotes            |                                                            
    |           |  character  |	                                                                                   |   
    | _ _ _ _ _ | _ _ _ _ _ _ | _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _|

*/

Console.WriteLine($"\nint\t\t:\t{myintNum}");
Console.WriteLine($"double\t\t:\t{myDoubleNum}");
Console.WriteLine($"char\t\t:\t{mycharLetter}");
Console.WriteLine($"bool\t\t:\t{mybool}");
Console.WriteLine($"string\t\t:\t{mystring}\n");
