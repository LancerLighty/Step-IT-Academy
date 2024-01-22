class Program { 
    static void Main()
    {

    }
    public static bool LeapYear(int Year)
    {
        return Year % 4 == 0;
    }
    public static void Replace(int a, int b)
    {
        int c = a;
        a = b;
        b = c;
    }
    public static int Square(int a)
    {
        int result = 1;
        for (int i = 1; i < a; i++)
        {
            result *= a;
        }
        return a;
    }
    public static void PrintNumbers(int a)
    {
        for (int i = 1; i < a; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }
    }
    public static void PrintNumbers1(int a)
    {
        for (int i = 1; i < a; i++)
        {
            int result = 1;
            for (int j = 1; j < i; j++)
            {
                result *= j;
            }
            Console.WriteLine(result);
        }
    }
    public static void MakeArr()
    {
        int[] array = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    public static int MakeArrAndSum()
    {
        int[] array = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
        return result;
    }
    public static string Reverse(string word)
    {
        string result = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            result += word[i];
        }
        return result;
    }
    public static int WordCount(string word)
    {
        string[] arr = word.Split(' ');
        return arr.Length;
    }
}
