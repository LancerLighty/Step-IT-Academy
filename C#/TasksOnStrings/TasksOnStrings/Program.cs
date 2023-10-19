using System.Text;
class Program
{
    static void Main()
    {
        //1)მოახერხეთ ისე, რომ შემოვიყვანოთ დიდი ტექსტი და დაგვიბრუნდეს პატარა ტექსტად.
        string word = Console.ReadLine().ToLower();
        Console.WriteLine(word);
        //2)დააბრუნეთ რაიმე ტექსტის სიგრძე.
        Console.WriteLine(word.Length);
        //3)შეართეთ ორი ტექსტი და დაპრინტეთ.
        string word2 = Console.ReadLine();
        Console.WriteLine(string.Concat(word, word2));
        //4)შეადარეთ ორი სტრინგი ერთმანეთს.
        bool equals = word.Equals(word2);
        Console.WriteLine(equals);
        //5)სტრინგიდან ამოიღეთ ქვესტრინგი და დაპრინტეთ.
        Console.WriteLine(word.Substring(1,2));
        //6)StringBuilder ის საშუალებით მოახდინეთ ტექსტების შეერთება და შემდეგ ერთი ტექსტის შეცვლა.
        StringBuilder text = new StringBuilder();
        text.Append("tek");
        text.Append("tekoo");
        text.Append("mamphoriaaa");
        text.Replace("mamphoriaaa", "mamporia");
        //7)შექმენით რაიმე სტრინგი და მოახდინეთ ხლეჩვა და შემდეგ დაპრინტვა.
        string names = "tekle ani saba nika tako";
        string[] split = names.Split(" ");
        for (int i = 0; i < split.Length; i++)
        {
            Console.WriteLine(split[i]);
        }
        //8)შექმენით სტრინგი და რომელიმე ასოს ინდექსი დაპრინტეთ.
        Console.WriteLine(word.IndexOf("a"));
    }
}