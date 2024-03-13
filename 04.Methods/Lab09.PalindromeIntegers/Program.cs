
namespace Lab09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string n=string.Empty;
            CheckPalindrome(n);
        }

        private static void CheckPalindrome(string n)
        {
            while (Console.ReadLine() != "END")
            {
                string srt =new (n.Reverse().ToArray());
                if (n == srt)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
