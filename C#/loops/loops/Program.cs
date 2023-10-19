class Program
{
    static void Main()
    {
        int num = 1;
        while (num <= 10)
        {
            Console.WriteLine(num);
            num++;
        }
        num = 1;
        do
        {
            Console.WriteLine(num2);
            num++;
        } while (num < 10);
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i = 0; i < 20; i++)
        {
            string word = Console.ReadLine();
            Console.WriteLine(i);
            if (word == "exit")
                break;

        }
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(i);
            if (i == 10)
                continue;
        }
    }
}