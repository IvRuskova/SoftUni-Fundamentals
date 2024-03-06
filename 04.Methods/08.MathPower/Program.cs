namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int power=int.Parse(Console.ReadLine());
            //Math.Pow(num, power);
         double result1 = MathPower(num, power);
            Console.WriteLine(result1);
        }
        static double MathPower(int num, int power)
        {   
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
