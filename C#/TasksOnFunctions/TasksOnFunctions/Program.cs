class Program
{
    static void Main(string[] args)
    {
        //1) ააწყეთ კალკულატორი მეთოდების დახმარებით.
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        string oper = Console.ReadLine();
        if (oper == "+" || oper == "-" || oper == "*" || oper == "/")
        {
            Console.WriteLine(Calculate(a, b, oper));
        }
        //2) ააწყეთ მეთოდი, რომელიც დაპრინტავს გადაცემულ მასივს.
        int[] numbers = { 5, 24, 6, 1, 578, 45, 123, 13, 5, 1 };
        PrintArray(numbers);
        //3) ააწყეთ მეთოდი, რომელიც დაპრინტავს გადაცემულ ტექსტს.
        string text = "teqsti";
        PrintString(text);
        //4) ააწყეთ 4 მეთოდი, ნებისმიერი ფუნქციონალით და დაარქვით ერთნაირი სახელები.
        string name = "tek";
        string surname = "mamporia";
        int age = 15;
        int birthDate = 051207;
        PrintInfo(name);
        PrintInfo(name, surname);
        PrintInfo(name, surname, age);
        PrintInfo(name, surname, age, birthDate);
    }
    public static int Calculate(int a, int b, string oper)
    {
        if(oper == "+")
        {
            return Plus(a, b);
        }
        else if (oper == "-")
        {
            return Minus(a,b);
        }
        else if (oper == "/")
        {
            return Devide(a,b);
        }
        else
        {
            return Mult(a, b);
        }
    }
    public static int Plus(int a, int b)
    {
        return a + b;
    }
    public static int Minus(int a, int b)
    {
        return a - b;
    }
    public static int Devide(int a, int b)
    {
        return a / b;
    }
    public static int Mult(int a, int b)
    {
        return a * b;
    }
    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    public static void PrintString(string text)
    {
        Console.WriteLine(text);
    }
    public static void PrintInfo(string name)
    {
        Console.WriteLine("name:" + name);
    }
    public static void PrintInfo(string name, string surname)
    {
        Console.WriteLine("name:" + name);
        Console.WriteLine("surname:" + surname);
    }
    public static void PrintInfo(string name, string surname, int age)
    {
        Console.WriteLine("name:" + name);
        Console.WriteLine("surname:" + surname);
        Console.WriteLine("age:" + age);
    }
    public static void PrintInfo(string name,string surname, int age, int birthDate)
    {
        Console.WriteLine("name:" + name);
        Console.WriteLine("surname:" + surname);
        Console.WriteLine("age:" + age);
        Console.WriteLine("birth date:" + birthDate);
    }
}