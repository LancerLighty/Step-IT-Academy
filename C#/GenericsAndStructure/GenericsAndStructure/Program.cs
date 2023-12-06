class Program
{
    static void Main()
    {

    }
    static int Seconds(int minutes)
    {
        return minutes * 60;
    }
    static int PlusOne(int number)
    {
        return number++;
    }
    static bool MoreThanHundred(int number1 ,int number2)
    {
        if (number1 + number2 > 100)
        {
            return true;
        }
        return false;
    }
    static int Score(int num1,int num2)
    {
        return (num1 * 2) + (num2 * 3);
    }
    static int Win(int win, int tie, int lose)
    {
        return (win * 3) + tie;
    }
}