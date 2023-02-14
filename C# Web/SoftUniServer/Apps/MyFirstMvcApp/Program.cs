namespace MyFirstMvcApp
{
    using MyFirstMvcApp.Controllers;
    using SUS.HTTP;
    using SUS.MvcFramework;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            

            await Host.CreateHostAsync(new Startup(), 80);
        }
    }
}
