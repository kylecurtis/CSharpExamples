namespace CSharpExamples._02_Data_Types;

internal class Floats
{
    public static void Run()
    {
       // =============================================================================
       
       // FLOAT
       // - DOTNET TYPE: (System.Single).
       // - SIZE: 32 bits (4 bytes).
       // - PRECISION: ~6-9 digits.
       // - APPROXIMATE RANGE: +-1.5 * 10^-45 to +-3.4 * 10^38.
       
       float pi = 3.14159f; // "f" or "F" suffix is required!
       Console.WriteLine($"Float (pi): {pi}");
       
       // =============================================================================
       
       // DOUBLE
       // - DOTNET TYPE: (System.Double).
       // - SIZE: 64 bits (8 bytes).
       // - PRECISION: ~15-17 digits.
       // - APPROXIMATE RANGE: +-5.0 * 10^-324 to +-1.7 * 10^308.
      
       double distance = 2.718281828459045;
       Console.WriteLine($"Double (distance): {distance}");
       
       // NOTE:
       // - Double is the default type for real numbers in C#.
       // - No suffix is required for the double type.
       // - "d" or "D" suffix can still be used.
    
       // =============================================================================
       
       // DECIMAL
       // - DOTNET TYPE: (System.Decimal).
       // - SIZE: 128 bits / 16 bytes.
       // - PRECISION: 28-29 digits.
       // - APPROXIMATE RANGE: +- 1.0 * 10^-28 to +-7.9228 * 10^28.

       decimal price = 9.99m; // "m" or "M" suffix is required!
       Console.WriteLine($"Price: {price}");
        
       // NOTE:
       // - Decimal is preferred when precision is a high priority.
       // - A financial application is one of the primary use cases for decimal.
       
       // =============================================================================
       
       // FLOAT & DOUBLE DISADVANTAGES:
       // - Because the float and double type are not as accurate as the decimal type,
       // - Certain calculations will return inaccurate results. For example:
       
       double doubleX = 0.1;
       double doubleY = 0.2;
       Console.WriteLine($"0.1 + 0.2 = 0.3 is {doubleX + doubleY == 0.3} for doubles!");
       
       // NOTE:
       // - The code above will return False, even though the calculation is true.
       // - This is precisely why decimal is required for financial applications!

       decimal decimalX = 0.1m;
       decimal decimalY = 0.2m;
       decimal decimalResult = 0.3m;
       Console.WriteLine($"0.1 + 0.2 = 0.3 is {decimalX + decimalY == decimalResult} for decimals!");
    }
}