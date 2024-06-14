namespace CSharpExamples._02_Data_Types;

internal class Booleans
{
    public static void Run()
    {
        // BOOLEAN (BOOL)
        // .NET TYPE: (System.Boolean)
        // The default value for the boolean type is false.

        // BOOLEAN LITERALS
        bool isOnline = true;
        bool isPython = false;

        // WORKING WITH BOOLEANS
        Console.WriteLine(isOnline ? "Status: Online" : "Status: Offline");
        Console.WriteLine(isPython ? "This is python!" : "This is not python!");
    }
}