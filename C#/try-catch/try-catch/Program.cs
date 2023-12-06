using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        JustValue justValue1 = new JustValue();
        justValue1.Value = 10;
        JustValue justValue2 = new JustValue();
        justValue2.Value = 2;
        JustValue result = justValue1 + justValue2;
        Console.WriteLine(result.Value);
        int num1 = 20;
        int num2 = 0;
        try
        {
            Console.WriteLine(num1 / num2);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        try
        {
            Console.WriteLine(num1 / num2);
        }
        catch (DivideByZeroException) when (num1 == 0 && num2 == 0)
        {
            Console.WriteLine("error both numbers are 0");
        }
        catch (DivideByZeroException) when (num1 == 0 || num2 == 0)
        {
            Console.WriteLine("error one of the number is 0");
        }
    }
}
class JustValue
{
    public int Value { get; set; }
    public static JustValue operator +(JustValue v1, JustValue v2)
    {
        if (v1 == null || v2 == null)
        {
            throw new ArgumentNullException("v1 and v2 must not be null.");
        }

        return new JustValue { Value = v1.Value + v2.Value };
    }

    public static JustValue operator -(JustValue v1, JustValue v2)
    {
        if (v1 == null || v2 == null)
        {
            throw new ArgumentNullException("v1 and v2 must not be null.");
        }

        return new JustValue { Value = v1.Value - v2.Value };
    }

    public static JustValue operator *(JustValue v1, JustValue v2)
    {
        if (v1 == null || v2 == null)
        {
            throw new ArgumentNullException("v1 and v2 must not be null.");
        }

        return new JustValue { Value = v1.Value * v2.Value };
    }

    public static JustValue operator /(JustValue v1, JustValue v2)
    {
        if (v1 == null || v2 == null)
        {
            throw new ArgumentNullException("v1 and v2 must not be null.");
        }

        if (v2.Value != 0)
        {
            return new JustValue { Value = v1.Value / v2.Value };
        }
        else
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
    }
}