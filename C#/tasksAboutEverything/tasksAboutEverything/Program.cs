using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        //for, do while, while - ით მოახდინეთ ციფრების იტერაცია 20 - ის ჩათვლით.
        for (int i = 0; i <= 20; i++)
        {
            Console.WriteLine(i);
        }
        int num = 0;
        do
        {
            Console.WriteLine(num);
            num++;
        } while (num <=20);
        num = 0;
        while (num <= 20)
        {
            Console.WriteLine(num);
            num++;
        }
        //შექმენით კლასი, გაუწერეთ 5 ნებისმიერი ფროფერთი, შექმენით კონსტრუქტორი 
        //გაუკეთეთ ამ ფროფერთებს ინიციალიზაცია, შემდეგ შექმენით ამ კლასის ობიექტი და გაუწერეთ მნიშვნელობები.
        Student student = new Student(35828398, "Tekle", "", "Mamporia", 16);
        //შექმენით ერთი სტრინგი და Split მეთოდით მოახდინეთ ხლეჩვა.
        string str = "Hello everyone!";
        string[] strArr = str.Split(" ");
        for (int i = 0; i < strArr.Length; i++)
        {
            Console.WriteLine(strArr[i]);
        }
        //შექმენთ რაიმე სტრინგი და ამოიღეთ ქვესტრინგი.
        string str1 = "teklemamporia";
        string subStr1 = str1.Substring(0, 5);
        Console.WriteLine(subStr1);
        //შექმენით 3 მეთოდი, რომელსაც ექნება ერთნაირი სახელი.
        Name("tekle");
        Name("tekle", "mamporia");
        Name("tekle", "-", "mamporia");
        //წარმოიდგინეთ გვაქვს მობილური, რომელიც, რომ დაჯდება თავისით უნდა დაიტენოს 
        //გააკეთეთ ენკაფსულციის პრინციპით.
        Phone phone = new Phone();
        phone.UsePhone();
        //შევქმნათ აბსტრაქტული კლასი, რომელსაც ექნება აბსტრაქტული მეთოდი, გაუკეთეთ 
        //მემკვიდრე კლასები სადაც მოხდება ამ მეთოდის იმპლემენტაცია.
        Circle circle = new Circle(15.5);
        circle.CalculateArea();
        circle.DisplayArea();
        //შექმენით ვირტუალური მეთოდი, რომელიც დაპრინტავს რაიმე ტექსტს.
        BaseClass baseclass = new BaseClass();
        DerivedClass class1 = new DerivedClass();
        baseclass.PrintText();
        class1.PrintText();
        //შექმენით ორი ინტერფეისი, გახადეთ ერთმანეთის მემკვიდრეები და რომელიმე კლასის 
        //მემკვიდრე გახადეთ.
        ClassInterface class2 = new ClassInterface();
        class2.FirstMethod();
        class2.SecondMethod();
        //შექმენით ლისტი, რომლის წევრებსაც მეთოდი Add-ით შევავსებთ.
        List<int> list1 = new List<int>();
        list1.Add(16);
        list1.Add(4);
        //შექმენით dictionary და ჩამოწერეთ 10 ქვეყანა, რომლებსაც ექნებათ თავისი ნომერი, 
        //შემდეგ გალუპეთ ეს ციკლი.
        Dictionary<string, int> dictionary = new Dictionary<string, int> {
            { "Georgia", 1 },
            { "Italy", 2 },
            { "German", 3 },
            { "Russia", 4 },
            { "France", 5 },
            { "Turkai", 6 },
            { "Ukrain", 7 },
            { "Brazil", 8 },
            { "Japan", 9 },
            { "Australia", 10 },
        };
        foreach (var item in dictionary)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
        //შექმენით 2 კლასი, ერთ კლასს ექნება ორი ფროფერთი CarName, CarCountry, მეორე 
        //კლასს ექნება მარტო CarCountry, შემდეგ შექმენით ორი ლისტრი შექმენით ახალი მანქანები და მოახდინეთ CarCountry
        //ფროფერთის მიხედვით Join ოპერაციები.
        List<Car> cars = new List<Car>
        {
            new Car { CarName = "Toyota", CarCountry = "Japan" },
            new Car { CarName = "BMW", CarCountry = "Germany" },
        };
        List<Country> countries = new List<Country>
        {
            new Country { CarCountry = "USA" },
            new Country { CarCountry = "Germany" },
        };
        var joined = from car in cars
                     join country in countries on car.CarCountry equals country.CarCountry
                     select new
                     {
                        car.CarName,
                        car.CarCountry
                     };
        //კონსოლიდან შექმენით რაიმე ფოლდერი სადაც იქნება შექმნილი რაიმე ტექსტური დოკუმენტი.
        string filePath = @"C:\Folder\Document\file.txt";
        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        byte[] data = Encoding.UTF8.GetBytes("hello everyone!");
        fs.Write(data);
        fs.Close();
        //შექმენით რაიმე ორი მეთოდი და ორი ნაკადი, ხოლო ეს მეთოდები მიანიჭეთ ამ ნაკადებს.
        Thread thread1 = new Thread(FirstMethod);
        Thread thread2 = new Thread(SecondMethod);
        thread1.Start();
        thread2.Start();
        // შექმენით 2 extension მეთოდი, პირველი ახდენდეს გადაცემული მასივის სორტირებას,
        //მეორე ახდენდეს სტრინგიდან ქვესტრინგის ამოღებას
        int[] arr = { 4, 5, 7, 23, 4, 6, 35 };
        arr.SortArray();
        string string1 = "tekle";
        string1.GetSubstring(0, 3);
        // პროექტის სახელზე ლექციამდე მოვიფიქრებ)
    }
    public static void FirstMethod()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
    public static void SecondMethod()
    {
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
    public static void Name(string name)
    {
        Console.WriteLine(name);
    }
    public static void Name(string name, string lastName)
    {
        Console.WriteLine(name + " " + lastName);
    }
    public static void Name(string name,string middleName, string lastName)
    {
        Console.WriteLine(name + " " + middleName + " " + lastName);
    }
}
public static class Extensions
{
    public static int[] SortArray(this int[] array)
    {
        return array.OrderBy(x => x).ToArray();
    }
    public static string GetSubstring(this string input, int startIndex, int length)
    {
        if (startIndex < 0 || startIndex >= input.Length || length <= 0 || startIndex + length > input.Length)
        {
            throw new ArgumentException("Invalid startIndex or length.");
        }

        return input.Substring(startIndex, length);
    }
}
public class Car
{
    public string CarName { get; set; }
    public string CarCountry { get; set; }
}
public class Country
{
    public string CarCountry { get; set; }
}

public interface IFirstInterface
{
    void FirstMethod();
}
public interface ISecondInterface
{
    void SecondMethod();
}
public class ClassInterface : IFirstInterface, ISecondInterface
{
    public void FirstMethod()
    {
        Console.WriteLine("FirstMethod");
    }
    public void SecondMethod()
    {
        Console.WriteLine("SecondMethod");
    }
}

class BaseClass
{
    public virtual void PrintText()
    {
        Console.WriteLine("base class");
    }
}
class DerivedClass : BaseClass
{
    public override void PrintText()
    {
        Console.WriteLine("override text");
    }
}
abstract class Shape
{
    public abstract double CalculateArea();
    public void DisplayArea()
    {
        Console.WriteLine($"Area is {CalculateArea()}");
    }
}
class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

class Phone
{
    private bool Charged { get; set; }
    private void ChargePhone()
    {
        Console.WriteLine("Charging phone...");
        Charged = true;
        Console.WriteLine("Phone is charged!");
    }
    public void UsePhone()
    {
        if (!Charged)
        {
            Console.WriteLine("Phone is dead.");
            ChargePhone();
        }
        Console.WriteLine("Using phone...");
        Charged = false;
    }
}
class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Student(int id, string firstName, string middleName, string lastName, int age)
    {
        Id = id;
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        Age = age;
    }

}