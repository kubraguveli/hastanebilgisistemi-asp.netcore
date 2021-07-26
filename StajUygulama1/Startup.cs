using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StajUygulama1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajUygulama1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });



            services.AddMvc();
            //yukarýda tanýmlanan configuration nesnesi ile connection strigne ulaþýlýp veritabaný baðlantýsý saðlandý
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString(("DataConnection"))));


            services.AddTransient<IHastaBilgiRepository, EfHastaBilgiRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseDeveloperExceptionPage();  //hata olduðunda hata kodunu gösterir
            app.UseStatusCodePages();  //404 ya da server hatasý varsa gösterir
            app.UseStaticFiles();  //root css dosyalarý için
            app.UseMvcWithDefaultRoute();
        }
    }
}
