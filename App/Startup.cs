using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace App
{
    class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(_ => _.UseSqlServer(Configuration.GetConnectionString("DataContext"),
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(DataContext).Assembly.GetName().Name)));

        }

        public void Configure(IApplicationBuilder app)
        {
        
        }
    }
}
