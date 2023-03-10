namespace Suls
{
    using Microsoft.EntityFrameworkCore;
    using Suls.Data;
    using Suls.Services;
    using SUS.HTTP;
    using SUS.MvcFramework;
    using System.Collections.Generic;

    public class Startup : IMvcApplication
    {
        public void Configure(List<Route> routeTable)
        {
            new ApplicationDbContext().Database.Migrate();
        }

        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.Add<IUsersService, UsersService>();
            serviceCollection.Add<ISubmissionsService, SubmissionsService>();
            serviceCollection.Add<IProblemsService, ProblemsService>();
        }
    }
}
