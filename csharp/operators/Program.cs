using System;
  
namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment Operators

            int x = 3;
            int y = 3;

            y = y + 2;
            Console.WriteLine(y);

            y += 2;
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);

            x *= 2;
            Console.WriteLine(x);

            // Logical Operators
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }
            else if (isSuccess || isCompleted)
            {
                Console.WriteLine("Great!");
            }
            else if (isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }

            // Comparison Operators
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool result = a < b;
            Console.WriteLine(result);

            result = a > b;
            Console.WriteLine(result);

            result = a >= b;
            Console.WriteLine(result);

            result = a <= b;
            Console.WriteLine(result);

            result = a == b;
            Console.WriteLine(result);

            result = a != b;
            Console.WriteLine(result);

            // Arithmetic Operators
            // /, *, +, -

            int num1 = 10;
            int num2 = 5;

            int result1 = num1 / num2;
            Console.WriteLine(result1);

            int result2 = num1 * num2;
            Console.WriteLine(result2);

            int result3 = num1 + num2;
            Console.WriteLine(result3);

            int result4 = num1++;
            Console.WriteLine(result4);

            // % -> Modulo
            int result5 = 20 % 3;
            Console.WriteLine(result5);
        }
    }
}