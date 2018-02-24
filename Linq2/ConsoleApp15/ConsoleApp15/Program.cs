using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrice();

            var mostExpensive =
                from comic in comics
                where values[comic.Issue] > 500
                orderby values[comic.Issue] descending
                select comic;

            foreach (Comic comic in mostExpensive)
            {
                Console.WriteLine("{0} costs {1:c}", comic.Name, values[comic.Issue]);
            }

            Console.ReadKey();
        }

        private static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic>
            {
                new Comic{ Name="Johnny America vs. the Pinko", Issue=6},
                new Comic{ Name="Rock and Roll (special edition)", Issue=19},
                new Comic{Name="Woman`s Work", Issue=36},
                new Comic{ Name="Hippie Madness (with mistakes)", Issue=57},
                new Comic { Name="Revenge of the New Wave Freak", Issue=68},
                new Comic{ Name="Black Monday", Issue=74},
                new Comic{ Name="Tribal Tattoo Madness", Issue=83},
                new Comic{ Name="The death of an Object",Issue=97},
            };
        }

        private static Dictionary<int,decimal> GetPrice()
        {
            return new Dictionary<int, decimal>
            {
                {6,3600M },
                {19,500M },
                {36,650M },
                {57, 13525M },
                {68, 250M },
                {74,75M },
                {83,25.75M },
                {97,32.25M },
            };
        }
    }
}
