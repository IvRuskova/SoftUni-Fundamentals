
namespace _09.GreaterTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Console.WriteLine(GetMax(command)); 
        }
        static string GetMax(string command)
        {
            switch (command)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    if (num1>num2)
                    {
                        return num1.ToString();
                    }
                    else
                    {
                        return num2.ToString();
                    }  
                    break;
                case "string":
                    string srt1=Console.ReadLine();
                    string srt2=Console.ReadLine();
                    int result = srt1.CompareTo(srt2);
                    if (result>0)
                    {
                        return srt1;
                    }
                    else
                    {
                        return srt2;
                    }
                    break;
                case "char":
                    char ch1 = char.Parse(Console.ReadLine());
                    char ch2 = char.Parse(Console.ReadLine());
                    if (ch1 > ch2)
                    {
                        return ch1.ToString();
                    }
                    else
                    {
                        return ch2.ToString();
                    }
                    break;
            }
            return command;
        }
    }
}
