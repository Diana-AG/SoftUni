namespace SUS.HTTP
{
    using System.Text;

    public class ResponseCookie : Cookie
    {
        public ResponseCookie(string name, string value) 
            : base(name, value)
        {
            this.Path = "/";
        }

        public string Path { get; set; }

        public int MaxAge { get; set; }

        public bool HttpOnly { get; set; }

        public bool Secure { get; set; }

        public override string ToString()
        {
            StringBuilder cookieBuilder = new StringBuilder();

            cookieBuilder.Append($"{this.Name}={this.Value}; Path={this.Path};");
            if (this.MaxAge != 0)
            {
                cookieBuilder.Append($" Max-Age={this.MaxAge};");
            }

            if (this.HttpOnly)
            {
                cookieBuilder.Append(" HttpOnly;");
            }

            if (this.Secure)
            {
                cookieBuilder.Append(" Secure;");
            }

            return cookieBuilder.ToString();
        }
    }
}
