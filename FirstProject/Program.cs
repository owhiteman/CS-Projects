using System;

namespace FirstProject
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter upper limit: ");
            int upper = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime numbers up to " + upper + " are:");
            for (int i = 2; i < upper; i++)
            {
                bool prime = true;
                if (i % 2 == 0)
                {
                    prime = false;
                }
                else
                {
                    for (int j = 2; j < Math.Sqrt(i) + 1; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                        }
                    }
                }
                
                if (prime == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
