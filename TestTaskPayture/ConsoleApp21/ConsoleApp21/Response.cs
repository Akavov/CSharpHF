using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Response
    {
        public string Method { get; set; }
        public string Key { get; set; }
        public string OrderId { get; set; }
        public string Success { get; set; }
        public string ErrCode { get; set; }

        public override string ToString()
        {
            return "Метод: " + Method + "\nOrderId: " + OrderId + "\nКлюч: " + Key + "\nУспех операции: " + Success + "\nОшибка: " + ErrCode;
        }
    }
}
