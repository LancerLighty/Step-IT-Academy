class Progrm
{
    static void Main()
    {
        //1) while ციკლის დახმარებით დავპრინტოთ რიცხვები 1 - 20ის ჩათვლით.
        int num = 0;
        while (num <20) {
            num++;
            Console.WriteLine(num);
        }
        //2) do while ციკლს გადავცეთ აბსურდული პირობა, მაგრამ ერთხელ მაინც შევასრულებინოთ დავალება.
        do
        {
            Console.WriteLine("do-while");
        } while (num == -1);
        //3) for ციკლის საშუალებით დავპრინტოთ ციფრები 1 - 10 მდე.
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        //4) for ციკლის ტანში რაიმე სტრინგი შემოვიტანოთ და რაღაც კონკრეტული სიტყვის დროს პროცესი გაწყდეს გამოვიყენოთ break
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine("Enter text:");
            string text = Console.ReadLine();
            if (text == "exit")
                break;
        }
        //5) for ციკლში დავბეჭდოთ რიცხვები 1 - 10ის ჩათვლით, მაგრამ ციკლი 6 იანს გადაახტეს და გააგრძელოს მუშაობა გამოიყენეთ continue
        for(int i = 1;i <= 10; i++)
        {
            if (i == 6)
                continue;
            Console.WriteLine(i);
        }
    }
}