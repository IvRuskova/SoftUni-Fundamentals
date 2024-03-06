
namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            string _operator = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(MathOperations(firstNum, _operator, secondNum));
        }

        private static int MathOperations(int firstNum, string _operator, int secondNum)
        {
            int result = 0;
            switch (_operator)
            {
                case "/":
                    result = firstNum/secondNum;
                    break;
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum; 
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
            }
            return result;
        }
    }
}
