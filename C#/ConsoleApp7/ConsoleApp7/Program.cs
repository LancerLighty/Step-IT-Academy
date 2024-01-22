class Triangle
{
    private int FirstSide = 0;
    private int SecondSide = 0;
    private int ThirdSide = 0;
    public int first
    {
        get { return FirstSide; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("error1");
            }
            else if ((SecondSide + ThirdSide) > value)
            {
                Console.WriteLine("error1");
            }
            else{
                FirstSide = value;
            }
        }
    }
    public int second
    {
        get { return SecondSide; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("error2");
            }
            else if ((FirstSide + ThirdSide) > value)
            {
                Console.WriteLine("error2");
            }
            else
            {
                SecondSide = value;
            }
        }
    }
    public int third
    {
        get { return ThirdSide; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("error31");
            }
            else if (((FirstSide + SecondSide) > value))
            {
                Console.WriteLine("error32");
            }
            else
            {
                ThirdSide = value;
            }
        }
    }

}
class Prgoram
{
    static void Main()
    {
        Triangle triangle = new Triangle();
        triangle.first = 4;
        triangle.second = 2;
        triangle.third = 5;
        int s = (triangle.first + triangle.second + triangle.third);
        double area = Math.Sqrt(s * (s - triangle.first) * (s - triangle.second) * (s - triangle.third));
        Console.WriteLine(s);
        Console.WriteLine(area);
    }
}