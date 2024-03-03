
Console.WriteLine("\nWelcome to learning about For loop in C#.\n");

// For loop
string[] names = new string[5] {
    "Aishwarya Dheer",
    "Shivanshi Jain",
    "Deepak Yadav",
    "Kapil Mishra",
    "Poonam Rawat"
};
for (int i = 0; i < 5; i++)
    Console.WriteLine($"Name {i} : {names[i]}");

// Foreach loop
Console.Write("\nDifferent cars: ");
string[] cars = new string[4] { "Ford", "Volvo", "BMW", "Mazda" };
foreach (string car in cars)
    Console.Write($"{car} ");
Console.WriteLine("\n");
