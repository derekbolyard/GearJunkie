using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Autofac;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
using Autofac.Configuration;

namespace GearJunkie.Api
{
    public class Startup
    {
        private IConfiguration config;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            this.config = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc(config =>
            config.Filters.Add(typeof(Filters.GlobalExceptionFilter)));
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            var config = new ConfigurationBuilder();
            config.AddJsonFile(this.CombinePath("autofac.json"));

            var module = new ConfigurationModule(config.Build());

            builder.RegisterModule(module);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }

        private string CombinePath(string file)
        {
            var basePath = PlatformServices.Default.Application.ApplicationBasePath;

            var retVal = Path.Combine(basePath, file);

            return retVal;
        }
    }
}
