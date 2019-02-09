using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double e = 256,
            rez = Math.Sqrt(e);
            Console.WriteLine("kvadratni koren 256 = {0}", rez);
            Console.ReadKey();
        }
    }
}
