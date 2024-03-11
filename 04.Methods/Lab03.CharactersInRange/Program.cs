
namespace Lab03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol  = char.Parse(Console.ReadLine());

            PrintSymbols(startSymbol, endSymbol);
        }
        static void PrintSymbols(char startSymbol, char endSymbol)
        {
            if ((int)startSymbol < (int)endSymbol)
            {
                for (int i = startSymbol+1; i < endSymbol;i++)
                {
                    Console.Write((char)i+" ");
                }
            }
            else
            {
                for (int i = endSymbol+1; i < startSymbol; i++)
                {
                    Console.Write((char)i+" ");
                }
            }
        }
    }
}
