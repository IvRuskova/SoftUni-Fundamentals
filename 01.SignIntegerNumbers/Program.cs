namespace _01.SignIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSing(int.Parse(Console.ReadLine()));
        }
        static void PrintSing(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
