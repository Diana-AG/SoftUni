﻿namespace MyFirstMvcApp.Controllers
{
    using SUS.HTTP;
    using SUS.MvcFramework;
    using System;

    public class UsersController : Controller
    {
        public HttpResponse Login(HttpRequest request)
        {            
            return this.View();
        }
        public HttpResponse Register(HttpRequest request)
        {
            return this.View();
        }

        public HttpResponse DoLogin(HttpRequest arg)
        {
            //TODO: read data
            //TODO: check user
            //TODO: log user
            return this.Redirect("/");
        }
    }
}
