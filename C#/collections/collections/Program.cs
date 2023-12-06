class Program
{
    public static void Main()
    {
        LinkedList<int> intList = new LinkedList<int>();
        intList.AddFirst(1);
        intList.AddLast(2);
        intList.AddLast(3);
        //for (int i = 0; i < intList.Count; i++)
        //{
        //    Console.WriteLine(i);
        //}
        foreach (var item in intList)
        {
            Console.WriteLine(item);
        }
        //LinkedListNode<int> intList1 = new LinkedListNode<int>();
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Dequeue();
        //Console.WriteLine(queue.Peek); //pirveli elementi
        Stack<int> stack = new Stack<int>(); //QUEUE S SAWINAAGMDEGO
        stack.Push(1);
        stack.Push(2);
        stack.Pop();
        Dictionary<int, string> countries = new Dictionary<int, string>(); // key, value
        countries.Add(1, "USA");
        countries.Add(2, "UK");
        foreach (var item in countries)
        {
            Console.WriteLine(item);
        }
        List<int> list = new List<int>() { 2,3,4,5,5,4,};
        Console.WriteLine(list.Capacity);




        List<Country> countries1 = new List<Country>() 
        { 
            new Country
            {
                Name = "Georgia",
                City = "Tbilisi"
            },
            new Country
            {
                Name = "Russia",
                City = "Moscow"
            }
        };

        HashSet<int> set = new HashSet<int>() { 54, 5, 686, 7, 6, 58, 8, 687, 5, }; // unikaluri mxolod
        HashSet<int> set1 = new HashSet<int>() { 54, 5, 686, 7, 6, 58, 8, 687, 5, }; // unikaluri mxolod
        foreach (var item in set) {
            Console.WriteLine(item);
        }
        set.UnionWith(set1);
    }
}
class Country
{
    public string Name { get; set; }
    public string City {  get; set; }
}