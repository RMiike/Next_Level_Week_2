using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NextLevelWeek2.Data.Data;
using Proffy.ApplicationService.Services;
using Proffy.Core.Contracts;
using Proffy.Data.Repositories;

namespace NextLevelWeek2.WebAPI
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

            services.AddDbContext<ProffyDbContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("ConnectionString")));

            services.AddScoped<IClassRepository, ClassRepository>(); 
            services.AddScoped<IClassScheduleRepository, ClassScheduleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICreateClassServices, CreateClassServices>();
            services.AddScoped<IConnectionRepository, ConnectionRepository>();
            services.AddScoped<IConnectionServices , ConnectionServices>();


            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(x =>
              x.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
