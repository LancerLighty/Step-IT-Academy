class Program
{
    static void Main()
    {

    }
    public int Seconds(int minutes)
    {
        return minutes * 60;
    }
    public int PlusOne(int number)
    {
        return number + 1;
    }
    public bool BiggerThan100(int num1, int num2)
    {
        return (num1 + num2) > 100;
    }
    public class GenericClass<T1, T2>
    {
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }

        public GenericClass(T1 value1, T2 value2)
        {
            Value1 = value1;
            Value2 = value2;
        }
    }
    public void GenericMethod<T1,T2>(T1 t1, T2 t2)
    {
        Console.WriteLine(t1); 
        Console.WriteLine(t2);
    }

}