delegate void Notification(string message);

class Program
{
    static void Main() {
        Notification notification = text => Console.WriteLine(text);
        notification("tekle");
    }
}
//class Account
//{

//    Notification notification;
//    public void SetNotificationDelegate(Notification _notification)
//    {
//        notification = _notification;
//    }
//    public int Balance { get; set; }
//    public Account(int Balance)
//    {
//        this.Balance = Balance;
//    }
//    public void FillBalance(int balance)
//    {
//        Balance += balance;
//        if (notification != null)
//            notification("text");


//    }
//    public void Withdraw(int balance)
//    {
//        if (Balance >= balance)
//            Balance -= balance;
//        if (notification != null)
//            notification("text");


//    }
//}
//class Program
//{

//    static void Main()
//    {
//        Account account1 = new Account(1000);
//        account1.SetNotificationDelegate(DisplayInfoInConsole);

//    }
//    static void DisplayInfoInConsole(string text)
//    {
//        Console.WriteLine("Hello");
//    }
//}
