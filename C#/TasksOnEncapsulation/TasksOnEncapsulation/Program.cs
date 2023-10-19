using System.Diagnostics;
using TasksOnThingsLearned;

class Program { 
    static void Main(string[] args)
    {
        //1) შექმენით მეთოდი რომელიც დააბრუნებს მასივს, რომელიც ამავდროულად ჩაიციკლება
        //და კონსოლში დაიპრინტება წევრები.
        int[] arr = { 4, 5, 6, 7, 12, 3, 5, 2, 34, };
        PrintArray(arr);

        //2) მეთოდი რომელიც ააწყობს კალკულატორს და შეასრულებს +,_,*,\ ფუნქციებს.
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        string opper = Console.ReadLine();
        Console.WriteLine(Calculator(firstNum, secondNum, opper));

        //3) მეთოდი რომელიც გადაცემული ტექსტით დაპრინტავს კონკრეტულ დღეს გამოიყენეთ Switch case.
        string day = Console.ReadLine();
        printDay(day);
        //4) მეთოდი რომელიც დაპრინტავა სახელს და ასაკს.
        Person person = new Person("tekle", 15);
        person.Info();
        //5) მოიფიქრეთ ენკაფსულაციის ნებისმიერი მაგალითი და დაწერეთ.
        Worker worker = new Worker();
        worker.work();
    }
    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    public static int Calculator(int a, int b, string opper)
    {
        if (opper == "+")
        {
            return a + b;
        }
        else if (opper == "-")
        {
            return a - b;
        }
        else if (opper == "*")
        {
            return a * b;
        }
        else if (opper == "/")
        {
            return a / b;
        }
        return -1;
    }
    public static void printDay(string day)
    {
        switch (day)
        {
            case "monday":
                Console.WriteLine($"Today is {day}.");
                break;
            case "tuesday":
                Console.WriteLine($"Today is {day}.");
                break;
            case "wednesday":
                Console.WriteLine($"Today is {day}.");
                break;
            case "thursday":
                Console.WriteLine($"Today is {day}.");
                break;
            case "friday":
                Console.WriteLine($"Today is {day}.");
                break;
            case "saturday":
                Console.WriteLine($"Today is {day}.");
                break;
            case "sunday":
                Console.WriteLine($"Today is {day}.");
                break;
            default:
                Console.WriteLine("unknown day found.");
                break;

        }
    }
}