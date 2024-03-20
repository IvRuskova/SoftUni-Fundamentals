
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Lab10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FindTopNum(n);
        }
        //Its sum of digits is divisible by 8, e.g. 8, 17, 88
        //Holds at least one odd digit, e.g. 232, 707, 87578
        //Some examples of top numbers are: 17, 161, 251, 4310, 123200
        private static void FindTopNum(int n)
        {
            for (int currentNum = 0; currentNum < n; currentNum++)
            {
                int digit = 0;
                int currNum= currentNum;
                int sum = 0;
                bool oddDigit = false;
                while (currNum != 0 )
                {
                    digit = currNum % 10;
                    currNum /= 10;
                    sum += digit;
                    if (digit % 2 != 0)
                    {
                        oddDigit = true;
                    }
                }
                if (sum % 8 == 0 && oddDigit)
                {
                    Console.WriteLine(currentNum);
                }
            }
        }
    }
}
