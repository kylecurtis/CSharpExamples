namespace CSharpExamples._01_Basics
{
    internal class Variables
    {
        public static void Run()
        {
            // Title
            Console.WriteLine("Variables:");

            // Variable Declaration
            int noNumber;
            
            // Variable Initialization
            int firstNumber = 0;
            Console.WriteLine($"First Number: {firstNumber}");

            // Constant Variables:
            // Constant values must be initialzied when declared using the `const` keyword.
            // Constants are immutable values, and can not be changed by the program.
            const int DaysInWeek = 7;
            Console.WriteLine($"Days in a week: {DaysInWeek}");

            // Variables are case-sensitive.
            // For example, these two variables are completely different.
            int number = 0;
            Console.WriteLine($"number is: {number}");
            
            int Number = 1;
            Console.WriteLine($"Number is: {Number}");

            // Variable Naming Conventions:
            // Camel Case is used for local variable names (firstName, playerScore, etc.).
            // Pascal Case is used for constant variable names (MaxLevel, YearOfBirth, etc.).
            int playerScore = 32;
            Console.WriteLine($"Player Score: {playerScore}");
            
            const int MaxLevel = 99;
            Console.WriteLine($"Max Level: {MaxLevel}");
            
            // Variable Redeclaration:
            // In C#, you can assign a new value to an existing variable, but you cannot
            // re-declare the same variable within the same scope.
            int x = 0;
            Console.WriteLine($"x is currently: {x}");
            
            x = 10;
            Console.WriteLine($"x is now: {x}");
        }
    }
}
