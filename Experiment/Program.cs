using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = 15;
            string text = Console.ReadLine();
            string coded = "";
            foreach (var sign in text)
            {
                coded += (char)(sign ^ key);
            }
            Console.WriteLine(coded);
        }
    }
}
