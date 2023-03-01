namespace SharedTrip.Controllers
{
    using SUS.HTTP;
    using SUS.MvcFramework;

    public class TripsController : Controller
    {
        public HttpResponse All()
        {
            if (!this.IsUserSignedIn())
            {
                this.Redirect("/Users/Login");
            }

            return this.View();
        }
        public HttpResponse Add()
        {
            if (!this.IsUserSignedIn())
            {
                this.Redirect("/Users/Login");
            }

            return this.View();
        }

        public HttpResponse Details()
        {
            if (!this.IsUserSignedIn())
            {
                this.Redirect("/Users/Login");
            }

            return this.View();
        }
    }
}
