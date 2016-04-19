using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i = 0; i < 10; i++)
            {
                Console.WriteLine("test {0}",i);
                Console.WriteLine($"test {i*i}", i);
            }
        }
    }
}
