using Application.Repositories;
using Autofac;
using AutoMapper;
using Infrastructure;
using Infrastructure.EFDataAcess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UserMicroService.config;

namespace UserMicroService
{
    public class Startup
    {
        public ILifetimeScope AutofacContainer { get; private set; }
        private ConfigurationSetting _configurationSetting;
        public IConfiguration Configuration { get; }

        public Startup(IWebHostEnvironment env)
        {
            // In ASP.NET Core 3.0 `env` will be an IWebHostEnvironment, not IHostingEnvironment.
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            this.Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _configurationSetting = services.RegisterConfiguration(Configuration);
            services.AddConsulConfig(_configurationSetting);

            services.AddCors();
            services.AddHttpClient();
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddDbContext<UserContext>(options =>
      options.UseSqlServer(Configuration.GetConnectionString("UserDb")));
            services.AddTransient<IUserReadOnlyRepository, UserRepository>();
            services.AddTransient<IUserWriteOnlyRepository, UserWriteRepository>();
            services.AddOptions();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(builder =>
            {
                builder.WithOrigins("http://localhost:4200");
                builder.AllowAnyMethod();
                builder.AllowAnyHeader();
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseConsul(_configurationSetting);
        }
    }
}
