internal class Program
{
    private static void Main(string[] args)
    {
        string[] colors = new string[5];

        string[] animals = {"Cat", "Dog", "Bird", "Monkey"};

        int[] array;
        array = new int[5];

        colors[0] = "Blue";
        array[3] = 10;

        Console.WriteLine(animals[1]);
        Console.WriteLine(array[3]);
        Console.WriteLine(colors[0]);

        Console.Write("Enter the number of elements: ");
        int lengthOfArray = int.Parse(Console.ReadLine());
        int[] numArray = new int[lengthOfArray];

        for(int i=0; i< lengthOfArray; i++) {
            Console.Write("Enter the {0]. number: ", i+1);
            numArray[i] = int.Parse(Console.ReadLine);
        }

        int sum = 0;
        foreach(var num in numArray) {
            sum += num;
        }

        Console.WriteLine("Average: " + sum/lengthOfArray);
    }
}