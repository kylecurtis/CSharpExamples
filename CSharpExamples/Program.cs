using CSharpExamples._01_Basics;
using CSharpExamples._02_Data_Types;

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

            static void Continue()
            {
                Console.WriteLine();
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    """
                    C# BASICS
                    ---------
                      - Hello, World! (hello)
                      - Variables (var)
                    
                    DATA TYPES
                    ----------
                      - Integers (int)
                      - Floats (float)
                  
                    MENU
                    ----
                      - exit (q)
                      
                    """);
                Console.Write("> ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "hello world" or "hello":
                        Console.Clear();
                        HelloWorld.Run();
                        Line();
                        Continue();
                        break;
                    case "variables" or "var":
                        Console.Clear();
                        Variables.Run();
                        Line();
                        Continue();
                        break;
                    case "floats" or "float":
                        Console.Clear();
                        Floats.Run();
                        Line();
                        Continue();
                        break;
                    case "integers" or "int":
                        Console.Clear();
                        Integers.Run();
                        Line();
                        Continue();
                        break;
                    case "exit" or "quit" or "q":
                        Console.Clear();
                        Console.WriteLine("Exited.");
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
