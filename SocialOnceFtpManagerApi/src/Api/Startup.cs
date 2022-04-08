using EAProductService.Api.Filters;
using EAProductService.Api.Services;
using EAProductService.Application;
using EAProductService.Application.Common.Interfaces;
using EAProductService.Domain.Entities;
using EAProductService.Infrastructure;
using EAProductService.Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NSwag;
using NSwag.Generation.Processors.Security;
using System.Linq;

namespace EAProductService.Api
{
    public class Startup
    {
        readonly string TestOrigins = "_testOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDefaultIdentity<Users>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();

            services.AddApplication();
            services.AddInfrastructure(Configuration);

            services.AddSingleton<ICurrentUserService, CurrentUserService>();

            services.AddHttpContextAccessor();

            //services.AddHealthChecks().AddDbContextCheck<ApplicationDbContext>();

            services.AddAuthentication(AzureADB2CDefaults.BearerAuthenticationScheme)
            .AddAzureADB2CBearer(options => Configuration.Bind("AzureAdB2C", options));

            services.AddCors(options =>
            {
                options.AddPolicy(TestOrigins,
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });

            services.AddControllers()
               .AddNewtonsoftJson();

            // Customise default API behaviour
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });


            services.AddOpenApiDocument(configure =>
            {
                configure.Title = "EAProductService API";
                configure.AddSecurity("JWT", Enumerable.Empty<string>(), new OpenApiSecurityScheme
                {
                    Type = OpenApiSecuritySchemeType.ApiKey,
                    Name = "Authorization",
                    In = OpenApiSecurityApiKeyLocation.Header,
                    Description = "Type into the textbox: Bearer {your JWT token}."
                });

                configure.OperationProcessors.Add(new AspNetCoreOperationSecurityScopeProcessor("JWT"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationDbContext applicationDbContext)
        {
            app.UseCors(TestOrigins);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseSwagger();
                //app.UseSwaggerUi(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SocialOnceFtpManagerApi v1"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHealthChecks("/health");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            //if (!env.IsDevelopment())
            //{
            //    app.UseSpaStaticFiles();
            //}

            app.UseSwaggerUi3(settings =>
            {
                settings.Path = "/api";
                settings.DocumentPath = "/api/specification.json";
            });

            app.UseRouting();

            app.UseAuthentication();
            //app.UseIdentityServer();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            applicationDbContext.Database.Migrate();

        }
    }
}
