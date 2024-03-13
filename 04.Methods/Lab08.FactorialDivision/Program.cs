namespace Lab08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            FactorialDivide(firstNum, secondNum);
        }
        static void FactorialDivide(int firstNum, int secondNum)
        {
            int result = 1;
            for (int i = 0; i < (firstNum-secondNum); i++)
            {
                result *= (firstNum - i); 
            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
