using System;

int[] arr = { 2, 5, 7, 8, 4, 23, 8, 2, 4, };
arr.ArraySort();
int[] arr1 = arr.Unique();
Console.WriteLine("tekle ".Add("Mamporia"));
Console.WriteLine(5.Multiply(5));
Student student = new Student();
student.AttendALecture();
student.TakeABreak();
student.TakeTest();
student.WriteHomework();
student.Read();
public static class Extension {
    public static int[] ArraySort(this int[] arr)
    {
        Array.Reverse(arr);
        return arr;
    }
    public static int[] Unique(this int[] arr)
    {
        return arr.Distinct().ToArray();
    }
    public static string Add(this string name, string lastName)
    {
        return name + lastName;
    }
    public static int Multiply(this int first, int second)
    {
        return first * second;
    }
}

public partial class Student
{
    public void Read()
    {
        Console.WriteLine("Read...");
    }
}
public partial class Student
{
    public void WriteHomework()
    {
        Console.WriteLine("Writing Homework...");
    }
}
public partial class Student
{
    public void TakeTest()
    {
        Console.WriteLine("Taking Test...");
    }
}
public partial class Student
{
    public void AttendALecture()
    {
        Console.WriteLine("Attending A Lecture...");
    }
}
public partial class Student
{
    public void TakeABreak()
    {
        Console.WriteLine("Taking A Break...");
    }
}