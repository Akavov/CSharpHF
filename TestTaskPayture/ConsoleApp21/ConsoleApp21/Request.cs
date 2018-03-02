using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Web;
using System.Net;
using System.IO;
using System.Xml;

namespace ConsoleApp21
{
    class Request
    {
        public string Key { get; set; }
        public int Amount { get; set; }
        public string OrderId { get; set; }
        public Dictionary<string,string> PayInfo { get; set; }
        public Dictionary<string,string> CustomFields { get; set; }

       
       public string printDict(Dictionary<string,string> dictionary)
        {
            string k="";
            foreach (var item in dictionary)
            {
                k += item.Key + "=" + item.Value + ";";
            }
            return k;
        }
        

    public override string ToString()
        {
            return "Key=" + Key + "&Amount=" + Amount + "&OrderId=" + OrderId + "&PayInfo="+printDict(PayInfo)+"&CustomFields="+printDict(CustomFields);
        }
        
        

        public async Task PostRequestAsync()
        {
            WebRequest request = WebRequest.Create("https://sandbox.payture.com/api/Pay");
            request.Method = "POST"; // для отправки используется метод Post
                                     // данные для отправки
            string data = this.ToString();
            // преобразуем данные в массив байтов
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
            // устанавливаем тип содержимого - параметр ContentType
            request.ContentType = "application/x-www-form-urlencoded";
            // Устанавливаем заголовок Content-Length запроса - свойство ContentLength
            request.ContentLength = byteArray.Length;

            //записываем данные в поток запроса
            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            XmlDocument xml;
            WebResponse response = await request.GetResponseAsync();
            using (Stream stream = response.GetResponseStream())
            {
                xml = new XmlDocument();
                xml.Load(stream);
                
                
            }
            response.Close();
            XmlElement xroot = xml.DocumentElement;
            XmlAttributeCollection att = xroot.Attributes;
            XmlAttribute[] art = new XmlAttribute[att.Count];
            att.CopyTo(art, 0);
            Dictionary<string, string> attributes = new Dictionary<string, string>();
            foreach (var item in art)
            {
                attributes.Add(item.Name, item.InnerText);
            }
            Response resp = new Response()
            {
                Method = xroot.Name,
                OrderId = attributes["OrderId"],
                Key = attributes["Key"],
                Success = attributes["Success"],
                ErrCode = attributes["ErrCode"],

            };
            Console.WriteLine(resp.ToString());
            
        }
    }
}
