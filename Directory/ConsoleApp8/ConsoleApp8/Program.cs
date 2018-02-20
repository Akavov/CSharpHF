using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string k = "OOOOOOHHHHH YYYYYEEEEEEAHHHHH";
            Directory.CreateDirectory(@"C:\ohhhhhhyyyyyeeeeeeaahh");
           // File.Create(@"c:\ohhhhhhyyyyyeeeeeeaahh\yeah.txt");
           
            System.Threading.Thread.Sleep(3000);
            File.AppendAllText(@"c:\ohhhhhhyyyyyeeeeeeaahh\yeah.txt", k);
        }
    }
}
