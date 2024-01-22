using System.Runtime.CompilerServices;

class Cat
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Age { get; set; }
    public bool Gender { get; set; }
    public static void Meow()
    {
        Console.WriteLine("meowing...");
    }
    public static void eating(int foodGrams)
    {
        double count = foodGrams / 10;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("eating...");
        }
    }
}
class Program
{
    static void Main()
    {
        Cat cat = Activator.CreateInstance<Cat>();
        cat.Name = "kata";
        cat.Type = "amerikuli"; 
        cat.Age = 2;
        cat.Gender = true;
    }
}