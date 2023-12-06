class Program
{
    static void Main()
    {
        try
        {
            int a = 0;
            int b = 5 / a;
            Console.WriteLine($"b = {b}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error");
        }
    }
}