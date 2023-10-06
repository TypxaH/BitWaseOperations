using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_1.BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {/*char sign = char.Parse(Console.ReadLine());
            string bin = Convert.ToString(n, 2);
            int counter = 0;
            foreach (char item in bin)
            {
                if (item == sign)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);*/
            int n = int.Parse(Console.ReadLine());            
            int sign = int.Parse(Console.ReadLine());
            int counter = 0;
            while (n > 0)
            {
                int lastSign = n & 1;
                if (lastSign == sign)
                {
                    counter++;
                }
                n = n >> 1;
            }
            Console.WriteLine(counter);
        }
    }
}
