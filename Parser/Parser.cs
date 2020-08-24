using System;

using System.Net.Http;

namespace Parser
{
    public class Parser<TResult> : IHttpResponseParser<TResult>
    {
        public TResult ParseAsync(HttpResponseMessage response) {
            var split = response.ToString().Split(' ');            
            Console.WriteLine("Parse called!");
            object s = response.ToString();
            return (TResult) s;
        }
    }
}