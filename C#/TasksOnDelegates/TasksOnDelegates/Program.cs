using System;
delegate int IntDelegate(int a, int b);
delegate void StringDelegate(string text);
class Program
{
    static void Main()
    {
        IntDelegate addDelegate = Add;
        IntDelegate multiplyDelegate = Multiply;
        int sumResult = addDelegate(5, 3);
        int MultResult = multiplyDelegate(4, 7);
        Console.WriteLine($"Sum: {sumResult}");
        Console.WriteLine($"Multipy: {MultResult}");

        StringDelegate printToConsole = AddInConsole;
        printToConsole += AddInFile;

        StringDelegate printToConsoleWithOperator = text => Console.WriteLine(text);

        printToConsoleWithOperator += text =>
        {
            string filePath = @"C:\Users\Administrator\OneDrive\Desktop\log.txt";
            File.WriteAllText(filePath, text);
        };
        printToConsole("hi");
        printToConsoleWithOperator("hello");

    }
    static void AddInConsole(string a)
    {
        Console.WriteLine(a);
    }
    static void AddInFile(string a)
    {
        string filePath = @"C:\Users\Administrator\OneDrive\Desktop\log1.txt";
        File.WriteAllText(filePath, a);
    }
    // მეთოდი 1
    static int Add(int a, int b)
    {
        return a + b;
    }

    // მეთოდი 2
    static int Multiply(int a, int b)
    {
        return a * b;
    }
}