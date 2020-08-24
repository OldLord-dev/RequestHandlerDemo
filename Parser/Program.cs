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
            HttpRequestHandler<string,string> handler = new HttpRequestHandler<string, string>(new System.Net.Http.HttpClient(), new Parser<string>());
            Task<string> task = handler.Handle(new StringContent(""), HttpMethod.Get, "https://www.google.com", new Dictionary<string, string>(), new System.Threading.CancellationToken());
            Console.WriteLine("Task returned !");
            task.Wait();        
            String s=task.Result.ToString();
            Console.WriteLine(s); //Wypisanie wszystkich headerów
            
            // krótki test na działanie klasy Finder ~wyszukuje podany header i wupisuje jego wartosc  
            Console.WriteLine(new Finder("Set-Cookie:").find_substring(s)); // wypisanie ciasteczka

        }
    }
}