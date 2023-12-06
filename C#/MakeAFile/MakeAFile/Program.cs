using System.Text;

class program
{
    static void Main()
    {
        string filePath = @"C:\Text\Test.txt";
        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        byte[] textData = Encoding.UTF8.GetBytes("checking  code!!!");
        fs.Write(textData);
        fs.Close();

        string filePath1 = @"C:\Text\Test.txt";
        Directory.CreateDirectory(Path.GetDirectoryName(filePath));
        FileStream fs1 = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        StreamReader sr = new StreamReader(fs1);
        string res = sr.ReadToEnd();
        Console.WriteLine(res);
        sr.Close();
    }
}