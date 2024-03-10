namespace loop_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product = 1;
            int num = 265;
            int qaliq;
            while (num != 0)
            {
                qaliq = num % 10;
                num = num - qaliq;
                product *= qaliq;
                num = num / 10;
                
            }
            Console.WriteLine(product);

        }
    }
}