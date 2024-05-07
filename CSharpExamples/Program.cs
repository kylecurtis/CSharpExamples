using CSharpExamples._01_Basics;

namespace CSharpExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Line()
            {
                Console.WriteLine("===========================================================");
            } 

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Variables");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine();
                        Variables.Run();
                        Console.WriteLine();
                        Line();
                        break;
                    case "0":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice, please try again.");
                        Console.WriteLine();
                        Line();
                        break;
                }
            }
        }
    }
}
