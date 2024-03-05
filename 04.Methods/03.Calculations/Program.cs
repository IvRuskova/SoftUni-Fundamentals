using System.Data;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Add(command, a, b);
            Multiply(command, a, b);   
            Subtract(command, a, b);
            Divide(command, a, b);

        //add
        }
        static void Add(string command,int a, int b)
        {
            if (command == "add")
            {
                Console.WriteLine(a+b);
            }
        }

        //multiply
        static void Multiply(string command, int a, int b)
        {
            if (command == "multiply")
            {
                Console.WriteLine(a * b);
            }
        }

        //subtract
        static void Subtract(string command, int a, int b)
        {
            if (command == "subtract")
            {
                Console.WriteLine(a - b);
            }
        }

        //divide
        static void Divide(string command, int a, int b)
        {
            if (command == "divide")
            {
                Console.WriteLine(a / b);
            }
        }

    }
}
