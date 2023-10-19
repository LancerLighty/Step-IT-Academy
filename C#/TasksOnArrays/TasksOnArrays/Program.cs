class Program { 
    static void Main()
    {
        //1)შექმენით მასივი და შეავსეთ 10 ელემენტით და მიანიჭეთ მნიშვნელობები.
        int[] nums = new int[10];
        nums[0] = 20;
        nums[1] = 45345;
        nums[2] = 3245;
        nums[3] = 234;
        nums[4] = 45;
        nums[5] = 2;
        nums[6] = 235;
        nums[7] = 12;
        nums[8] = 4;
        nums[9] = 78;
        //2)ეს მასივი დაპრინტეთ კონსოლში.
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
        //3)დაპრინტეთ ამ მასივის ზომა.
        Console.WriteLine("length: " + nums.Length);
        //4)შექმენით ახალი მასივი, შეავსეთ და დაპრინტეთ ყველაზე პატარა, დიდი ციფრი, ასევე წევრების ჯამი.
        int[] nums2 = { 19, 2123, 32, 34, 51, 63, 56 };
        Console.WriteLine(nums2.Min());
        Console.WriteLine(nums2.Max());
        Console.WriteLine(nums2.Sum());
        //5)შექმენით მასივი და დაალაგეთ ზრდადობის მიხედვით.
        int[] newNum = nums2.OrderBy(x => x).ToArray();
        for (int i = 0; i < newNum.Length; i++)
        {
            Console.WriteLine(newNum[i]);
        }
        //6)შექმენით მასივი და წამოიღეთ პირველი ციფრი, რომელიც მეტი იქნება 20ზე.
        int lower = Array.Find(nums2, i => i > 20);
        Console.WriteLine(lower);
    }
}