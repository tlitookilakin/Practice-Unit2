namespace ConditionalLecture;

class Program
{
    static void Main(string[] args)
    {
        bool isHungry = true;

        if (isHungry)
            Console.WriteLine("You are hungry!");
        else 
            Console.WriteLine("You are not hungry");

        int temp = 123;

        if (temp >= 212)
            Console.WriteLine("Boiling!");
        else if (temp <= 32)
            Console.WriteLine("Freezing!");
        else
            Console.WriteLine("Normal.");

        for (int i = 10; i >= 0; i--)
            Console.WriteLine(i);

        string[] items = ["tom", "david", "john"];
        foreach (string item in items)
            Console.WriteLine(item);

        bool run = true;
        while (run)
        {
            while (true)
            {
                var entry = Console.ReadLine();
                if (entry is not null && entry.Length != 0) 
                {
                    if (entry[0] is 'Y' or 'y')
                    {
                        break;
                    }
                    else if (entry[0] is 'N' or 'n')
                    {
                        run = false;
                        break;
                    }
                }

                Console.WriteLine("Invalid answer, please enter [y] or [n]");
            }
        }
    }
}
