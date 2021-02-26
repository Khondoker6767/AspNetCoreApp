using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreProject.BLL.Interfaces;
using CoreProject.BLL.Repository;
using EmployeeManagement.Models;
using EmployeeManagement.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _configaration;

        public Startup(IConfiguration configuration)
        {
            _configaration = configuration;
        }

        //OPTIONAL TO USE
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options =>
            options.UseSqlServer(_configaration.GetConnectionString("AppDbContext")));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddMvc().AddXmlSerializerFormatters();
            services.AddTransient<IEmployeeRepository, EmployeeSqlRepository>();
            services.AddTransient<IplayerRepository, PlayersRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2).AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver()); ;

        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy();
            

            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "default",
                    template: "{controller=Account}/{action=Register}/{id?}");
            });           
        }
    }
}
