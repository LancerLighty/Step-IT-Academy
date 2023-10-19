class Program
{
    static void Main()
    {
        int[] array = { 2, 3, 4, 5, 6, 71, 325 };
        Print(array);
    }
    public static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

}