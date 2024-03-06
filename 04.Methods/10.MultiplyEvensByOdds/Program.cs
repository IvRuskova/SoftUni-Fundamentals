
namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sumEvens = GetSumOfEvensNumbers(num);
            int sumOdds = GetSumOfOddsNumbers(num);
            Console.WriteLine(GetMultiplyOfEvenAndOdds(sumEvens, sumOdds));
        }

        private static int GetSumOfEvensNumbers(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int currNum = number % 10;
                number = number / 10;
                if (currNum % 2  != 0)
                {
                    sum += currNum;
                }
            }
            return sum;
        }

        private static int GetSumOfOddsNumbers(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                int currNum = number % 10;
                number = number / 10;
                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }
            return sum;
        }

        private static int GetMultiplyOfEvenAndOdds(int evenNums, int oddNums)
        {
            return evenNums * oddNums;
        }
    }
}
