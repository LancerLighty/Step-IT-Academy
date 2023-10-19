class Program
{
    static void Main()
    {
        //int[] numArr = { 5, 6, 90, 20 };
        //int[] numArr2 = { 5234, 6234, 9, 22130 };
        //for (int i = 0; i < numArr.Length; i++)
        //{
        //    Console.WriteLine(numArr[i]);
        //}
        //for (int i = 0; i < numArr2.Length; i++) {
        //    Console.WriteLine(numArr2[i]);
        //}
        //int[] numArr3 = { 5, 6, 90, 20 };
        //Console.WriteLine(numArr3.Min());
        //Console.WriteLine(numArr3.Max());
        //Console.WriteLine(numArr3.Sum());
        int[] numArr4 = { 5, 6, 570, 90, 20, 201, 2, 47};
        int[] numArr5 = numArr4.Where(i => i > 15).ToArray();
        for (int i = 0; i < numArr5.Length; i++)
        {
            Console.WriteLine(numArr5[i]);
        }
    }
}