namespace SUS.MvcFramework
{
    using System;
    using System.Net.Http;

    public abstract class BaseHttpAttribute : Attribute
    {
        public string Url { get; set; }

        public abstract HttpMethod Method { get; }
    }
}
