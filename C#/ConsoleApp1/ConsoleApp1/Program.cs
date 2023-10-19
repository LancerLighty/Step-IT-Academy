using System.Reflection.Metadata.Ecma335;
//class Car {
//    private bool isTankFulll;
//    private void FillTank()
//    {
//        Console.WriteLine("filling");
//        isTankFulll = true;
//        Console.WriteLine("filled");
//    }
//    public void Drive()
//    {
//        if (!isTankFulll)
//        {
//            Console.WriteLine("the tank is empty.");
//            FillTank();
//        }
//        Console.WriteLine("Driving....");
//        isTankFulll = false;
//    }
//}
class WatterTank { 
    private bool isWatterTankFull;
    private void FillWatterTank()
    {
        Console.WriteLine("Filling with watter...");
        isWatterTankFull = true;
        Console.WriteLine("WatterTank is full!!");
    }
    public void UseWatter()
    {
        if (!isWatterTankFull)
            Console.WriteLine("Tank is Empty.");
        FillWatterTank();
        Console.WriteLine("Using Watter..");
        isWatterTankFull = false;
    }
}


class Program
{
    static void Main()
    {
        Car mercedes = new Car();
        mercedes.
        //int[] arr = { 1, 245, 57, 24, 4, 71, 2134, 512, 5, 7, 23, };
        //PrintArray(arr);
        //string mon = "monday";
        //printString(mon);

        //printNameAndAge("tekle", 15);
    }
    static void printNameAndAge(string a, int b)
    {
        Console.WriteLine($"name is: {a}");
        Console.WriteLine($"age is: {b}");
    }
    static void printString(string a)
    {
        //Console.WriteLine($"today is: {a}");
        switch (a) {
            case "Monday":
                Console.WriteLine("Today is Monday");
                break;
            case "Tuesday":
                Console.WriteLine("Today is Tuesday");
                break;
            case "Wednesday":
                Console.WriteLine("Today is Wednesday");
                break;
        }
    }
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

    }
    static int Calculator(int a, int b, string c)
    {
        if(c == "+")
        {
            return a + b;
        }
        else if (c == "-")
        {
            return a - b;
        }
        else if (c == "*")
        {
            return a * b;
        }
        else if (c == "/")
        {
            return a / b;
        }
        return 0;

    }
}