namespace SharedTrip.Controllers
{
    using SUS.HTTP;
    using SUS.MvcFramework;

    public class TripsController : Controller
    {
        public HttpResponse All()
        {
            return this.View();
        }
        public HttpResponse Add()
        {
            return this.View();
        }

        public HttpResponse Details()
        {
            return this.View();
        }
    }
}
