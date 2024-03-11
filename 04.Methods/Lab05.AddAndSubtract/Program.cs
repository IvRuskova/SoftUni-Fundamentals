

namespace Lab05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstDigit = int.Parse(Console.ReadLine());
            int secondDigit = int.Parse(Console.ReadLine());
            int thirdDigit = int.Parse(Console.ReadLine());

            AddDigits(firstDigit, secondDigit);
            Console.WriteLine(AddAndSubtract(firstDigit, secondDigit, thirdDigit)); 
        }

        private static int AddAndSubtract(int firstDigit, int secondDigit, int thirdDigit)
        {
            int addAndSubtract = (firstDigit + secondDigit) - thirdDigit;
            return addAndSubtract;
        }

        private static int AddDigits(int firstDigit, int secondDigit)
        {
            int sum = firstDigit + secondDigit;
            return sum;
        }
    }
}
