// See https://aka.ms/new-console-template for more information
using System.Security.Permissions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Exploring C# Integral Types and Math Operations");

        // Step 1: Exploration of Integral Types
        int myInt = 2147483647;// Int32: Ranges from -2,147,483,648 to 2,147,483,647
        long myLong = 9223372036854775807;// Int64: Ranges from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        byte myByte = 255;// Byte: Ranges from 0 to 255
        short myShort = 32767;// Short: Ranges from -32,768 to 32,767

        //Display the integral type information in a table
        Console.WriteLine("Integral Types Table");
        Console.WriteLine("| Data Type | Byte Size | Min Value | Max Value |");
        Console.WriteLine("|-----------|-----------|-----------|-----------|");
        Console.WriteLine($"| int       | {sizeof(int),-9} | {int.MinValue,-9} | {int.MaxValue,-9} |");
        Console.WriteLine($"| long      | {sizeof(long),-9} | {long.MinValue,-9} | {long.MaxValue,-9} |");
        Console.WriteLine($"| byte      | {sizeof(byte),-9} | {byte.MinValue,-9} | {byte.MaxValue,-9} |");
        Console.WriteLine($"| short     | {sizeof(short),-9} | {short.MinValue,-9} | {short.MaxValue,-9} |");
        Console.WriteLine();

        int sum = myInt + 100;// Addition
        int difference = myInt - 50;// Subtraction
        int product = myShort * 2;// Multiplication
        int quotient = myInt / 2;// Division
        int remainder = myByte % 10;// Modulus

        Console.Write("Equation (Code Representation) + Result: ");
        int result1 = 5 + 3; Console.Write("5 + 3 = " + result1 + ", ");
        int result2 = 10 - 4; Console.Write("10 - 4 = " + result2 + ", ");
        int result3 = 7 * 2; Console.Write("7 * 2 = " + result3 + ", ");
        int result4 = 20 / 4; Console.Write("20 / 4 = " + result4 + ", ");
        int result5 = 9 % 2; Console.Write("9 % 2 = " + result5 + ", ");
        int result6 = 15 + 6; Console.Write("15 + 6 = " + result6 + ", ");
        int result7 = 12 - 7; Console.Write("12 - 7 = " + result7 + ", ");
        int result8 = 4 * 3; Console.Write("4 * 3 = " + result8 + ", ");
        int result9 = 30 / 5; Console.Write("30 / 5 = " + result9 + ", ");
        int result10 = 16 % 3; Console.Write("16 % 3 = " + result10 + ", ");
        int result11 = 8 + 10; Console.Write("8 + 10 = " + result11 + ", ");
        int result12 = 20 - 8; Console.Write("20 - 8 = " + result12 + ", ");
        int result13 = 6 * 7; Console.Write("6 * 7 = " + result13 + ", ");
        int result14 = 45 / 9; Console.Write("45 / 9 = " + result14 + ", ");
        int result15 = 25 % 4; Console.Write("25 % 4 = " + result15 + ", ");
        // Assuming the declaration of 'number' and 'shortNumber' variables
        int number = 20;// Example value
        short shortNumber = 30;// Example value
        int complexOperation1 = number / 2 + 3 * shortNumber;
        // Explanation: First, 'number' is divided by 2, then 3 is multiplied by 'shortNumber', and finally, the results of both operations are added together.
        static void CalculateComplexOperation(int shortNumber)
        {
            int complexOperation2 = 5 * (shortNumber - 1000) / 2;
            Console.WriteLine("Result of complex operation 2: " + complexOperation2);
        }
        // Explanation: First, 'shortNumber' is subtracted by 1000, then 5 is multiplied by the result, and finally, the result is divided by 2.

        int a = 7;
        int b = 4;
        int c = 3;

        int complexOperation = (a + b) / c;
        //Breakdown:
        //1. Parentheses first: (a + b) = 11
        //2. Division second: 11 / c = 3
        //3. Result: 3

        int result = 7 + 4 / 3;
        Console.WriteLine("Equation (Code Representation) + Result: ");
        int result16 = (4 + 5) * 2; Console.Write("(4 + 5) * 2 = " + result16 + ", ");
        int result17 = (10 - 6) + 3 * 2; Console.Write("(10 - 6) + 3 * 2 = " + result17 + ", ");
        int result18 = 5 * (7 - 4) / 2; Console.Write("5 * (7 - 4) / 2 = " + result18 + ", ");
        int result19 = (10 + 4) / 2 * 3; Console.Write("(10 + 4) / 2 * 3 = " + result19 + ", ");
        int result20 = (4 + 5) * 2; Console.Write("(4 + 5) * 2 = " + result20 + ", ");
        
        Console.WriteLine("Equation 16 Result: " + result16);
        Console.WriteLine("Equation 17 Result: " + result17);
        Console.WriteLine("Equation 18 Result: " + result18);
        Console.WriteLine("Equation 19 Result: " + result19);
                Console.WriteLine("Equation 20 Result: " + result20);
            }
        }
        
