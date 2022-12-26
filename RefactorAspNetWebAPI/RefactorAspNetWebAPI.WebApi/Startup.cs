using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RefactorAspNetWebAPI.Application;
using RefactorAspNetWebAPI.Infrastructure.Persistence;
using RefactorAspNetWebAPI.Infrastructure.Persistence.Contexts;
using RefactorAspNetWebAPI.Infrastructure.Shared;
using RefactorAspNetWebAPI.WebApi.Extensions;
using Serilog;

namespace RefactorAspNetWebAPI.WebApi
{
    public class Startup
    {
        public IConfiguration _config { get; }

        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplicationLayer();
            services.AddPersistenceInfrastructure(_config);
            services.AddSharedInfrastructure(_config);
            services.AddSwaggerExtension();
            services.AddControllersExtension();
            // CORS
            services.AddCorsExtension();
            services.AddHealthChecks();
            //API Security
            services.AddJWTAuthentication(_config);
            services.AddAuthorizationPolicies(_config);
            // API version
            services.AddApiVersioningExtension();
            // API explorer
            services.AddMvcCore()
                .AddApiExplorer();
            // API explorer version
            services.AddVersionedApiExplorerExtension();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext dbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            dbContext.Database.EnsureCreated();

            // Add this line; you'll need `using Serilog;` up the top, too
            app.UseSerilogRequestLogging();
            app.UseHttpsRedirection();
            app.UseRouting();
            //Enable CORS
            app.UseCors("AllowAll");
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSwaggerExtension();
            app.UseErrorHandlingMiddleware();
            app.UseHealthChecks("/health");

            app.UseEndpoints(endpoints =>
             {
                 endpoints.MapControllers();
             });
        }
    }
}