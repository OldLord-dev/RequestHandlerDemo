using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Parser
{
    public partial class HttpRequestHandler<TRequest, TResponse>
    {
        internal HttpClient _httpClientProxy;

        private IHttpResponseParser<TResponse> _parser { get; }
        public HttpRequestHandler(HttpClient httpClientProxy, IHttpResponseParser<TResponse> parser)
        {
            _httpClientProxy = httpClientProxy;
            _parser = parser;
            Console.WriteLine("Handler created!");
        }

        public async Task<TResponse> Handle(HttpContent payload, HttpMethod methodName,
            string pleaseProvideFullUrlHere,
            IDictionary<string, string> additionalHeaders, CancellationToken cancellationToken)
        {
            Console.WriteLine("Handle called!");

            var uriString = $"{_httpClientProxy.BaseAddress}{pleaseProvideFullUrlHere}";

            var httpRequestMessage = new HttpRequestMessage(methodName, new Uri(uriString));

            if (payload != null)
            {
                httpRequestMessage.Content = payload;
            }

            if (additionalHeaders != null)
            {
                foreach (var header in additionalHeaders)
                {
                    httpRequestMessage.Headers.Add(header.Key, header.Value);
                }
            }

            HttpResponseMessage response = await _httpClientProxy.SendAsync(httpRequestMessage, cancellationToken);

            if (!response.IsSuccessStatusCode)
            {
                throw new EndOfStreamException(string.Join(",", response));
            }

            var r=  _parser.ParseAsync(response);
            Console.WriteLine("Handler completed!");
            return r;
        }


    }
}