namespace loop_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 43;
            if (num == 1)
            {
                Console.WriteLine("ne sade ne murekkeb");
            }
            else if (num >= 4 && num % 2 == 0)
            {
                Console.WriteLine("murekkeb");
            }
            else if (num % 2 != 0)
            {
                bool eded = true;
                for (int i = 2; i <= (num - 1) / 2; i++)
                {
                    if (num % i == 0)
                    {
                        eded = false;
                        break;
                    }
                }
                if (eded)
                {
                    Console.WriteLine("sade");
                }
                else
                {
                    Console.WriteLine("murekkeb");
                }
            }
            else
            {
                Console.WriteLine("sade");
            }

        }

    }
}
