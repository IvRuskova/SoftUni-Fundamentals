

namespace _02.Grades
{
    internal class Program
    {
        static void Main()
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }
        static void PrintGrade(double grade)
        {
            if (grade >= 5.50 && grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade <= 5.49 && grade >= 4.50)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 3.49 && grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade <= 3.49 && grade >= 3.00)
            {
                Console.WriteLine("Poor");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
