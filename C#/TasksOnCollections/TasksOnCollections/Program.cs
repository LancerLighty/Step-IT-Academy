using System.Collections.Generic;
using System.Diagnostics.Metrics;
class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>()
        {
            new Animal
            {
                Name = "cat",
                Breed = "britan"
            },
            new Animal
            {
                Name = "dog",
                Breed = "russian"
            },
            new Animal
            {
                Name = "dog",
                Breed = "brittan"
            }
        };
        Dictionary<int, string> countries = new Dictionary<int, string>();
        countries.Add(1, "USA");
        countries.Add(2, "Canada");
        countries.Add(3, "United Kingdom");
        countries.Add(4, "USA");
        countries.Add(5, "Georgia");
        countries.Add(6, "Germany");
        countries.Add(7, "France");
        countries.Add(8, "China");
        countries.Add(9, "Japan");
        countries.Add(10, "Turkey");
        HashSet<int> set = new HashSet<int>() { 54, 5, 686, 7, 6, 58, 8, 687, 5, };
        HashSet<int> set1 = new HashSet<int>() { 54, 5, 686, 7, 6, 58, 8, 687, 5, };
        set.UnionWith(set1);
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(234);
        queue.Enqueue(2234);
        queue.Enqueue(12312);
        queue.Dequeue();
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(1232);
        stack.Push(672);
        stack.Push(432);
        stack.Push(263);
        stack.Pop();
    }
}
class Animal
{
    public string Name { get; set; }
    public string Breed { get; set; }
}