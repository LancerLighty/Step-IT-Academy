// See https://aka.ms/new-console-template for more information
namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hellouu");
            // dontnet run
            Console.WriteLine("How old are you?");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old!");
            double num = 15.45;
            Console.WriteLine(num);
            double dou = (int)num;
            Console.WriteLine(dou);
            Console.Write("Enter your favorite number!: ");
            int faveNumber = Convert.ToInt32(Console.ReadLine()); // we need Int32 because it converts data to 32 bit integer
            Console.Write(faveNumber);

            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable 
            double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));

            // Use built-in methods and save to variable 
            double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

            // Print the lowest number
            Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));
        }
    }
}
