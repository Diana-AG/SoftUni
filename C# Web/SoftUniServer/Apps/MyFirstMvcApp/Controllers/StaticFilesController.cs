namespace MyFirstMvcApp.Controllers
{
    using SUS.HTTP;
    using SUS.MvcFramework;
    using System;

    public class StaticFilesController : Controller
    {
        public HttpResponse Favicon(HttpRequest request)
        {
            return this.File("wwwroot/favicon.ico", "image/vnd.microsoft.icon");
        }

        public HttpResponse BootstrapCss(HttpRequest request)
        {
            return this.File("wwwroot/Css/bootstrap.min.css", "text/css");
        }

        public HttpResponse CustomCss(HttpRequest request)
        {
            return this.File("wwwroot/Css/custom.css", "text/css");
        }
        public HttpResponse CustomJs(HttpRequest request)
        {
            return this.File("wwwroot/Js/custom.js", "text/javascript");
        }

        public HttpResponse BootstrapJs(HttpRequest request)
        {
            return this.File("wwwroot/Js/bootstrap.bundle.min.js", "text/javascript");
        }
    }
}
