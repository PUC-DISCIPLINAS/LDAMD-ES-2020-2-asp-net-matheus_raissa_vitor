using System;
using System.Collections.Generic;
using System.Text;
using covid_dashboard_aspnet_core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace covid_dashboard_aspnet_core.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DataCovid> DataCovid { get; set; }
        public DbSet<Country> Country { get; set; }

    }
}
