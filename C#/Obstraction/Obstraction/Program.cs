class Program {
    static void Main()
    {

    }

}
abstract class School 
{
    public string SName {  get; set; }
    public string SAddress { get; set; }
    public abstract void Info();

}
class teacher : School
{
    public string Name { get; set; }
    public double Income { get; set; }
    public string ClassTeacher {  get; set; }
    public Subject Subject { get; set; }
    public override void Info()
    {
        Console.WriteLine($"Name {SName}");
        Console.WriteLine($"School Address {SAddress}");
        Console.WriteLine($"School Name {Name}");
        Console.WriteLine($"Income {Income}");
        Console.WriteLine($"ClassTeacher {ClassTeacher}");
        Console.WriteLine($"Subject {Subject}");
    }
}
class Student : School
{
    public string Name { get; set; }
    public double AverageMark { get; set; }
    public override void Info()
    {
        Console.WriteLine($"Name {SName}");
        Console.WriteLine($"School Address {SAddress}");
        Console.WriteLine($"School Name {Name}");
        Console.WriteLine($"AverageMark {AverageMark}");
    }
}
class Subject
{
    public int TimesAWeek { get; set; }
    public int Length { get; set;}
}