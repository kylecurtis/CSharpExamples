using System.Text;

namespace CSharpExamples._02_Data_Types;

internal class Strings
{
   public static void Run()
   {
       // The String object is immutable. Every time you use one of the methods in the
       // System.String class, you create a new string object in memory, which requires a
       // new allocation of space for that new object.
       
      // EMPTY STRING
      string emptyString = String.Empty;
      
      // DECLARE & INITIALIZE
      string greeting = "Hello!";
      Console.WriteLine($"{greeting}\n");

      // STRING INTERPOLATION ($)
      string verb = "fight";
      string adjective = "attentive";
      Console.WriteLine($"I have to {verb} quickly to defeat the {adjective} dragon.\n");
      
      // VERBATIM STRING LITERAL (@)
      // - Use when working with file paths or when you need to include backslashes without
      // escaping them.
      string filePath = @"C:\Users\Username\Desktop";
      Console.WriteLine($"File path: {filePath}\n");
      
      // STRING INTERPOLATION WITH STRING LITERAL ($@ or @$)
      string userName = "Jack";
      string customFilePath = $@"C:\Users\{userName}\Documents";
      Console.WriteLine($"Custom file path: {customFilePath}\n");
      
      // RAW STRING LITERAL (TRIPLE QUOTE)
      // Use for complex multi-line strings, especially those containing quotes and new lines,
      // such as JSON or XML, to improve readability and maintainability.
      string rawString = """
                         This is a raw string:
                         {
                           "name": "Sherlock Holmes",
                           "age": 30,
                           "address": "221B Baker Street"
                         }
                         """;
      Console.WriteLine($"{rawString}\n");
      
      // STRING BUILDER:
      // The System.Text.StringBuilder class can be used when you want to modify a string
      // without creating a new object. For example, using the StringBuilder class can
      // boost performance when concatenating many strings together in a loop.

      StringBuilder message = new StringBuilder("This is a string builder!");
      Console.WriteLine($"{message}\n");
      
      // More Info: https://learn.microsoft.com/en-us/dotnet/standard/base-types/stringbuilder
   } 
}