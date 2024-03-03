
namespace AboutMyEnvironment;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("\nWelcome to learning C# programming.");
        Console.WriteLine($"This is a hello world program.{Environment.NewLine}");

        Console.WriteLine(Environment.CurrentDirectory);
        Console.WriteLine(Environment.OSVersion.VersionString);
        Console.WriteLine("Namespace: {0}", typeof(Program).Namespace);

    }
}
