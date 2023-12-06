using System.Xml.XPath;

class Program
{

    public void MakeArray()
    {
        int[] array = new int[int.Parse(Console.ReadLine())];
        foreach (int i in array)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
    public void MakeArrayReversed()
    {
        int[] array = new int[int.Parse(Console.ReadLine())];
        foreach (int i in array)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int start = 0;
        int end = array.Length - 1;
        while (start < end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;
            start++;
            end++;
        }
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
    public int MakeArrayPlus()
    {
        int[] array = new int[int.Parse(Console.ReadLine())];
        foreach (int i in array)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int result = 0;
        foreach (int i in array)
        {
            result += array[i];
        }
        return result;
    }
    public void MakeArrayUnic()
    {
        int[] array = new int[int.Parse(Console.ReadLine())];
        foreach (int i in array)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length; i++)
        {
            bool unique = false;
            for (int j = 0; j < i; j++)
            {
                if (i == j && array[i] == array[j])
                {
                    unique = false;
                    break;
                }
            }
            if (unique)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}