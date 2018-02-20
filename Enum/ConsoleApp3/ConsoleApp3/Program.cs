using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Suits s = (Suits)1;
            Card card = new Card(s, (Values)random.Next(1, 14));
            Console.WriteLine( card.Name);

            Console.ReadKey();
        }
    }
}
