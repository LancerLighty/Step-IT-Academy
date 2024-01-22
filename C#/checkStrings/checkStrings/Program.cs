using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string string1 = "me vwer kods";
        string pattern = "me";
        bool match = Regex.IsMatch(string1, pattern);
        Console.WriteLine(match);

        string string2 = "tek";
        string pattern2 = "t.k";
        bool match2 = Regex.IsMatch(string2, pattern2);
        Console.WriteLine(match2);

        string string3 = "aetg";
        string pattern3 = "[ighio]";
        bool match3 = Regex.IsMatch(string3, pattern3);
        Console.WriteLine(match3);

        string string4 = "tekle";
        string pattern4 = "^te";
        string pattern5 = "le$";
        bool match4 = Regex.IsMatch(string4, pattern4);
        bool match5 = Regex.IsMatch(string4, pattern5);
        Console.WriteLine(match4);
        Console.WriteLine(match5);

        string saxelebi = "sandro,andria,ana,mari,gio";
        string match6 = "sandro,andria";
        MatchCollection matchSaxelebi = Regex.Matches(saxelebi, match6);
        foreach (var item in matchSaxelebi)
        {
            Console.WriteLine(item);
        }
    }
}