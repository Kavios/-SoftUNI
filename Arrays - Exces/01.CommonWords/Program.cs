using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split();
            string[] second = Console.ReadLine().Split();
            int leftcounter = 0;
            int rightcounter = 0;

            int length = Math.Min(first.Length, second.Length);

            for (int i = 0; i < length; i++)
            {
                if (first[i] == second[i]) //proveka ot lqvo na dqsno
                {
                    leftcounter++;
                }
                if (first[first.Length - 1 - i] == second[second.Length - 1 - i] ) //proverka ot dqsno na lqvo
                {
                    rightcounter++;
                }
            }
            Console.WriteLine(Math.Max(leftcounter, rightcounter));


        }
    }
}
