using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Request req = new Request()
            {
                Key = "Merchant",
                Amount = 100,
                OrderId = "5606114211372714656544176026231024",
                PayInfo = new Dictionary<string, string>
                {
                      {"PAN","4111111111111112" },
                      {"EMonth","3" },
                      {"EYear","18" },
                      {"CardHolder","Ivan Ivanov" },
                      {"SecureCode","123" },
                      {"OrderId","5606114211372714656544176026231024" },
                      {"Amount","100" },
                },
                
                CustomFields =new Dictionary<string, string>
                {
                    { "OrderId", "7.2.236.72" },
                    { "Product", "ticket" },
                },
             };


            Task t = req.PostRequestAsync();
            Console.ReadKey();
        }
    }
}
