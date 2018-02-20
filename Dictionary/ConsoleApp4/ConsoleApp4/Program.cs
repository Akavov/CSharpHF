using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(0, "kakote znachenie");
            dic.Add(1, "bbbb");
            //Console.WriteLine(dic["kakoito kluch"]);
            foreach (int item in dic.Keys)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(dic.Count);
            Console.ReadKey();
        }
    }
}
