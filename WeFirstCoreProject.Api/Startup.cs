﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeFirstCoreProject.Application.Interface;
using WeFirstCoreProject.Application.Services;
using WeFirstCoreProject.Infrastructure.IRepository;
using WeFirstCoreProject.Model.Map;

namespace WeFirstCoreProject.Api
{
    public class Startup
    {
        public static IConfiguration Configuration { get; private set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<FirstProjectContext>(options => options.UseSqlServer(Configuration["connectionStrings:productionInfoDbConnectionString"]));
            services.AddScoped(typeof(IProjectService<>), typeof(ProjectService<>));
            services.AddScoped(typeof(IProjectRepository<>), typeof(ProjectRepository<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStatusCodePages();//
            app.UseMvc();
        }
    }
}
