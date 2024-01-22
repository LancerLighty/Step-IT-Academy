using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Thread thread1 = new(Hello);
        Thread thread2 = new(Name);
        Thread thread3 = new(Id);
        thread1.Start();
        thread2.Start();
        thread3.Start();

        Thread thread = Thread.CurrentThread;
        thread.Name = "threadName";
        Console.WriteLine(thread.Name);
        Console.WriteLine(thread.IsAlive);
        thread.Priority = ThreadPriority.BelowNormal;
        Console.WriteLine(thread.Priority);

        Task task1 = new(() => Console.WriteLine("text1"));
        task1.Start();
        Task task2 = Task.Factory.StartNew(() => Console.WriteLine("text2"));
        Task task3 = Task.Run(() => Console.WriteLine("text3"));
        task1.Wait();
        task2.Wait();
        task3.Wait();
        MakeArray();
        MakeArray2();
    }
    public static void Hello()
    {
        Console.WriteLine("hello!");
    }
    public static void Name()
    {
        Console.WriteLine("My name is tekle");
    }
    public static void Id()
    {
        Console.WriteLine("IS803214DHS");
    }
    public static void MakeArray()
    {
        int[] arr = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    public static void MakeArray2()
    {
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i < number; i++)
        {
            Console.WriteLine(i * i);
        }
    }
}