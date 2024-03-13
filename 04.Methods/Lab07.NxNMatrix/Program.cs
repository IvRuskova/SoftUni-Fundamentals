namespace Lab07.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix(n);
        }
        static void Matrix(int n) 
        {
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write(n+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
