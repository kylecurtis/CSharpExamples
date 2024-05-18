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
                Console.WriteLine("------------------------------------------------");
            }

            static void Continue()
            {
                Console.WriteLine();
                Console.Write("Press Enter to continue...");
                Console.ReadLine();
            }

            static void MethodCall(Action topicMethod)
            {
                Line();
                topicMethod();
                Line();
                Continue();
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                """
                ------------------------------------------------
                | C# Basics         | Command 
                ------------------------------------------------
                | Hello, World!     | hello
                | Variables         | var
                
                ------------------------------------------------
                | Data Types        | Command 
                ------------------------------------------------
                | Booleans          | bool
                | Integers          | int
                | Floats            | float
                | Strings           | string
              
                ------------------------------------------------
                | Help              | Command 
                ------------------------------------------------
                | exit              | q
                  
                """);
                Console.Write("> ");

                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "hello":
                        Console.Clear();
                        Console.WriteLine("Hello, World!");
                        MethodCall(HelloWorld.Run);
                        break;
                    case "var":
                        Console.Clear();
                        Console.WriteLine("Variables:");
                        MethodCall(Variables.Run);
                        break;
                    case "float":
                        Console.Clear();
                        Console.WriteLine("Floating Point Numbers:");
                        MethodCall(Floats.Run); 
                        break;
                    case "string":
                        Console.Clear();
                        Console.WriteLine("Strings:");
                        MethodCall(Strings.Run);
                        break;
                    case "int":
                        Console.Clear();
                        Console.WriteLine("Integrals:");
                        MethodCall(Integers.Run);
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
