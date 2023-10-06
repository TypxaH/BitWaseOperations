using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_OddTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int result = 0;
            foreach (int num in nums)
            {
                result = result ^ num;
            }
            Console.WriteLine(result);
        }
    }
}
