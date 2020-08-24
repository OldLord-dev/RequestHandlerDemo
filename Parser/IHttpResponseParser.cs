using System.Net.Http;

namespace Parser
{
    public interface IHttpResponseParser<out TResult>
    {
        TResult ParseAsync(HttpResponseMessage response);
    }

}