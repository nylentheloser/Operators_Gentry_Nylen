namespace Operators_Gentry_Nylen
{
    internal class Program
    {
        static void Main()
        {
            // Integer Variables
            int int1 = -3, int2 = 53;
            int intMultiplication = int1 * int2;
            int intAddition = int1 + int2;

            // Finding the Min and Max of two integers
            int intMax = Math.Max(intMultiplication, intAddition);
            int intMin = Math.Min(intMultiplication, intAddition);

            // Output the Min and Max
            Console.WriteLine($"The max of {intMultiplication} and {intAddition} is {intMax}. The min of {intMultiplication} and {intAddition} is {intMin}.");

            // Comparison to find which is greater
            bool isIntGreater = intMultiplication > intAddition;
            Console.WriteLine($"{intMultiplication} is greater than {intAddition}, {isIntGreater}");

            // Short Variables
            short short1 = -10, short2 = 100;
            short shortMultiplication = (short)(short1 * short2);
            short shortAddition = (short)(short1 + short2);

            // Finding the Min and Max of two shorts
            short shortMax = (short)Math.Max(shortMultiplication, shortAddition);
            short shortMin = (short)Math.Min(shortMultiplication, shortAddition);

            // Output the Min and Max
            Console.WriteLine($"The max of {shortMultiplication} and {shortAddition} is {shortMax}. The min of {shortMultiplication} and {shortAddition} is {shortMin}.");

            // Comparison to find which is greater
            bool isShortGreater = shortMultiplication > shortAddition;
            Console.WriteLine($"{shortMultiplication} is greater than {shortAddition}, {isShortGreater}");

            // Long Variables
            long long1 = -1000L, long2 = 2000L;
            long longMultiplication = long1 * long2;
            long longAddition = long1 + long2;

            // Finding the Min and Max of two longs
            long longMax = Math.Max(longMultiplication, longAddition);
            long longMin = Math.Min(longMultiplication, longAddition);

            // Output the Min and Max
            Console.WriteLine($"The max of {longMultiplication} and {longAddition} is {longMax}. The min of {longMultiplication} and {longAddition} is {longMin}.");

            // Comparison to find which is greater
            bool isLongGreater = longMultiplication > longAddition;
            Console.WriteLine($"{longMultiplication} is greater than {longAddition}, {isLongGreater}");

            // Float Variables
            float float1 = -10.5f, float2 = 15.3f;
            float floatMultiplication = float1 * float2;
            float floatAddition = float1 + float2;

            // Finding the Min and Max of two floats
            float floatMax = Math.Max(floatMultiplication, floatAddition);
            float floatMin = Math.Min(floatMultiplication, floatAddition);

            // Output the Min and Max
            Console.WriteLine($"The max of {floatMultiplication} and {floatAddition} is {floatMax}. The min of {floatMultiplication} and {floatAddition} is {floatMin}.");

            // Comparison to find which is greater
            bool isFloatGreater = floatMultiplication > floatAddition;
            Console.WriteLine($"{floatMultiplication} is greater than {floatAddition}, {isFloatGreater}");

            // Double Variables
            double double1 = -100.25, double2 = 50.75;
            double doubleMultiplication = double1 * double2;
            double doubleAddition = double1 + double2;

            // Finding the Min and Max of two doubles
            double doubleMax = Math.Max(doubleMultiplication, doubleAddition);
            double doubleMin = Math.Min(doubleMultiplication, doubleAddition);

            // Output the Min and Max
            Console.WriteLine($"The max of {doubleMultiplication} and {doubleAddition} is {doubleMax}. The min of {doubleMultiplication} and {doubleAddition} is {doubleMin}.");

            // Comparison to find which is greater
            bool isDoubleGreater = doubleMultiplication > doubleAddition;
            Console.WriteLine($"{doubleMultiplication} is greater than {doubleAddition}, {isDoubleGreater}");

            // Decimal Variables
            decimal decimal1 = -1000.45m, decimal2 = 2000.99m;
            decimal decimalMultiplication = decimal1 * decimal2;
            decimal decimalAddition = decimal1 + decimal2;

            // Finding the Min and Max of two decimals
            decimal decimalMax = Math.Max(decimalMultiplication, decimalAddition);
            decimal decimalMin = Math.Min(decimalMultiplication, decimalAddition);

            // Output the Min and Max
            Console.WriteLine($"The max of {decimalMultiplication} and {decimalAddition} is {decimalMax}. The min of {decimalMultiplication} and {decimalAddition} is {decimalMin}.");

            // Comparison to find which is greater
            bool isDecimalGreater = decimalMultiplication > decimalAddition;
            Console.WriteLine($"{decimalMultiplication} is greater than {decimalAddition}, {isDecimalGreater}");
        }
    }
}
