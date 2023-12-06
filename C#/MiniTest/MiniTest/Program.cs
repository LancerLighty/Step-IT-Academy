using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your Name?");
        Console.WriteLine(Console.ReadLine());
        int num = 1;
        int num1 = 2;
        if(num > 0 && num1 > 0)
        {
            Console.WriteLine("orive dadebitia");
        } else if (num > 0 || num1 > 0)
        {
            Console.WriteLine("erterti dadebitia");
        } else
        {
            Console.WriteLine("orive uaryofitia");
        }
        string[] stringArr = { "tekle", " mamporia", "tek" };
        int[] intArr = { 12,34,57 };
        for (int i = 0; i < stringArr.Length; i++)
        {
            Console.WriteLine(stringArr[i]);
            for (int j = 0; j < intArr.Length; j++)
            {
                Console.WriteLine(intArr[j]);
            }
        }
        int[] unicIntArr = intArr.Distinct().ToArray();
    }
    public static void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
class Cat{ 
    public string Name {  get; set; }
    public string Colour {  get; set; }
    public int Age {  get; set; }
    public double Weight {  get; set; }
    public double Length {  get; set; }
    public Cat(string name, string colour, int age, double weight, double length) { 
        Name = name; 
        Colour = colour;
        Age = age;
        Weight = weight; 
        Length = length;
    }
}
class Phone
{
    private bool Charged { get; set; }
    private void Charge()
    {
        Console.WriteLine("charging..");
        Charged = true;
        Console.WriteLine("charged!");
    }
    public void UsePhone()
    {
        if (!Charged)
            Charge();
        Console.WriteLine("using Phone..");
        Charged = false;
        Console.WriteLine("battery is dead.");
    }
}
class City
{
    public string Name { get; set; }
    public int Citizens { get; set; }
    public string President {  get; set; }
    public City(string name, int citizens, string president)
    {
        Name = name;
        Citizens = citizens;
        President = president;
    }
}
class Tbilisi : City
{
    public Tbilisi(string name, int citizens, string president) : base(name, citizens, president)
    {
        
    }
}
abstract class People
{
    public abstract void Info();
}
class JustClass : People
{
    public override void Info()
    {
        
    }
}
interface JustClass1
{
    void Name(string name);
    void LastName(string lastName);
    void age(int age);
}
class JustClass2 : JustClass1
{
    public void age(int age)
    {
        Console.WriteLine(age);
    }

    public void LastName(string lastName)
    {
        Console.WriteLine(lastName);
    }

    public void Name(string name)
    {
        Console.WriteLine(name);
    }
}
