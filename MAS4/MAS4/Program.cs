using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS4
{
    class Program
    {
        static void Main(string[] args)
        {
            Spolka test = new Spolka("Testowa", "2222", TypySpolek.ZOO, 23000);
            Console.WriteLine(test);
            Console.ReadKey();
        }
    }
}
