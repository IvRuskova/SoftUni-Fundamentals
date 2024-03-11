
namespace Lab06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string str = Console.ReadLine();
           FindMiddle(str);
        }

        private static void FindMiddle(string str)
        {
            for (int i = 1; i <= str.Length/2; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
