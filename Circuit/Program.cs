using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circuit
{
    class Program
    {
        static void Main(string[] args)
        {
            Battery b1 = new Battery();
            Battery b2 = new Battery();
            Battery b3 = new Battery();
            Battery b4 = new Battery();
            Console.WriteLine(b1.getName());
            Console.WriteLine(b2.getName());
            Console.WriteLine(b3.getName());
            Console.WriteLine(b4.getName());
            Console.ReadLine();
        }
    }
}
