using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] balance = new int[5];
            int i; 

            for(i = 0; i < 5; i++)
            {
                int number = i + 1;
                Console.WriteLine("Enter the balance of " + number);
                balance[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("The ToTal is =");
            Console.WriteLine(balance[3]);
        }
    }
}
