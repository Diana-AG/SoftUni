namespace SUS.MvcFramework
{
    using System.Net.Http;

    public class HttpGetAttribute : BaseHttpAttribute
    {
        public HttpGetAttribute()
        {
        }
        
        public HttpGetAttribute(string url)
        {
            this.Url = url;
        }
        public override HttpMethod Method => HttpMethod.Get;

        public string Url { get; }
    }
}
