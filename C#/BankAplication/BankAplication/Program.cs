using Event;

Account account1 = new Account(500);
account1.Filled += DisplayInfoInFile;


static void DisplayInfoInFile(object sender, AccountEventArgs e)
{
    string path = @"C:\Users\Luka\Desktop\New folder (3)\Logger.txt";
    File.WriteAllText(path, e.Message);
}