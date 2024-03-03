
Console.WriteLine("\nWelcome to learning about switch statement in C#.\n");

string day = DateTime.Now.ToString("dddd");
switch (day)
{
    case "Monday" or "Tuesday" or "Wednesday" or "Thursday" or "Friday":
        Console.WriteLine($"Today is {day} and it is a weekday.");
        break;

    case "Saturday" or "Sunday":
        Console.WriteLine($"Today is {day} and it is a weekend day.");
        break;

    default:
        Console.WriteLine("Looking forward to the Weekend.");
        break;
}
