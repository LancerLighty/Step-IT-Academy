class Person
{
    public string Name { get; set; }
    public int Id { get; set; }
    public int Age { get; set; }
    public void Talk(string text)
    {
        Console.WriteLine(text);
    }
}
public struct Struct
{
    public string Text { get; set; }
    public int Number { get; set; }
    public Struct(string text, int number)
    {
        Text = text;
        Number = number;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Text: {Text}, Number: {Number}");
    }
}
class Cat
{
    public string Name { get; set; }
    public string Type {  get; set; }
    public int Age { get; set; }
    public bool Gender {  get; set; }
    private const int Eat = 10;
    public void Meow()
    {
        Console.WriteLine("meowing...");
    }
    public void Eating(int foodGrams)
    {
        int biteCount = foodGrams / Eat;
        for (int i = 0; i < biteCount; i++)
        {
            Console.WriteLine("eating...");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person person = Activator.CreateInstance<Person>();
        Struct @struct = Activator.CreateInstance<Struct>();
        @struct.Text = "Hello!";
        @struct.Number = 5;
        @struct.PrintInfo();
        Cat cat = new Cat();
        cat.Meow();
        cat.Eating(25);

    }
}