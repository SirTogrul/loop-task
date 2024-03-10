namespace loop_task3

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product = 1;
            int num = 7;
               
                for(int i=1; i<=num; i++)
            {
                product *= i;

            }
            Console.WriteLine(product);
              
        }
    }
}