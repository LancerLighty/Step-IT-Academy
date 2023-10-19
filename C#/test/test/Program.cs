using System.Net.Mail;
using test;

class Program
{
    static void Main()
    {
        Film film = new Film("saxeli", "janri", "qveyana", "saxiobis saxeli", 2543);
        film.Info();
    }
}
//class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }   
//    public int Nationality { get; set; }
//    public void Talk()
//    {
//        Console.WriteLine($"my name is {FirstName} my last name is {LastName} i  am Age old and i am from Nationality");
//    }
//    public Person(int a, string b)
//    {
//        Age = a;
//        LastName = b;
//    }
//}
//class Account
//{
//    public int Age
//    {
//        get { return Age; }
//        set
//        {
//            if(value>=18 && value < 60)
//            {
//                Age = value;
//            }
//        }
//    }
//}