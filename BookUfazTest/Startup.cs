using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookUfazTest.Data;
using BookUfazTest.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookUfazTest
{
    public class Startup
    {
        private IConfiguration _conf;

        public  Startup(IConfiguration conf)
        {
            _conf = conf;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
          
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_conf["DefaultConnection"]));
            services.AddIdentity<StudentUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireUppercase = false;
                options.Password.RequireDigit = true;
                options.Password.RequireNonAlphanumeric = false;

            });
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
            
/*            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });*/
        }
    }
}
