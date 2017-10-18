using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var diffrence = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    int secondNum = numbers[j];
                    if (currentNum - secondNum == diffrence)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
