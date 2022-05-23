using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write odd numbers until given number
            Console.WriteLine("Please Enter a Number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; num; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            // Write sums of odd and even numbers between 1 and  1000
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 0)
                {
                    evenSum += i;
                }
                else
                {
                    oddSum += i;
                }
            }
            console.WriteLine("Even Sum: " + evenSum);
            console.WriteLine("Odd Sum: " + oddSum);

            // Break, Continue
            for (int i = 1; i <= 10; i++)
            {
                if(i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 10; i++)
            {
                if(i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}