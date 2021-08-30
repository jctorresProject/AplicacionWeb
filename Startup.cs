using AppWebPruebaTecnicaSICO.ContextoDatos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebPruebaTecnicaSICO
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
            services.AddCors(options => { options.AddPolicy("Autorizar", builder => { builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); }); });
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ConnectionString")));
            services.AddControllers();
            services.AddSwaggerGen(c =>{c.SwaggerDoc("v1", new OpenApiInfo { Title = "AppWebPruebaTecnicaSICO", Version = "v1" });});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AppWebPruebaTecnicaSICO v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors("Autorizar");
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>{endpoints.MapControllers();});
        }
    }
}
