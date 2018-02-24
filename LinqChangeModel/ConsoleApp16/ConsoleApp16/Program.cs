using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sandwiches = {"ham and cheese", "salami with mayo",
                                    "turkey and swiss","chicken cutlet"};
            var sandwichesOnRye =
                from sandwich in sandwiches
                select sandwich + " on rye";

            foreach (var sandwich in sandwichesOnRye)
            {
                Console.WriteLine(sandwich);
            }

            Random random = new Random();
            List<int> listOfNumbers = new List<int>();
            int length = random.Next(50, 150);
            for (int i = 0; i < length; i++)
            {
                listOfNumbers.Add(random.Next(100));
            }
            Console.WriteLine("There are {0} numbers", listOfNumbers.Count());
            Console.WriteLine("Minimal number is {0}", listOfNumbers.Min());
            Console.WriteLine("Maximal number is {0}", listOfNumbers.Max());
            Console.WriteLine("Their sum is {0}", listOfNumbers.Sum());
            Console.WriteLine("Average is {0:F2}", listOfNumbers.Average());

            var under50sorted =
                from number in listOfNumbers
                where number < 20
                orderby number descending
                select number;
            List<int> newList = under50sorted.ToList();
            foreach (var list in newList)
            {
                Console.Write(list+" ");
            }
            Console.ReadKey();
        }
    }
}
