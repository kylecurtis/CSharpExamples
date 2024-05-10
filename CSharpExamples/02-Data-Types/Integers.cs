using System.Numerics; // Required for BigInteger

namespace CSharpExamples._02_Data_Types
{
    internal class Integers
    {
        public static void Run()
        {
            // Title
            Console.WriteLine("Integers:");
            
            // Integer Literals
            // =============================================================================
            var decimalNumber = 42; // Decimal (no prefix)
            var hexNumber = 0x2A; // Hexadecimal (0x or 0X prefix)
            var binaryNumber = 0b_0010_1010; // Binary (0b or 0B prefix)
            
            Console.WriteLine($"Decimal number: {decimalNumber}");
            Console.WriteLine($"Hexadecimal number: {hexNumber}");
            Console.WriteLine($"Binary number: {binaryNumber}");

            // Signed Integers (Positive and negative numbers)
            // =============================================================================
            // Sbyte (System.SByte): 8-bit signed integer.
            // Range: -128 to 127.
            sbyte sbyteNumber = -128;
            Console.WriteLine($"Signed byte: {sbyteNumber}");
           
            // Short (System.Int16): 16-bit signed integer.
            // Range: -32,768 to 32,767.
            short shortNumber = -32_768;
            Console.WriteLine($"Signed short: {shortNumber}");

            // Int (System.Int32): 32-bit signed integer.
            // Range: -2,147,483,648 to 2,147,483,647.
            int intNumber = -2_147_483_648;
            Console.WriteLine($"Signed int: {intNumber}");

            // Long (System.Int64): 64-bit signed integer.
            // Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            long longNumber = -9_223_372_036_854_775_808;
            Console.WriteLine($"Signed long: {longNumber}");

            // Unsigned Integers (Positive numbers only)
            // =============================================================================
            // Byte (System.Byte): 8-bit unsigned integer.
            // Range: 0 to 255.
            byte byteNumber = 255;
            Console.WriteLine($"Unsigned byte: {byteNumber}");

            // Ushort (System.UInt16): 16-bit unsigned integer.
            // Range: 0 to 65,535.
            ushort ushortNumber = 65_535;
            Console.WriteLine($"Unsigned short: {ushortNumber}");
            
            // Uint (System.UInt32): 32-bit unsigned integer.
            // Range: 0 to 4_294_967_295.
            uint uintNumber = 4_294_967_295;
            Console.WriteLine($"Unsigned int: {uintNumber}");
            
            // Ulong (System.UInt64): 64-bit unsigned integer.
            // Range: 0 to 18_446_744_073_709_551_615.
            ulong ulongNumber = 18_446_744_073_709_551_615;
            Console.WriteLine($"Unsigned long: {ulongNumber}");
            
            // BigInteger
            // =============================================================================
            
            // Constructor: From Integer
            BigInteger bigIntFromInt = new BigInteger(12345678901234567890);
            Console.WriteLine($"Big Integer (from int) : {bigIntFromInt}");
            
            // Constructor: From String
            BigInteger bigIntFromString = BigInteger.Parse("123456789012345678901234567890");
            Console.WriteLine($"Big Integer (from string) : {bigIntFromString}");
            
            // Constructor: From Bytes
            BigInteger bigIntFromBytes = new BigInteger(new byte[] { 0x01, 0x00, 0x00, 0x00, 0x00 });
            Console.WriteLine($"Big Integer (from bytes) : {bigIntFromBytes}");
            
            // Common Methods
            // =============================================================================
            BigInteger bigIntFirst = BigInteger.Parse("481516234248151623424815162342");
            BigInteger bigIntSecond = BigInteger.Parse("12345678901234567890");
            
            // Addition (sum)
            BigInteger bigIntSum = BigInteger.Add(bigIntFirst, bigIntSecond);
            Console.WriteLine($"Big Integer (sum): {bigIntSum}");
            
            // Subtraction (difference)
            BigInteger bigIntDifference = BigInteger.Subtract(bigIntFirst, bigIntSecond);
            Console.WriteLine($"Big Integer (difference): {bigIntDifference}");
            
            // Multiply (product)
            BigInteger bigIntProduct = BigInteger.Multiply(bigIntFirst, bigIntSecond);
            Console.WriteLine($"Big Integer (product): {bigIntProduct}");
            
            // Division (quotient)
            BigInteger bigIntQuotient = BigInteger.Divide(bigIntFirst, bigIntSecond);
            Console.WriteLine($"Big Integer (quotient): {bigIntQuotient}");
            
            // Modulus (Remainder Of Division)
            BigInteger bigIntModulus = BigInteger.Remainder(bigIntFirst, bigIntSecond);
            Console.WriteLine($"Big Integer (modulus): {bigIntModulus}");
            
            // Power (Power Of)
            BigInteger bigIntPower = BigInteger.Pow(bigIntFirst, 2);
            Console.WriteLine($"Big Integer (power of 2): {bigIntPower}");
            
            // Greatest Common Divisor (GCD)
            BigInteger bigIntGcd = BigInteger.GreatestCommonDivisor(bigIntFirst, new BigInteger(123));
            Console.WriteLine($"Big Integer (GCD of 123): {bigIntGcd}");
            
            // Negation
            BigInteger bigIntNegation = BigInteger.Negate(bigIntFirst);
            Console.WriteLine($"Big Integer (Negation): {bigIntNegation}");
            
            // Absolute Value (Abs)
            BigInteger bigIntAbs = BigInteger.Abs(bigIntNegation);
            Console.WriteLine($"Big Integer (Abs): {bigIntAbs}");
            
            // Bitwise Operations
            // =============================================================================
            BigInteger andResult = new BigInteger(100) & new BigInteger(1000);
            Console.WriteLine($"Bitwise And: {andResult}");
            
            BigInteger orResult = new BigInteger(100) | new BigInteger(1000);
            Console.WriteLine($"Bitwise Or: {orResult}"); 
        }
    }
}
