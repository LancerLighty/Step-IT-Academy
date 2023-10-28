
interface IPrint
{
    void JustPrint();
}
interface IPrintInfo
{
    void PrintString(string word);
}
class AllPrint : IPrintInfo, IPrint
{
    public void JustPrint()
    {
        Console.WriteLine("test");
    }
    public void PrintString(string word)
    {
        Console.WriteLine(word);
    }
}
class Program
{
    static void Main()
    {
        AllPrint tekle = new AllPrint("tekle");
        tekle.JustPrint();
        tekle.PrintString("tekle");

    }
}