using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ReCapProject.Business.Abstract;
using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReCapWebAPI
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
            services.AddControllers();

            //services.AddSingleton<ICarDal, EfCarDal>();
            //services.AddSingleton<ICarService, CarManager>();

            //services.AddSingleton<IBrandDal, EfBrandDal>();
            //services.AddSingleton<IBrandService, BrandManager>();

            //services.AddSingleton<IColorDal, EfColorDal>();
            //services.AddSingleton<IColorService, ColorManager>();

            //services.AddSingleton<IRentalDal, EfRentalDal>();
            //services.AddSingleton<IRentalService, RentalManager>();

            //services.AddSingleton<ICustomerDal, EfCustomerDal>();
            //services.AddSingleton<ICustomerService, CustomerManager>();

            //services.AddSingleton<IUserDal, EfUserDal>();
            //services.AddSingleton<IUserService, UserManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
