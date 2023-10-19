class Program
{
    static void Main() {
        //1) switch ის დახმარებით ააწყეთ კალკულატორი.
        int firstNum = int.Parse(Console.ReadLine());
        int secondNum = int.Parse(Console.ReadLine());
        string action = Console.ReadLine();
        switch (action)
        {
            case "+":
                Console.WriteLine(firstNum + secondNum);
                break;
            case "-":
                Console.WriteLine(firstNum - secondNum);
                break;
            case "*":
                Console.WriteLine(firstNum * secondNum);
                break;
            case "/":
                Console.WriteLine(firstNum / secondNum);
                break;
            case "%":
                Console.WriteLine(firstNum % secondNum);
                break;
            default:
                Console.WriteLine("please enter +, _, *, / or %");
                break;
        }
        //2) ააწყეთ if else კონსტრუქცია, გაუწერეთ 3 პირობა და გამოიყენეთ ნებისმიერი ოპერატორები. 
        int birthYear = int.Parse(Console.ReadLine()); 
        if ((2023 - birthYear) < 0)  
        { 
            Console.WriteLine("your age can't be negative!"); 
        } 
        else if ((2023 - birthYear) < 18) 
        { 
            Console.WriteLine("you are a child!"); 
        } 
        else 
        { 
            Console.WriteLine("you are an adult!"); 
        } 
    }
}
