using System.ComponentModel.Design;

namespace loop_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1231;
            int a = n;
            int ters = 0;
            int qaliq;
            while (n > 0)
            {
                qaliq = n % 10;
                ters = ters * 10 + qaliq;
                n = n / 10;
            }
            if (a == ters)
            {
                Console.WriteLine("polindromdur.");
            }
             
            else
            {

                Console.WriteLine("polindrom deyil.");

            }



            
        }
    }
}