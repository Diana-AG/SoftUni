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
            serviceCollection.Add<IUserService, UserService>();
            serviceCollection.Add<ISubmissionService, SubmissionService>();
            serviceCollection.Add<IProgramService, ProgramService>();
        }
    }
}
