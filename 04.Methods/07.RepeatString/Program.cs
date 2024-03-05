namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatString(str, n);
            Console.WriteLine(result);
        }
        static string RepeatString(string str, int n)
        {
            string result= string.Empty;
            for (int i = 1; i <= n; i++)
            {
                result += str;
            }
            return result;
        }
    }
}
