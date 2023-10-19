class Program
{
    static void Main()
    {
        //bool acces = false;
        //string reservedUsername = "tekle";
        //string reservedPassword = "tekle123";
        //string username = Console.ReadLine();
        //string password = Console.ReadLine();
        //acces = password == reservedPassword && username == reservedUsername ? true : false;
        //string subject = Console.ReadLine();
        //switch (subject) {
        //    case "math":
        //        Console.WriteLine("you subject is Math");
        //        break;
        //    case "georgian":
        //        Console.WriteLine("you subject is Georgian");
        //        break;
        //    case "english":
        //        Console.WriteLine("you subject is English");
        //        break;
        //    case "science":
        //        Console.WriteLine("you subject is Science");
        //        break;
        //    default: 
        //        Console.WriteLine("shemoiyvane sxva sagani");
        //        break;
        //}
        int num1 = Console.ReadLine();
        int num2 = Console.ReadLine();
        if (num1 > num2)
        {
            Console.WriteLine(num1 -  num2);
        }
        else if (num1 < num2)
        {
            Console.WriteLine(num2 - num1);
        } else if (num2 != num1) { 
            Console.WriteLine("ar aris toli");
        }
        else if (num2 == num1)
        {
            Console.WriteLine("tolia");
        }
    }
}