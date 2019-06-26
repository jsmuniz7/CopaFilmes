using System;
using System.IO;
using System.Reflection;
using CopaFilmes.Application.Core;
using CopaFilmes.Application.Domain;
using CopaFilmes.Application.Domain.Interfaces;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace CopaFilmes.Api
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
            AddApplicationServices(services);

            services.AddCors();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CopaFilmes API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseCors(x => x.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseMvc();
        }

        private static void AddApplicationServices(IServiceCollection services)
        {
            AddSwagger(services);
            AddMediatr(services);
            AddRules(services);
        }

        private static void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Copa Filmes API",
                    Description = "ASP.NET Core Web API to provide functionallity to Copa Filmes Championship",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Jonathan Souza Muniz",
                        Email = "jonathan-muniz@outlook.com",
                        Url = "https://github.com/jsmuniz7"
                    },
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        private static void AddMediatr(IServiceCollection services)
        {
            const string applicationAssemblyName = "CopaFilmes.Application";
            var assembly = AppDomain.CurrentDomain.Load(applicationAssemblyName);

            AssemblyScanner
                .FindValidatorsInAssembly(assembly)
                .ForEach(result => services.AddScoped(result.InterfaceType, result.ValidatorType));

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(FailFastRequestBehavior<,>));

            services.AddMediatR(assembly);
        }

        private static void AddRules(IServiceCollection services)
        {
            services.AddSingleton<IChampionshipRules, ChampionshipRules>();
            services.AddSingleton<IMatchRules, MatchRules>();
        }
    }
}
