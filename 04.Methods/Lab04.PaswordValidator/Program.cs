

namespace Lab04.PaswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            bool passBetween10And6Characters = CheckPasswordMustBetween10And6Characters(pass);
            bool passOnlyLettersAndDigits = CheckOnlyLettersAndDigits(pass);
            bool passMustHave2digits = CheckPasswordMustHave2Digits(pass);

            if (passBetween10And6Characters && passOnlyLettersAndDigits && passMustHave2digits)
            {
                Console.WriteLine("Password is valid");
            }
            else if (!passMustHave2digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

        }
        static bool CheckPasswordMustBetween10And6Characters(string pass)
        {
          
            if (pass.Length <= 6 || pass.Length >= 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            return true;
        }
        static bool CheckOnlyLettersAndDigits(string pass)
        {
            if (!pass.All(char.IsLetterOrDigit))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            return true;
        }
        static bool CheckPasswordMustHave2Digits(string pass)
        {
            int count = 0;
            foreach (var item in pass)
            {
                if (char.IsDigit(item))
                {
                    count++;
                }     
            }
            return count >= 2;     
        }
    }
}
