class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Reverse("text"));
        Console.WriteLine(Space("text"));
        Console.WriteLine(WordCount("text setg wet"));
    }
    public static string Reverse(string text)
    {
        string textnew = "";
        for (int i = text.Length-1; i >= 0; i--)
        {
            textnew += text[i];
        }
        return textnew;
    }
    public static string Space(string text)
    {
        string textnew = "";
        for (int i = 0; i < text.Length; i++)
        {
            textnew += text[i];
            textnew += " ";

        }
        return textnew;
    }
    public static int WordCount(string text)
    {
        string[] textnew = text.Split(" ");
        return textnew.Length;
    }
}