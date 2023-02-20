﻿namespace MyFirstMvcApp
{
    using BattleCards.Data;
    using Microsoft.EntityFrameworkCore;
    using SUS.HTTP;
    using SUS.MvcFramework;
    using System.Collections.Generic;

    public class Startup : IMvcApplication
    {
        public void ConfigureServices()
        {
        }

        public void Configure(List<Route> routeTable)
        {
            new ApplicationDbContext().Database.Migrate();
        }
    }
}
