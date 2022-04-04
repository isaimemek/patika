using System;
   
namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Enter a Number!");
                int number = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("The Number you Entered: " + number);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: " + ex.Message.ToString());
            }
            finally
            {
                System.Console.WriteLine("Operation Completed.");
            }

            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You Entered an Empty Value.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Data Type is not Suitable.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("You Entered a Value that is too Small or too Large.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Operation completed successfully.");
            }
        }
    }
}