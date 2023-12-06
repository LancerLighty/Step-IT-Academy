class Program
{
    static void Main()
    {
        string string1 = "tekle";
        string string2 = "tek";
        bool result = string1.Equals(string2);
        Console.WriteLine(result);

        int var1 = 42;
        Console.WriteLine(var1.GetType() + " " + var1.GetHashCode() + " " + var1.ToString());
        int var2 = 2023;
        Console.WriteLine(var2.GetType() + " " + var2.GetHashCode() + " " + var2.ToString());
        double var3 = 3.14;
        Console.WriteLine(var3.GetType() + " " + var3.GetHashCode() + " " + var3.ToString());
        string var4 = "Hello, World!";
        Console.WriteLine(var4.GetType() + " " + var4.GetHashCode() + " " + var4.ToString());
        bool var5 = true;
        Console.WriteLine(var5.GetType() + " " + var5.GetHashCode() + " " + var5.ToString());
        MakeRevercedArr();
    }
    public static void MakeArr()
    {
        Console.WriteLine("Enter Array Length!");
        int[] arr = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("Enter nubers in array");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        foreach (int i in arr)
        {
            Console.WriteLine(i);
        }
    }
    public static void MakeRevercedArr()
    {
        Console.WriteLine("Enter Array Length!");
        int[] arr = new int[int.Parse(Console.ReadLine())];
        Console.WriteLine("Enter nubers in array");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }
}