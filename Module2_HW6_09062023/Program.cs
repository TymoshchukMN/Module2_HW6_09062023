namespace Module2_HW6_09062023
{
    using System;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(random.Next(1, 3));
            }

            Starter.Run();
        }
    }
}
