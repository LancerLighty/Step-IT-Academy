class Program
{
    static void Main()
    {

    }
}
interface ISumInterface
{
    int Sum(int a, int b);
}
class SumImplementation : ISumInterface
{
    public int Sum(int a, int b)
    {
        return a + b;
    }
}
interface IPrintInterface
{
    void Print(string text);
}
class PrintImplementation : IPrintInterface
{
    public void Print(string text)
    {
        Console.WriteLine(text);
    }
}
interface IFirstInterface
{
    void FirstInterface();
}
interface ISecondInterface
{
    void SecondInterface();
}

class ImplementationClass : IFirstInterface, ISecondInterface
{
    public void FirstInterface()
    {
        Console.WriteLine("pirveli interface");
    }

    public void SecondInterface()
    {
        Console.WriteLine("meore interface");
    }
}
class BaseClass
{
    public virtual void VirtualMethod()
    {
        Console.WriteLine("virtualuri metodi");
    }
}
class ChildClass : BaseClass
{
    public override void VirtualMethod()
    {
        Console.WriteLine("virtualuri metod child classShi");
    }
}