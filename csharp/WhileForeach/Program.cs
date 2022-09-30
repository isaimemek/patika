internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int counter = 1;
        int total = 0;
        while(counter <= num)
        {
            total += counter;
            counter ++;
        }
        Console.WriteLine(total/num);

        char character = 'a';
        while (character < 'z')
        {
            Console.Write(character);
            character ++;
        }

        Console.Write("***** Foreach *****");
        string[] cars = {"BMW", "Ford", "Toyota", "Nissan"};

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}