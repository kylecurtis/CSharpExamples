using System.Numerics; // Required for BigInteger

namespace CSharpExamples._02_Data_Types
{
    internal class Integers
    {
        public static void Run()
        {
            // INTEGER LITERALS 
            // =============================================================================

            var decimalNumber = 42; // Decimal (no prefix)
            var hexNumber = 0x2A; // Hexadecimal (0x or 0X prefix)
            var binaryNumber = 0b_0010_1010; // Binary (0b or 0B prefix)

            Console.WriteLine($"Decimal number: {decimalNumber}");
            Console.WriteLine($"Hexadecimal number: {hexNumber}");
            Console.WriteLine($"Binary number: {binaryNumber}");

            // SIGNED INTEGERS (POSITIVE & NEGATIVE NUMBERS)
            // =============================================================================

            // SBYTE
            // - DOTNET TYPE: (System.SByte)
            // - SIZE: 8-bit signed integer
            // - RANGE: -128 to 127

            sbyte sbyteNumber = -128;
            Console.WriteLine($"Signed byte: {sbyteNumber}");

            // SHORT
            // - DOTNET TYPE: (System.Int16)
            // - SIZE: 16 bits (2 bytes)
            // - RANGE: -32,768 to 32,767

            short shortNumber = -32_768;
            Console.WriteLine($"Signed short: {shortNumber}");

            // INT
            // - DOTNET TYPE: (System.Int32)
            // - SIZE: 32 bits (4 bytes)
            // - RANGE: -2,147,483,648 to 2,147,483,647

            int intNumber = -2_147_483_648;
            Console.WriteLine($"Signed int: {intNumber}");

            // LONG
            // - DOTNET TYPE: (System.Int64)
            // - SIZE: 64 bits (8 bytes)
            // - RANGE: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            long longNumber = -9_223_372_036_854_775_808;
            Console.WriteLine($"Signed long: {longNumber}");

            // UNSIGNED INTEGERS (POSITIVE NUMBERS ONLY)
            // =============================================================================

            // BYTE
            // - DOTNET TYPE: (System.Byte)
            // - SIZE: 8 bits (1 byte)
            // - RANGE: 0 to 255

            byte byteNumber = 255;
            Console.WriteLine($"Unsigned byte: {byteNumber}");

            // USHORT
            // - DOTNET TYPE: (System.UInt16)
            // - SIZE: 16 bits (2 bytes)
            // - RANGE: 0 to 65,535

            ushort ushortNumber = 65_535;
            Console.WriteLine($"Unsigned short: {ushortNumber}");

            // UINT
            // - DOTNET TYPE: (System.UInt32)
            // - SIZE: 32 bits (4 bytes) 
            // - RANGE: 0 to 4_294_967_295

            uint uintNumber = 4_294_967_295;
            Console.WriteLine($"Unsigned int: {uintNumber}");

            // ULONG
            // - DOTNET TYPE: (System.UInt64)
            // - SIZE: 64 bits (8 bytes)
            // - RANGE: 0 to 18_446_744_073_709_551_615

            ulong ulongNumber = 18_446_744_073_709_551_615;
            Console.WriteLine($"Unsigned long: {ulongNumber}");

            // BIGINTEGER
            // =============================================================================

            // CONSTRUCTOR: FROM INTEGER
            BigInteger bigIntFromInt = new BigInteger(12345678901234567890);
            Console.WriteLine($"Big Integer (from int) : {bigIntFromInt}");

            // CONSTRUCTOR: FROM STRING
            BigInteger bigIntFromString = BigInteger.Parse("123456789012345678901234567890");
            Console.WriteLine($"Big Integer (from string) : {bigIntFromString}");

            // CONSTRUCTOR: FROM BYTES
            BigInteger bigIntFromBytes = new BigInteger(new byte[] { 0x01, 0x00, 0x00, 0x00, 0x00 });
            Console.WriteLine($"Big Integer (from bytes) : {bigIntFromBytes}");

            // COMMON BIGINTEGER METHODS
            // =============================================================================

            BigInteger bigIntFirst = BigInteger.Parse("481516234248151623424815162342");
            BigInteger bigIntSecond = BigInteger.Parse("12345678901234567890");

            // ADDITION (SUM)
            BigInteger bigIntSum = BigInteger.Add(bigIntFirst, bigIntSecond);
            Console.WriteLine($"Big Integer (sum): {bigIntSum}");

            // SUBTRACTION (DIFFERENCE)
            BigInteger bigIntDifference = BigInteger.Subtract(bigIntFirst, bigIntSecond);
            Console.WriteLine($"Big Integer (difference): {bigIntDifference}");

            // MULTIPLY (PRODUCT)
            BigInteger bigIntProduct = BigInteger.Multiply(bigIntFirst, bigIntSecond);
            Console.WriteLine($"Big Integer (product): {bigIntProduct}");

            // DIVISION (QUOTIENT)
            BigInteger bigIntQuotient = BigInteger.Divide(bigIntFirst, bigIntSecond);
            Console.WriteLine($"Big Integer (quotient): {bigIntQuotient}");

            // MODULUS (REMAINDER AFTER DIVISION)
            BigInteger bigIntModulus = BigInteger.Remainder(bigIntFirst, bigIntSecond);
            Console.WriteLine($"Big Integer (modulus): {bigIntModulus}");

            // POWER (POWER OF)
            BigInteger bigIntPower = BigInteger.Pow(bigIntFirst, 2);
            Console.WriteLine($"Big Integer (power of 2): {bigIntPower}");

            // GREATEST COMMON DIVISOR (GCD)
            BigInteger bigIntGcd = BigInteger.GreatestCommonDivisor(bigIntFirst, new BigInteger(123));
            Console.WriteLine($"Big Integer (GCD of 123): {bigIntGcd}");

            // NEGATION
            BigInteger bigIntNegation = BigInteger.Negate(bigIntFirst);
            Console.WriteLine($"Big Integer (Negation): {bigIntNegation}");

            // ABSOLUTE VALUE (ABS)
            BigInteger bigIntAbs = BigInteger.Abs(bigIntNegation);
            Console.WriteLine($"Big Integer (Abs): {bigIntAbs}");

            // BITWISE OPERATIONS
            // =============================================================================

            BigInteger andResult = new BigInteger(100) & new BigInteger(1000);
            Console.WriteLine($"Bitwise And: {andResult}");

            BigInteger orResult = new BigInteger(100) | new BigInteger(1000);
            Console.WriteLine($"Bitwise Or: {orResult}");
        }
    }
}
