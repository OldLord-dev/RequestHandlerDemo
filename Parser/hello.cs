using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HttpRequestHandler<string,string> h = new HttpRequestHandler<string, string>(new System.Net.Http.HttpClient(), new Parser<string>());
            Task<string> t = h.Handle(new StringContent(""), HttpMethod.Get, "https://www.google.com", new Dictionary<string, string>(), new System.Threading.CancellationToken());
            Console.WriteLine("Task returned !");
            t.Wait();        
            Console.WriteLine(t.Result);
        }
    }
}