namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            CalculateRectangleArea(weight, height);
        }
        static void CalculateRectangleArea(double weight, double height)
        {
            Console.WriteLine(weight * height); 
        }
    }
}
