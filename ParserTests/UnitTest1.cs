using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Parser;

namespace testy
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HttpRequestHandler<string,string> h = new HttpRequestHandler<string, string>(new HttpClient(), new Parser<string>());
            Task<string> t = h.Handle(new StringContent(""), HttpMethod.Get, "https://www.google.com", new Dictionary<string, string>(), new System.Threading.CancellationToken());
            Assert.Equal("StatusCode: 200", t.Result.Substring(0, 15));
        }

        [Fact]
        public void Test2()
        {
            HttpRequestHandler<string,string> h = new HttpRequestHandler<string, string>(new HttpClient(), new Parser<string>());
            Task<string> t = h.Handle(new StringContent(""), HttpMethod.Post, "https://www.google.com", new Dictionary<string, string>(), new System.Threading.CancellationToken());
            try {
                var r = t.Result;
            } catch (Exception e) {
                Assert.Equal("One or more errors occurred. (StatusCode: 405", e.Message.Substring(0, 45));
            }
        }

                [Fact]
        public void Test3()
        {
            HttpRequestHandler<string,string> h = new HttpRequestHandler<string, string>(new HttpClient(), new Parser<string>());
            Task<string> t = h.Handle(new StringContent("dadad"), HttpMethod.Get, "https://www.google.com", new Dictionary<string, string>(), new System.Threading.CancellationToken());
                try {
                var r = t.Result;
                Assert.True(false);
            } catch (Exception e) {
                Assert.Equal("One or more errors occurred. (StatusCode: 400", e.Message.Substring(0, 45));
            }
            
        }

    }
}
