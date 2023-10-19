using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

class Profram
{
    static void Main()
    {
        //string name = "Tekle";
        //string lastname = "mamporia";
        //name = name.ToLower();// lower case
        //lastname = string.Concat(name, lastname);
        //string name2 = "tekulika";
        //bool equal = name == name2;
        //bool equal2 = name.Equals(name2);
        //string substring = name.Substring(1, 3);
        //StringBuilder text = new StringBuilder();
        //text.Append("teko");
        //text.Append("teko");
        //text.Replace("teko", "ani");
        //text.Clear();
        //string name3 = "ani,tako,tek";
        //string[] split = name3.Split(",");
        //string namess = Console.ReadLine().Trim();
        //Console.WriteLine($"helo {namess}");
        //int index = name3.IndexOf("a");

        //StringBuilder text2 = new StringBuilder();
        //text.Append("tek");
        //text.Append("tekoo");
        //text.Append("mamphoria");
        //text.Replace("mamphoria", "mamporia");
        //string names = "tekle ani saba nika tako";
        //string[] split = names.Split(" ");
        //for (int i = 0; i < split.Length; i++)
        //{
        //    Console.WriteLine(split[i]);
        //}



        string text = Console.ReadLine();
        text = text.ToLower();
        Console.WriteLine(text.Length);
        string text2 = Console.ReadLine();
        string text12 = string.Concat(text, text2);
        Console.WriteLine(text12);
        bool equal = text.Equals(text2);
        Console.WriteLine(equal);
        string text3 = Console.ReadLine();
        string substring = text3.Substring(1, 3);
        Console.WriteLine(substring);

    }
}