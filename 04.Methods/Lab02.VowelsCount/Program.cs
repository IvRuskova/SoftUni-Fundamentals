
namespace Lab02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string str = Console.ReadLine();
            Console.WriteLine(FindVowels(str));
        }

        static int FindVowels(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'A':
                    case 'a':
                    case 'O':
                    case 'o':
                    case 'U':
                    case 'u':
                    case 'E':
                    case 'e':
                    case 'I':
                    case 'i':
                    case 'Y':
                    case 'y':
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}
