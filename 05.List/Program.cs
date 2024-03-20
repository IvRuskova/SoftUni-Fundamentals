namespace _05.List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            List<double> number = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            //Act
            for (int i = 0; i < number.Count-1; i++)
            {
                if (number[i] == number[i+1])
                {
                    number[i] += number[i + 1];
                    number.RemoveAt(i + 1);
                    i = -1;
                }
            }

            //Output
            Console.WriteLine(string.Join(" ",number));
        }
    }
}
