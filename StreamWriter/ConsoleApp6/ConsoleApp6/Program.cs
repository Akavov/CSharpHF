using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("sc.txt");
            writer.WriteLine("How I`ll defeat Captain Amazing");
            writer.WriteLine("Another genius secret plan by The Swindler");
            writer.Write("I`ll create an army of clones and ");
            writer.WriteLine("unleash them upon the citizens of Objectville.");
            string location = "the mall";
            for (int number = 0; number <=6; number++)
            {
                writer.WriteLine("Clone #{0} attacks {1}", number, location);
                if (location=="the mall")
                {
                    location = "downtown";
                }
                else
                {
                    location = "the mall";
                }
            }
            writer.Close();
            Console.WriteLine("Succes!");
            Console.ReadKey();
        }
    }
}
