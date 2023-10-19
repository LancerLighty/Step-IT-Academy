class Program
{
    static void Main()
    {
        //შექმენით 3 სტრინგ ტიპის ცვლადი და დაპრინტეთ კონსოლში.
        string str1 = "hello ";
        string str2 = "world! ";
        string str3 = ":))";
        Console.WriteLine(str1);
        Console.WriteLine(str2);
        Console.WriteLine(str3);

        //შექმენით 3 ინტ ტიპის ცვლადი და დაპრინტეთ კონსოლში.
        int num1 = 51;
        int num2 = 37;
        Console.WriteLine(num1);
        Console.WriteLine(num2);

        //ექმენით 2 სტრინგი და ციფრი გადაეცით მნიშვნელობაში, ამის შემდეგ კი მოახდინეთ კონვერტაცია ინტში.
        string strToNum = "5";
        string strToNum1 = "9";
        int strToNum2 = Convert.ToInt32(strToNum);
        int strToNum3 = Convert.ToInt32(strToNum1);

        //ააწყევეთ კალკულატორი.
        Console.WriteLine("Enter First Number:");
        int firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second Number:");
        int secondNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Operation:");
        string operation = Console.ReadLine();
        if (operation == "+")
        {
            Console.WriteLine(firstNum + secondNum);
        } 
        else if (operation == "-")
        {
            Console.WriteLine(firstNum - secondNum);
        } 
        else if (operation == "/")
        {
            Console.WriteLine(firstNum / secondNum);
        }
        else if (operation == "*")
        {
            Console.WriteLine(firstNum * secondNum);
        }
        else if (operation == "%")
        {
            Console.WriteLine(firstNum % secondNum);
        }
        else
        {
            Console.WriteLine("please enter one of following operations:");
            Console.WriteLine("+,-,/,* or %");
        }
    }
}
